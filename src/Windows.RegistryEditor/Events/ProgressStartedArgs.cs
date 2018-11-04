namespace Windows.RegistryEditor.Events
{
    public class ProgressStartedArgs : ProgressArgs
    {
        public string Hive { get; set; }
        public ProgressStartedArgs(string message, string hive) 
            : base(message)
        {
            Hive = hive;
        }
    }
}