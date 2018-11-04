using System;

namespace Windows.RegistryEditor.Events
{
    public class FindSingleResultArgs : EventArgs
    {
        public string Match { get; set; }

        public FindSingleResultArgs(string match)
        {
            Match = match;
        }
    }
}