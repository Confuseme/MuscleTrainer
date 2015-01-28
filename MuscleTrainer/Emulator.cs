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

        //Returns main memory start
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

            return versionOk(PSXFIN_VERSION_CHECK, mioRelative, (IntPtr)Offset.psxfinVersion)
                ? (IntPtr?)BitConverter.ToInt32(readBuf, 0) : null;
        }

        //Returns main memory start
        private static IntPtr? DetectEPSXe()
        {
            emulator = EPSXE;
            MemoryIO mioRelative = new MemoryIO(emulator, true); //Program start = 0
            if (!mioRelative.processOK()) return null;

            return versionOk(PPSXE_VERSION_CHECK, mioRelative, (IntPtr)Offset.ePSXeVersion)
                ? (IntPtr?)Offset.ePSXeMemstart : null; //Fixed pos, no pointer needed)
        }

        //Detect if supported version
        private static bool versionOk(string checkVersion, MemoryIO mioRelative, IntPtr versionPtr)
        {
            byte[] expected = System.Text.Encoding.Unicode.GetBytes(checkVersion);
            var versionBuf = new Byte[expected.Length];
            mioRelative.MemoryRead(versionPtr, versionBuf);
            if (memcmp(expected, versionBuf, new UIntPtr((uint)expected.Length)) == 0)
                return true;
            bool empty = true; //Read error, maybe starting up
            foreach (byte b in versionBuf) if (b != 0) empty = false; //All bytes == 0?
            if (!empty) MessageWrongVersion(checkVersion);
            return false; //Wrong version => Fail
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
