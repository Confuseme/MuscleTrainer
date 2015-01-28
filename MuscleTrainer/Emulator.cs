using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices; //DllImport

namespace MuscleTrainer
{
    static class Emulator
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, UIntPtr count);

        public static readonly string PSXFIN = @"psxfin";
        public static readonly string EPSXE = @"ePSXe";
        public static readonly string PSXFIN_VERSION = @"psxfin v.1.13";
        public static readonly string EPSXE_VERSION = @"ePSXe v.1.9.0";

        //About window text strings
        public static readonly string PSXFIN_VERSION_CHECK = "pSX v1.13\0";
        public static readonly string PPSXE_VERSION_CHECK = @"ePSXe (Enhanced PSX Emulator) v.1.9.0.";

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

            //Detect version
            byte[] expected = System.Text.Encoding.Unicode.GetBytes(PSXFIN_VERSION_CHECK);
            byte[] psxfinVersionBuf = new Byte[expected.Length];
            IntPtr psxfinVersionPtr = new IntPtr(Offset.psxfinVersion);
            mioRelative.MemoryRead(psxfinVersionPtr, psxfinVersionBuf);
            if (memcmp(expected, psxfinVersionBuf, new UIntPtr((uint)expected.Length)) == 0)
                return (IntPtr)BitConverter.ToInt32(readBuf, 0);
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

            //Detect version
            byte[] expected = System.Text.Encoding.Unicode.GetBytes(PPSXE_VERSION_CHECK);
            byte[] ePSXeVersionBuf = new Byte[expected.Length];
            IntPtr ePSXeVersionPtr = new IntPtr(Offset.ePSXeVersion);
            mioRelative.MemoryRead(ePSXeVersionPtr, ePSXeVersionBuf);
            if (memcmp(expected, ePSXeVersionBuf, new UIntPtr((uint)expected.Length)) == 0)
                return (IntPtr)Offset.ePSXeMemstart; //Memory start (fixed pos, no pointer needed)
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
