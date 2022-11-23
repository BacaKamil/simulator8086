namespace simulator8086
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MessScreen());
        }
    }
}