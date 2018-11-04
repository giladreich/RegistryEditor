using System;
using System.Runtime.InteropServices;

namespace Windows.RegistryEditor.Utils.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct NativeListViewItem
    {
        public int mask;
        public int iItem;
        public int iSubItem;
        public int state;
        public int stateMask;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string pszText;
        public int cchTextMax;
        public int iImage;
        public IntPtr lParam;
        public int iIndent;
        public int iGroupId;
        public int cColumns;
        public IntPtr puColumns;
    }
}
