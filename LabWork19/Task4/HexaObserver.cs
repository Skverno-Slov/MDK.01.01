namespace Task4
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject) : base(subject) { }

        public override void Update()
            => Console.WriteLine($"Hex String: {Convert.ToString(_subject.GetState(), 16).ToUpper()}");
    }
}