using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace YC.Client.Execute
{
    public class Win32
    {

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 创建事件内核对象
        /// </summary>
        /// <param name="secatt">安全描述符</param>
        /// <param name="bManualReset">是否手动重置</param>
        /// <param name="bInitialState">是否创建完毕就有信号</param>
        /// <param name="lpName"></param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        public static extern IntPtr CreateEvent(IntPtr secatt, bool bManualReset, bool bInitialState, String lpName);
        /// <summary>
        /// 打开一个事件对象
        /// </summary>
        /// <param name="dwDesiredAccess"></param>
        /// <param name="bInheritHandle"></param>
        /// <param name="lpName"></param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        public static extern IntPtr OpenEvent(int dwDesiredAccess, bool bInheritHandle, string lpName);
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// 关闭句柄
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        public static extern bool CloseHandle(IntPtr Handle);

        /// <summary>
        /// 将对象转换为有信号
        /// </summary>
        /// <param name="hEvent">句柄</param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        public static extern bool SetEvent(IntPtr hEvent);

        /// <summary>
        /// 将对象变为无信号
        /// </summary>
        /// <param name="hEvent">句柄</param>
        /// <returns></returns> 
        [DllImport("Kernel32.dll")]
        public static extern bool ResetEvent(IntPtr hEvent);
        /// <summary>
        /// 等待信号
        /// </summary>
        /// <param name="hHandle">内核对象句柄</param>
        /// <param name="dwMilliseconds">等待时长</param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        public static extern int WaitForSingleObject(IntPtr hHandle, // handle to object
            int dwMilliseconds);
        [DllImport("kernel32.dll")]
        public static extern int GetLastError();
        /// <summary>
        /// 发送消息到消息队列
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, ref MyLParam lParam);

        public static int SendMessageToMainWindow(int Msg, int wParam, ref MyLParam lParam)
        {
            if (MainWindowPtr == IntPtr.Zero)
            {
                HwndSource hwndSource = PresentationSource.FromVisual(Application.Current.MainWindow) as HwndSource;
                MainWindowPtr = hwndSource.Handle;
            }

            return SendMessage(MainWindowPtr, Msg, wParam, ref lParam);
        }


        public static int SendMessageToMainWindowparameter(int Msg, int wParam, ref MyLParam lParam, object par)
        {
            if (MainWindowPtr == IntPtr.Zero)
            {
                HwndSource hwndSource = PresentationSource.FromVisual(Application.Current.MainWindow) as HwndSource;
                MainWindowPtr = hwndSource.Handle;
            }
            lParam.tag = par;
            return SendMessage(MainWindowPtr, Msg, wParam, ref lParam);
        }

        public static int SendMessageToMainWindow(int Msg)
        {
            return SendMessageToMainWindow(Msg, 0, ref myLParam);
        }


        private static MyLParam myLParam = new MyLParam();
        public static IntPtr MainWindowPtr = IntPtr.Zero;
        /// <summary>
        /// 自定义的结构
        /// </summary>
        public struct MyLParam
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string Data;
            [MarshalAs(UnmanagedType.LPStr)]
            public string Data1;
            [MarshalAs(UnmanagedType.LPStr)]
            public string Data2;
            [MarshalAs(UnmanagedType.LPStr)]
            public string Data3;
            [MarshalAs(UnmanagedType.LPStr)]
            public string wParam;
            public object tag;
        }
    }
}
