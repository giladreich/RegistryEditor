namespace Windows.RegistryEditor.Events
{
    public class ProgressChangedArgs : ProgressArgs
    {
        public string Hive { get; set; }
        public ProgressChangedArgs(string message, string hive)
            : base(message)
        {
            Hive = hive;
        }
    }
}