namespace Task4
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject) : base(subject) { }

        public override void Update() 
            => Console.WriteLine($"Binary String: {Convert.ToString(_subject.GetState(), 2)}");
    }
}