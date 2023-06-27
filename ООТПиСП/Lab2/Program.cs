namespace Lab2
{
    public class Computer
    {
        public string ComputerType { get; set; }
        public string Processor { get; set; }
        public string VideoCard { get; set; }
        public string RAMType { get; set; }
        public int RAMSize { get; set; }
        public string HardDriveType { get; set; }
        public int HardDriveSize { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public Processor ProcessorInfo { get; set; }
    }

    public class Processor
    {
        public string Manufacturer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int NumberOfCores { get; set; }
        public float Frequency { get; set; }
        public float MaxFrequency { get; set; }
        public int ArchitectureBits { get; set; }
        public string CacheSize { get; set; }
    }



    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}