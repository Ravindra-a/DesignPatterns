namespace Command
{ 
    /// The 'Command' abstract class   
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
