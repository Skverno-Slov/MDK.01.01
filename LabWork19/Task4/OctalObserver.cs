namespace Task4
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject) : base(subject) { }

        public override void Update()
            => Console.WriteLine($"Octal String: {Convert.ToString(_subject.GetState(), 8)}");
    }
}