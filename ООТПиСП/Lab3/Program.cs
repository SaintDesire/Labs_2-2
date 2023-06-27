using System.ComponentModel.DataAnnotations;


namespace Lab3
{
    public class Computer
    {
        [Required(ErrorMessage = "ComputerType is required")]
        public string ComputerType { get; set; }

        [Required(ErrorMessage = "Processor is required")]
        public string Processor { get; set; }

        public string VideoCard { get; set; }

        [Required(ErrorMessage = "RAMType is required")]
        public string RAMType { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "RAMSize must be greater than 0")]
        public int RAMSize { get; set; }

        [Required(ErrorMessage = "HardDriveType is required")]
        public string HardDriveType { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "HardDriveSize must be greater than 0")]
        public int HardDriveSize { get; set; }

        [Required(ErrorMessage = "DateOfPurchase is required")]
        public DateTime DateOfPurchase { get; set; }

        public Processor ProcessorInfo { get; set; }
    }

    public class Processor
    {
        [Required(ErrorMessage = "Manufacturer is required")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Series is required")]
        public string Series { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }

        [Range(1, 64, ErrorMessage = "Number of cores must be between 1 and 64")]
        public int NumberOfCores { get; set; }

        [Range(0.1, 5.0, ErrorMessage = "Frequency must be between 0.1 and 5.0 GHz")]
        public float Frequency { get; set; }

        [Range(0.1, 5.0, ErrorMessage = "Max frequency must be between 0.1 and 5.0 GHz")]
        public float MaxFrequency { get; set; }

        [Range(32, 64, ErrorMessage = "Architecture bits must be either 32 or 64")]
        public int ArchitectureBits { get; set; }

        [Required(ErrorMessage = "Cache size is required")]
        public string CacheSize { get; set; }

        public Processor() { }
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