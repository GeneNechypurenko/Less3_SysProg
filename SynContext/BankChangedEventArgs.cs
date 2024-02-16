namespace SynContext
{
    public class BankChangedEventArgs : EventArgs
    {
        public string PropertyName { get; }
        public object NewValue { get; }

        public BankChangedEventArgs(string propertyName, object newValue)
        {
            PropertyName = propertyName;
            NewValue = newValue;
        }
    }
}