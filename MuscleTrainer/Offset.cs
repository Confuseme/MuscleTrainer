using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleTrainer
{
    abstract class Offset
    {
        public static readonly int X = 0x91e74;
        public static readonly int Y = 0x91e7c;
        public static readonly int Z = 0x91e78;

        public static readonly int map = 0x8abf8;
        public static readonly int map_pos = 0x9169c;

        public static readonly int chart_draw_x = 0x94008;
        public static readonly int chart_draw_y = 0x9400c;
        public static readonly int chart_return_x = 0x94014;
        public static readonly int chart_return_y = 0x94016;

        public static readonly int event_x = 0x91678;
        public static readonly int event_y = 0x9167c;
        public static readonly int events = 0x91680;

        public static readonly int tex_x = 0x1F1B86;
        public static readonly int tex_y = 0x1F1C72;

        public static readonly int psxfinMemstart = 0x171A5C;
        public static readonly int psxfinVersion = 0x128D34;

        public static readonly int ePSXeMemstart = 0xA579A0;
        public static readonly int ePSXeVersion = 0x933E38;
    }
}
