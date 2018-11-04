namespace Windows.RegistryEditor.Events
{
    public class ProgressFinishedArgs : ProgressArgs
    {
        public ProgressFinishedArgs(string message) 
            : base(message)
        { }
    }
}