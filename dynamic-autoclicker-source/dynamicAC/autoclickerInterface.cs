using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace dynamicAC
{
    public partial class autoclicker : Form
    {
        public autoclicker()
        {
            InitializeComponent();
            top_drag.BackColor = Color.FromArgb(5, 30, 30, 30);
        }

        // properties
        public bool clickerEnabled = false;
        private bool isMouseDown;
        private Point lastLocation;

        // delays
        int Delay1;
        int Delay2;

        // import needed dlls
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        // CLICK - LEFT
        private const int LEFTDOWN = 0x02;
        private const int LEFTUP = 0x04;

        // CLICK - RIGHT
        private const int RIGHTDOWN = 0x08;
        private const int RIGHTUP = 0x10;

        bool rightClick;

        // AUTOCLICKER RELATED
        private void CPS_trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            CPS_LEFT.Text =  "CPS - " + CPS_trackbar.Value.ToString();
        }

        private void autoclicker_start_btn_Click(object sender, EventArgs e)
        {
            clickerEnabled = true;
            Console.WriteLine("starting autoclicker");
            clicker.Start();
        }

        private void autoclicker_stop_btn_Click(object sender, EventArgs e)
        {
            clicker.Stop();
            clickerEnabled = false;
        }

        int minC;
        int maxC;

        private void random_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (clickerEnabled)
            {
                minC = CPS_trackbar.Value - 3;
                maxC = CPS_trackbar.Value + 3;
                randomTB.Value = (rand.Next(minC, maxC));
            }
        }

        private async void clicker_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            try
            {
                clicker.Interval = 1000 / randomTB.Value;
            }
            catch { Console.WriteLine("Error! Something is not working.."); }

            if (clickerEnabled)
            {
                if (!rightClick)
                {
                    // left autoclick
                    mouse_event(LEFTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(rand.Next(Delay1, Delay2));
                    mouse_event(LEFTUP, 0, 0, 0, 0);
                }
                else if (rightClick)
                {
                    // right autoclick
                    mouse_event(RIGHTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(rand.Next(Delay1, Delay2));
                    mouse_event(RIGHTUP, 0, 0, 0, 0);
                }
            }
        }

        private void rightClick_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rightClick_checkbox.Checked)
            {
                rightClick = true;
            }
            else
            {
                rightClick = false;
            }
        }

        // APP RELATED: WARNING MESSY CODE

        private void top_drag_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void top_drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void top_drag_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DELAY_rand1_trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            Delay1 = DELAY_rand1_trackbar.Value;
        }

        private void DELAY_rand2_trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            Delay2 = DELAY_rand2_trackbar.Value;
        }

        KeysConverter Key = new KeysConverter();

        private void system_Tick(object sender, EventArgs e)
        {
            millis_label.Text = Delay1.ToString() + "ms" + " - " + Delay2.ToString() + "ms";

            if (startKey_btn.Text != "none" && startKey_btn.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(startKey_btn.Text.Replace("...", ""));
                if (GetAsyncKeyState(binding) < 0)
                {
                    if (!clickerEnabled)
                        clickerEnabled = true;
                    else if (clickerEnabled)
                        clickerEnabled = false;

                    while(GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(10);
                    }
                    return;
                }
            }

            if (clickerEnabled)
            {
                title.ForeColor = Color.FromArgb(153, 0, 255);
            }
            else
            {
                title.ForeColor = Color.FromArgb(244, 244, 244);
            }
        }

        private void startKey_btn_Click(object sender, EventArgs e)
        {
            startKey_btn.Text = "...";
        }

        private void startKey_btn_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string keyData = e.KeyData.ToString();
                if (!keyData.Contains("Alt"))
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        startKey_btn.Text = "none";
                    }
                    else
                    {
                        startKey_btn.Text = keyData;
                    }
                }
            }
            KeysConverter Key = new KeysConverter();
        }

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        private void alwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTop.Checked)
            {
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void author_label_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void author_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void author_label_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
 