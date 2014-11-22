using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleTrainer
{
    static class Emulator
    {
        public static readonly string PSXFIN = "psxfin";
        public static readonly string EPSXE = "ePSXe";
        public static readonly string PSXFIN_VERSION = "psxfin v.1.13";
        public static readonly string EPSXE_VERSION = "ePSXe v.1.9.0";

        public static string emulator;
        private static List<string> badVersionsMessaged;
        public static IntPtr? baseAddr
        {
            get
            {
                //Try psxfin
                IntPtr? DEbaseAdress = DetectPsxfin();
                if (DEbaseAdress != null) return DEbaseAdress;
                //Try ePSXe
                DEbaseAdress = DetectEPSXe();
                if (DEbaseAdress != null) return DEbaseAdress;
                return null;
            }
        }

        private static IntPtr? DetectPsxfin()
        {
            /**
             * Try to acquire permissions for psxfin
             **/
            emulator = PSXFIN;
            byte[] readBuf = new byte[4];
            MemoryIO mioRelative = new MemoryIO(emulator, true); //Program start = 0
            if (!mioRelative.processOK())
            {
                return null;
            }
            IntPtr baseAddrPointer = new IntPtr(Offset.psxfinMemstart); //psxfin.exe+171A5C, memstart ptr
            mioRelative.MemoryRead(baseAddrPointer, readBuf);

            /**
             * Verify that psxfin version == 1.13
             * This method uses the text in the about window
             **/
            byte[] psxfinVersion = new byte[] { 0x70, 0x00, 0x53, 0x00, 
                0x58, 0x00, 0x20, 0x00, 0x76, 0x00, 0x31, 0x00, 
                0x2E, 0x00, 0x31, 0x00, 0x33, 0x00, 0x00, 0x00 }; //TODO use text instead
            byte[] psxfinVersionBuf = new Byte[20];
            IntPtr psxfinVersionPtr = new IntPtr(Offset.psxfinVersion);
            mioRelative.MemoryRead(psxfinVersionPtr, psxfinVersionBuf);
            bool badVersion = false;
            for (int i = 0; i < psxfinVersion.Length; i++)
            {
                if (psxfinVersion[i] != psxfinVersionBuf[i]) badVersion = true;
            }
            if (!badVersion) return (IntPtr)BitConverter.ToInt32(readBuf, 0);
            bool empty = true; //Read error, maybe starting up
            foreach (byte b in psxfinVersionBuf) if (b != 0) empty = false; //All bytes == 0?
            if (!empty) MessageWrongVersion(PSXFIN_VERSION);
            return null; //Wrong version => Fail
        }

        private static IntPtr? DetectEPSXe()
        {
            emulator = EPSXE;
            MemoryIO mioRelative = new MemoryIO(emulator, true); //Program start = 0
            if (!mioRelative.processOK()) return null;
            /**
             * Verify that ePSXe version == 1.9.0
             * This method uses the text in the about window
             **/
            byte[] ePSXeVersion = new byte[] { 0x65, 0x00, 0x50, 0x00, 
                0x53, 0x00, 0x58, 0x00, 0x65, 0x00, 0x20, 0x00, 
                0x28, 0x00, 0x45, 0x00, 0x6E, 0x00, 0x68, 0x00, 
                0x61, 0x00, 0x6E, 0x00, 0x63, 0x00, 0x65, 0x00, 
                0x64, 0x00, 0x20, 0x00, 0x50, 0x00, 0x53, 0x00, 
                0x58, 0x00, 0x20, 0x00, 0x45, 0x00, 0x6D, 0x00, 
                0x75, 0x00, 0x6C, 0x00, 0x61, 0x00, 0x74, 0x00, 
                0x6F, 0x00, 0x72, 0x00, 0x29, 0x00, 0x20, 0x00, 
                0x76, 0x00, 0x2E, 0x00, 0x31, 0x00, 0x2E, 0x00, 
                0x39, 0x00, 0x2E, 0x00, 0x30, 0x00, 0x2E, 0x00, 
                0x0A, 0x00, 0x20, 0x00, 0x5B, 0x00, 0x68, 0x00, 
                0x74, 0x00, 0x74, 0x00, 0x70, 0x00, 0x3A, 0x00, 
                0x2F, 0x00, 0x2F, 0x00, 0x77, 0x00, 0x77, 0x00, 
                0x77, 0x00, 0x2E, 0x00, 0x65, 0x00, 0x70, 0x00, 
                0x73, 0x00, 0x78, 0x00, 0x65, 0x00, 0x2E, 0x00, 
                0x63, 0x00, 0x6F, 0x00, 0x6D, 0x00, 0x5D, 0x00 }; //TODO use text instead
            byte[] ePSXeVersionBuf = new Byte[124];
            IntPtr ePSXeVersionPtr = new IntPtr(Offset.ePSXeVersion);
            mioRelative.MemoryRead(ePSXeVersionPtr, ePSXeVersionBuf);
            bool badVersion = false;
            for (int i = 0; i < ePSXeVersion.Length; i++)
            {
                if (ePSXeVersion[i] != ePSXeVersionBuf[i]) badVersion = true;
            }
            if (!badVersion) return (IntPtr)Offset.ePSXeMemstart; //Memory start (fixed pos, no pointer needed)
            bool empty = true; //Read error, maybe starting up
            foreach (byte b in ePSXeVersionBuf) if (b != 0) empty = false; //All bytes == 0?
            if (!empty) MessageWrongVersion(EPSXE_VERSION);
            return null; //Wrong version => Fail
        }

        private static void MessageWrongVersion(string emulator)
        {
            if (badVersionsMessaged == null)
            {
                badVersionsMessaged = new List<string>();
            }
            if (badVersionsMessaged.Contains(emulator)) return; //Message already shown
            badVersionsMessaged.Add(emulator);
            System.Windows.Forms.MessageBox.Show("Only " + emulator + " is supported",
                "Emulator version not supported",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Exclamation,
                System.Windows.Forms.MessageBoxDefaultButton.Button1);
        }
    }
}
