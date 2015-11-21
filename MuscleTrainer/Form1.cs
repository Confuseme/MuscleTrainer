using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MuscleTrainer
{
    public partial class Window : Form
    {
        //bool succeeded = false;
        int lastx, lasty, lastz, lastmap;
        int last_grey_enabled;
        bool updating = false;
        int ticks = 0;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        /**
         * Find base adress of PSX memory
         * @return Game memory start offset
         **/
        private IntPtr? ReadDEbaseAdress()
        {
            IntPtr? addr = Emulator.baseAddr;

            /**
             * Failed with all emulators
             * Update labels and buttons
             **/
            if (addr == null)
            {
                LabelPsxfin.Enabled = false; LabelEpsxe.Enabled = false;
                SetWriteButtons(false);
            }
            else
            {
                SetWriteButtons(true);
                if (Emulator.emulator == Emulator.PSXFIN) //psxfin: Update labels and buttons
                {
                    LabelPsxfin.Enabled = true; LabelEpsxe.Enabled = false; 
                }
                if (Emulator.emulator == Emulator.EPSXE) //ePSXe: Update labels and buttons
                {
                    LabelPsxfin.Enabled = false; LabelEpsxe.Enabled = true; 
                }
            }
            return addr;
        }

        private void SetWriteButtons(bool enabled)
        {
            ButtonSetX.Enabled = true; ButtonSetY.Enabled = true; ButtonSetZ.Enabled = true;
        }

        //TODO: rewrite as get/set properties for int x,y,z
        private void UpdateReadValues()
        {
            ticks++;
            IntPtr? baseAddr = ReadDEbaseAdress();
            if (baseAddr == null)
            {
                return; //Fatal error
            }
            byte[] readBuf = new byte[4];
            MemoryIO mio = new MemoryIO(Emulator.emulator);
            if (!mio.processOK()) return;

            int? x = UpdateReadValue(NumericUpDownX, TextBoxXRead, Offset.X, mio);
            int? y = UpdateReadValue(NumericUpDownY, TextBoxYRead, Offset.Y, mio);
            int? z = UpdateReadValue(NumericUpDownZ, TextBoxZRead, Offset.Z, mio);

            /**
             * Chart coordinates
             **/
            if (ticks >= 1000 / TimerUpdate.Interval) //1 ssecond interval
            {
                ticks = 0;
                int? chart_x = Variable.chart_x;
                int? chart_y = Variable.chart_y;
                if (chart_x != null && chart_y != null)
                { //Set last character to 
                    int chartx = (int)((chart_x + 5) / 10);
                    int lengthx = LabelChartX.Text.Length;
                    if (LabelChartX.Text[lengthx - 2] == '-') lengthx--;
                    LabelChartX.Text = LabelChartX.Text.Substring(0, lengthx - 1) + chartx;
                    int charty = (int)(-(chart_y + 5) / 10);
                    int lengthy = LabelChartY.Text.Length;
                    if (LabelChartY.Text[lengthy - 2] == '-') lengthy--;
                    LabelChartY.Text = LabelChartY.Text.Substring(0, lengthy - 1) + charty;
                }
            }

            /**
             * Events
             **/
            int? event_x = Variable.event_x; int? event_y = Variable.event_y; int? events = Variable.events;
            if (event_x != null && event_y != null && events != null)
            {
                LabelEventX.Text = "x = " + event_x;
                LabelEventY.Text = "y = " + event_y;
                LabelEvents.Text = "n = " + events;
            }

            /**
             * Grayman
             **/
            int? gray_enabled = Variable.gray_enabled;
            if (gray_enabled != null && last_grey_enabled != gray_enabled)
            {
                last_grey_enabled = (int)gray_enabled;
                if (gray_enabled == 0)
                {
                    labelGrayman.Text = "";
                }
                else
                {
                    labelGrayman.Text = "GRAY GRAY" + Environment.NewLine + "GRAY GRAY"
                                                    + Environment.NewLine + "GRAY GRAY";
                }
            }

            /**
             * Map related
             **/
            int? map = ReadMap();
            if (map == null || x == null || y == null || z == null) return;

            // Redraw map crosshair if moved
            if (x != lastx || y != lasty)
            {
                RedrawMapCrosshair((int)map, (int)x, (int)y);
            }

            //Map change
            if (map != lastmap)
            {
                /**
                 * Map starting position
                 **/
                int? map_pos = Variable.map_pos;
                if (map_pos != null)
                {
                    LabelMapPos.Text = "Pos = " + ((int)map_pos).ToString("X8");
                }

                /**
                 * Update xyz coordinates if new map
                 **/
                if (lastx != x || lasty != y || lastz != z) //New position
                {
                    lastmap = (int)map;
                    LabelMap.Text = "Map = " + lastmap.ToString();
                    NumericUpDownX.Value = (int)x; NumericUpDownY.Value = (int)y; NumericUpDownZ.Value = (int)z;
                }
            }
            lastx = (int)x; lasty = (int)y; lastz = (int)z;
        }

        /**
         * Read position variable
         **/
        private int? UpdateReadValue(NumericUpDown nud, TextBox tb, int offset, MemoryIO mio)
        {
            IntPtr? addr = Emulator.baseAddr;
            if (addr == null) return null;
            IntPtr pointer = new IntPtr((int)addr + offset);
            byte[] readBuf = new byte[4];
            mio.MemoryRead(pointer, readBuf);
            int value = BitConverter.ToInt32(readBuf, 0);
            if (value < nud.Minimum || nud.Maximum < value) //Outside normal range?
            {
                value = (int)nud.Value;
            }
            tb.Text = value.ToString();
            return value;
        }

        /**
         * This variable is the current_location copy that is updated last
         * useful when we want the new xyz map coordinates
         **/
        private int? ReadMap()
        {
            IntPtr? baseAddr = ReadDEbaseAdress();
            if (baseAddr == null)
            {
                return null; //Fatal error
            }
            byte[] readBuf = new byte[4];

            MemoryIO mio = new MemoryIO(Emulator.emulator);
            if (!mio.processOK()) return null;
            
            IntPtr mappointer = new IntPtr((int)baseAddr + Offset.map);
            mio.MemoryRead(mappointer, readBuf);
            int map = BitConverter.ToInt32(readBuf, 0);
            if(Range.isInsideRange(Range.map, map)) return map;
            return null;
        }

        private void ButtonSetX_Click(object sender, EventArgs e)
        {
            ButtonSet(NumericUpDownX, Offset.X);
        }

        private void ButtonSetY_Click(object sender, EventArgs e)
        {
            ButtonSet(NumericUpDownY, Offset.Y);
        }

        private void ButtonSetZ_Click(object sender, EventArgs e)
        {
            ButtonSet(NumericUpDownZ, Offset.Z);
        }
        
        //TODO: Use sender or e to get nud and offset
        private void ButtonSet(NumericUpDown nud, int offset)
        {

            IntPtr? baseAddr = ReadDEbaseAdress();
            if (baseAddr == null)
            {
                return; //Fatal error
            }

            if (nud.Text == "")
            {
                return;
            }
            byte[] writeBuf = new byte[4];
            writeBuf = BitConverter.GetBytes(Convert.ToInt32(nud.Text));

            MemoryIO mio = new MemoryIO(Emulator.emulator);
            if (!mio.processOK()) return;

            /**
             * Write position variable
             **/
            IntPtr pointer = new IntPtr((int)baseAddr + offset);
            mio.MemoryWrite(pointer, writeBuf);
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            if (updating) return;
            updating = true;
            UpdateReadValues();
            updating = false;
        }

        private void RedrawMapCrosshair(int map, int x, int y)
        {
            if (map != 3) return; //Only draw for The Natural World map
            int center = PictureBoxMap.Width / 2; //Width == height here
            center -= 2; //Circle center
            x -= -310000; y -= 310000; //Map offset
            x /= 2500; y /= -2500; //Map scale
            //Console.Out.WriteLine("Map: (" + x + ", "+ y + ")");

            Graphics g = PictureBoxMap.CreateGraphics();
            //g.DrawEllipse(System.Drawing.Pens.Cyan, center, center, 1, 1);
            g.DrawEllipse(System.Drawing.Pens.Purple, x, y, 4, 4);
            g.Dispose();

            //TODO: If not the natural world, do we need to redraw?
            //The crosshair should stay on the specific coordinate
            // while we stay at the same map
        }

        private void NumericUpDownX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSetX_Click(null, null); //TODO its own function
            }
        }

        private void NumericUpDownY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSetY_Click(null, null); //TODO its own function
            }
        }

        private void NumericUpDownZ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSetZ_Click(null, null); //TODO its own function
            }
        }

        private void ButtonCopyX_Click(object sender, EventArgs e)
        {
            NumericUpDownX.Value = lastx;
        }

        private void ButtonCopyY_Click(object sender, EventArgs e)
        {
            NumericUpDownY.Value = lasty;
        }

        private void ButtonCopyZ_Click(object sender, EventArgs e)
        {
            NumericUpDownZ.Value = lastz;
        }
    }
}
