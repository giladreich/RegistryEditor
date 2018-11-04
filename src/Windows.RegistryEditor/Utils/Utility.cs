using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Windows.RegistryEditor.Utils.Native;

namespace Windows.RegistryEditor.Utils
{
    public static class Utility
    {

        public static void InvokeSafe(this ISynchronizeInvoke caller, Action method)
        {
            if (caller.InvokeRequired)
                caller.Invoke(method, null);
            else
                method.Invoke();
        }

        public static T InvokeSafe<T>(this ISynchronizeInvoke caller, Func<T> method)
        {
            if (caller.InvokeRequired)
                return (T)caller.Invoke(method, null);

            return method.Invoke();
        }

        public static void BeginInvokeSafe(this ISynchronizeInvoke caller, Action method)
        {
            if (caller.InvokeRequired)
                caller.BeginInvoke(method, null);
            else
                method.Invoke();
        }

        public static bool KillProcess(string proc)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLower() != proc) continue;

                process.Kill();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Characters that are not allowed on windows:
        /// < > : " / \ | ? 
        /// </summary>
        public static string ValidateDirOrFileName(string name)
        {
            return Regex.Replace(name, "<|>|:|\"|/|\\\\|\\||\\?|\\*", " ");
        }

        public static void SelectAllItems(this ListView listView)
        {
            NativeMethods.SetItemState(listView, -1, 2, 2);
        }

        public static void DeselectAllItems(this ListView listView)
        {
            NativeMethods.SetItemState(listView, -1, 2, 0);
        }

        public static void OpenFolderInExplorer(string path)
        {
            Process.Start("explorer.exe", path);
        }
    }
}
