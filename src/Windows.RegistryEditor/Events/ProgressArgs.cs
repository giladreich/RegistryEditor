using System;

namespace Windows.RegistryEditor.Events
{
    public class ProgressArgs : EventArgs
    {
        public string Message { get; set; }

        public ProgressArgs(string message)
        {
            Message = message;
        }
    }
}