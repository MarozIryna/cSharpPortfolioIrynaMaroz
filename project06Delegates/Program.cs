namespace project06Delegates
{
    internal static class Program
    {

        public delegate void NoParameters();

        static void Main()
        {
            NoParameters noPrm = new(ShowMessage);

            noPrm();

            Console.ReadLine();
        }

        private static void ShowMessage()
        {
            Console.WriteLine("Have fun!");
        }
    }
}