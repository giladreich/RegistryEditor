using System;
using System.Collections.Generic;

namespace Windows.RegistryEditor.Events
{
    public class FindResultsArgs : EventArgs
    {
        public List<string> Matches { get; set; }

        public FindResultsArgs(List<string> matches)
        {
            Matches = matches;
        }
    }
}