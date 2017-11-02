using KeyMouse.Properties;
using MouseKeyboardActivityMonitor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyMouse
{
    public partial class MainF : Form
    {

        #region Setup
         
        public MainF()
        {
            InitializeComponent();

            foreach (var control in Controls)
                if (control.GetType() == typeof(TextBox))
                    ((TextBox)control).KeyDown += (s, e) => {
                        e.Handled = true;
                        e.SuppressKeyPress = true;

                        ((TextBox)control).Text = e.KeyCode.ToString();
                        ((TextBox)control).SelectAll();
                    };

            khl.KeyDown += khl_KeyDown;
            khl.KeyUp += khl_KeyUp;

            khl.Start();

            WindowState = FormWindowState.Minimized;
            CheckTray();
        }

        private void MainF_Load(object sender, EventArgs e) { applyB.Enabled = false; }

        #endregion

        #region Vars

        int Speed {
            get { return _Speed; }
            set {
                if (_SSpeed.Length == 0 || _SSpeed.Length == 2)
                    _SSpeed = value.ToString();
                else if (_SSpeed.Length == 1)
                    _SSpeed += value.ToString();

                _Speed = Int32.Parse(_SSpeed);
            }
        }
        int _Speed = 5;
        string _SSpeed = "";

        List<Keys> PressedKeys = new List<Keys>();

        KeyboardHookListener khl = new KeyboardHookListener(new MouseKeyboardActivityMonitor.WinApi.GlobalHooker());

        #endregion

        #region Listener and move

        void khl_KeyDown(object sender, KeyEventArgs e)
        {
            bool suppress = false;
            int required = 0;
            int done = 0;
            if (ctrlCB.Checked) {
                required++;
                if (e.Control)
                    done++;
            }
            if (altCB.Checked) {
                required++;
                if (e.Alt)
                    done++;
            }
            if (shiftCB.Checked) {
                required++;
                if (e.Shift)
                    done++;
            }

            if (done == required) {
                if (e.KeyValue > 47 && e.KeyValue < 58) {
                    Speed = e.KeyValue - 48;
                    suppress = true;
                }
            }
            else // Clear
                _SSpeed = "";

            if (!PressedKeys.Contains(e.KeyCode))
                PressedKeys.Add(e.KeyCode);

            int m = moveCB.SelectedIndex;
            if (m == 0 && e.Control)
                suppress = MoveCursor();
            else if (m == 1 && e.Alt)
                suppress = MoveCursor();
            else if (m == 2 && e.Shift)
                suppress = MoveCursor();

            if (captureCB.Checked && suppress)
                e.Handled = true;
        }


        void khl_KeyUp(object sender, KeyEventArgs e) {
            PressedKeys.Remove(e.KeyCode);
        }

        bool MoveCursor()
        {
            int XMov = 0, YMov = 0;

            if (PressedKeys.Contains((Keys)Enum.Parse(typeof(Keys), moveRightTB.Text)))
                XMov += Speed;
            if (PressedKeys.Contains((Keys)Enum.Parse(typeof(Keys), moveLeftTB.Text)))
                XMov -= Speed;
            if (PressedKeys.Contains((Keys)Enum.Parse(typeof(Keys), moveUpTB.Text)))
                YMov -= Speed;
            if (PressedKeys.Contains((Keys)Enum.Parse(typeof(Keys), moveDownTB.Text)))
                YMov += Speed;

            
            if (PressedKeys.Contains((Keys)Enum.Parse(typeof(Keys), leftTB.Text)))
                LeftClick();
            if (PressedKeys.Contains((Keys)Enum.Parse(typeof(Keys), rightTB.Text)))
                RightClick();

            Cursor.Position = new Point(Cursor.Position.X + XMov, Cursor.Position.Y + YMov);

            return XMov != 0 || YMov != 0;
        }

        #region Mouse click

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        static void LeftClick() {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, (uint)0, (uint)0);
        }
        static void RightClick() {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, (uint)0, (uint)0);
        }

        #endregion

        #endregion

        #region Save settings

        private void applyB_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            Settings.Default.Save();
            applyB.Enabled = false;
            Cursor = Cursors.Arrow;
        }

        #endregion

        #region Any Changed

        private void AnyChanged(object sender, EventArgs e) { applyB.Enabled = true; }

        #endregion

        #region System Tray

        private void MainF_Resize(object sender, EventArgs e) { CheckTray(); }

        void CheckTray() {
            ShowInTaskbar = WindowState != FormWindowState.Minimized;
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                tray.ShowBalloonTip(5000);
        }

        private void settingsTSMI_Click(object sender, EventArgs e)
        { WindowState = FormWindowState.Normal; }

        private void exitTSMI_Click(object sender, EventArgs e) { Application.Exit(); }

        #endregion

        #region Closing

        private void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void MainF_FormClosed(object sender, FormClosedEventArgs e) { khl.Dispose(); }

        #endregion

    }
}