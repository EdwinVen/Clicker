using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ConsoleClicker {
    enum ClickAction {
        MOUSEEVENTF_ABSOLUTE = 0x8000,
        MOUSEEVENTF_MOVE = 0x0001,
        MOUSEEVENTF_LEFTDOWN = 0x02,
        MOUSEEVENTF_LEFTUP = 0x04,
        MOUSEEVENTF_RIGHTDOWN = 0x08,
        MOUSEEVENTF_RIGHTUP = 0x10,
        MOUSEEVENTF_MIDDLEDOWN = 0x0020,
        MOUSEEVENTF_MIDDLEUP = 0x0040,
        MOUSEEVENTF_WHEEL = 0x0800,
        MOUSEEVENTF_HWHEEL = 0x01000,
        MOUSEEVENTF_XDOWN = 0x0080,
        MOUSEEVENTF_XUP = 0x0100
    }

    class Click : IPerformable{
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        #region consts
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int MOUSEEVENTF_HWHEEL = 0x01000;
        private const int MOUSEEVENTF_XDOWN = 0x0080;
        private const int MOUSEEVENTF_XUP = 0x0100;
        #endregion consts

        public ClickAction Type;

        private int delayAfterClick;
        public int DelayAfterClick {
            get {
                return delayAfterClick;
            }
            set { if (value >= 0) delayAfterClick = value; }
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Click(): this(ClickAction.MOUSEEVENTF_LEFTDOWN, 0, 0, 0) {

        }

        public Click(ClickAction newType, int newX, int newY, int newDelay) {
            Type = newType;
            X = newX;
            Y = newY;
            DelayAfterClick = newDelay;
        }

        public void Perform() {
            mouse_event((int)Type, X, Y, 0, 0);
            Thread.Sleep(DelayAfterClick);
            
        }
    }
}
