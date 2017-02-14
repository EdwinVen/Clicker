using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Drawing;

namespace ConsoleClicker {
    class Program {


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("User32.dll",
               EntryPoint = "GetSystemMetrics",
               CallingConvention = CallingConvention.Winapi)]
        internal static extern int InternalGetSystemMetrics(int value);


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

        static void Main(string[] args) {
            Point p = System.Windows.Forms.Control.MousePosition;

            int screenWidth = InternalGetSystemMetrics(0);
            int screenHeight = InternalGetSystemMetrics(1);

            Thread.Sleep(5000);
            //int X = (int)System.Math.Round((p.X + 50) * 65536.0 / screenWidth);
            //int Y = (int)System.Math.Round( (p.Y + 50) * 65536.0 / screenHeight);

            int X = (int)System.Math.Round((p.X ) * 65536.0 / screenWidth);
            int Y = (int)System.Math.Round((p.Y ) * 65536.0 / screenHeight);

            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            /*mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_MOVE, 50, 50, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);*/

            #region drawSquare
            //mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);

            //int delay = 100;
            //int length = 50;
            //while (length > 0) {
            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        mouse_event(MOUSEEVENTF_MOVE, 5, 0, 0, 0);
            //    }
            //    length -= 5;
            //    delay -= 5;

            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        mouse_event(MOUSEEVENTF_MOVE, 0, 5, 0, 0);
            //    }
            //    delay -= 5;

            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        mouse_event(MOUSEEVENTF_MOVE, -5, 0, 0, 0);
            //    }
            //    length -= 5;
            //    delay -= 5;

            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        mouse_event(MOUSEEVENTF_MOVE, 0, -5, 0, 0);
            //    }
            //    delay -= 5;
            //}

            ////mouse_event(MOUSEEVENTF_MOVE, 50, 50, 0, 0);

            //mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            #endregion drawSquare

            #region drawSquarePerform
            //mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);

            //int delay = 100;
            //int length = 50;
            //Click leftRight = new Click(ClickAction.MOUSEEVENTF_MOVE, 5, 0, 0);
            //Click upDown = new Click(ClickAction.MOUSEEVENTF_MOVE, 0, 5, 0);
            //Click rightLeft = new Click(ClickAction.MOUSEEVENTF_MOVE, -5, 0, 0);
            //Click downUp = new Click(ClickAction.MOUSEEVENTF_MOVE, 0, -5, 0);

            //while (length > 0) {
            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        leftRight.Perform();
            //    }
            //    length -= 5;
            //    delay -= 5;

            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        upDown.Perform();
            //    }
            //    delay -= 5;

            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        rightLeft.Perform();
            //    }
            //    length -= 5;
            //    delay -= 5;

            //    for (int i = 0; i < length; i++) {
            //        Thread.Sleep(delay);
            //        downUp.Perform();
            //    }
            //    delay -= 5;
            //}

            ////mouse_event(MOUSEEVENTF_MOVE, 50, 50, 0, 0);

            //mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            #endregion drawSquarePerform

            #region writeE

            List<Click> clickList = new List<Click>();
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTDOWN, 1000, 1000, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, 0, 100, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTUP, 0, 0, 500));

            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, 0, -100, 500));

            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTDOWN, 0, 0, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, 50, 0, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTUP, 0, 0, 500));

            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, -50, 50, 500));

            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTDOWN, 0, 0, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, 50, 0, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTUP, 0, 0, 500));

            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, -50, 50, 500));

            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTDOWN, 0, 0, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_MOVE, 50, 0, 500));
            clickList.Add(new Click(ClickAction.MOUSEEVENTF_LEFTUP, 0, 0, 500));

            foreach (Click c in clickList) {
                c.Perform();
            }


            #endregion writeE

            Thread.Sleep(3000);

            Console.WriteLine($"Screen width: {screenWidth}   Screen height: {screenHeight}");
            Console.WriteLine($"X: {X}   Y: {Y}");

            Console.Read();
        }

        
    }
}
