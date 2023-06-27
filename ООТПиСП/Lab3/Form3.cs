using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.Devices;
using System.Collections;

namespace Lab3
{
    public partial class Form3 : Form
    {
        private Processor[] processors;

        Computer[] computers = new Computer[]
        {
        new Computer
        {
            ComputerType = "Laptop",
            Processor = "Intel Core i5 10400F",
            VideoCard = "NVIDIA GeForce GTX 1650",
            RAMType = "DDR4",
            RAMSize = 8,
            HardDriveType = "SSD",
            HardDriveSize = 256,
            DateOfPurchase = new DateTime(2021, 1, 15),
            ProcessorInfo = new Processor
            {
                Manufacturer = "Intel",
                Series = "Core i7",
                Model = "9700K",
                NumberOfCores = 8,
                Frequency = 15f,
                MaxFrequency = 4.9f,
                ArchitectureBits = 64,
                CacheSize = "12 MB"
            }
        },
        new Computer
        {
            ComputerType = "Desktop",
            Processor = "AMD Ryzen 5 3600",
            VideoCard = "AMD Radeon RX 5700",
            RAMType = "DDR4",
            RAMSize = 16,
            HardDriveType = "NVMe SSD",
            HardDriveSize = 512,
            DateOfPurchase = new DateTime(2020, 7, 1),
            ProcessorInfo = new Processor { Manufacturer = "AMD", Frequency = 3.6f }
        },
        new Computer
        {
            ComputerType = "Desktop",
            Processor = "Intel Core i9 13900K",
            VideoCard = "NVIDIA GeForce RTX 3080",
            RAMType = "DDR5",
            RAMSize = 32,
            HardDriveType = "HDD",
            HardDriveSize = 2_000,
            DateOfPurchase = new DateTime(2022, 2, 10),
            ProcessorInfo = new Processor { Manufacturer = "Intel", Frequency = 3.5f }
        },
        new Computer
        {
            ComputerType = "Laptop",
            Processor = "AMD Ryzen 5 5700X",
            VideoCard = "NVIDIA GeForce GTX 1660 Ti",
            RAMType = "DDR4",
            RAMSize = 16,
            HardDriveType = "SSD",
            HardDriveSize = 512,
            DateOfPurchase = new DateTime(2021, 12, 5),
            ProcessorInfo = new Processor { Manufacturer = "AMD", Frequency = 3.8f }
        },
        new Computer
        {
            ComputerType = "Desktop",
            Processor = "Intel Core i3 12100F",
            VideoCard = "Intel UHD Graphics 750",
            RAMType = "DDR4",
            RAMSize = 8,
            HardDriveType = "HDD",
            HardDriveSize = 1_000,
            DateOfPurchase = new DateTime(2019, 5, 20),
            ProcessorInfo = new Processor { Manufacturer = "Intel", Frequency = 3.1f }
        }
            };


        public Form3(Processor[] processors)
        {
            InitializeComponent();
            this.processors = processors;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Clear();
                var searchText = textBox1.Text;
                var regexPattern = $"(?i).*{searchText}.*";

                foreach (var processor in processors)
                {
                    var match = Regex.IsMatch(processor.Manufacturer, regexPattern) ||
                                Regex.IsMatch(processor.Series, regexPattern);

                    if (match)
                    {
                        listBox1.Items.Add(processor);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var searchText = textBox1.Text;
            var regexPattern = $"(?i).*{searchText}.*";

            foreach (var processor in processors)
            {
                var match = Regex.IsMatch(processor.Manufacturer, regexPattern) ||
                            Regex.IsMatch(processor.Series, regexPattern);

                if (match)
                {
                    string result = processor.Manufacturer + " " + processor.Series;
                    listBox1.Items.Add(result);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранную опцию сортировки
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Отсортировать список в соответствии с выбранной опцией
            List<Computer> sortedList = new List<Computer>();
            if (selectedItem == "По частоте процессора")
            {
                sortedList = computers.OrderBy(c => c.RAMSize).ToList();
            }
            else if (selectedItem == "По размеру ОЗУ")
            {
                sortedList = computers.OrderBy(c => c.ProcessorInfo.Frequency).ToList();
            }

            // Очистить ListBox и добавить новые элементы в соответствии с отсортированным списком
            listBox2.Items.Clear();
            foreach (Computer computer in sortedList)
            {
                // Вывести ID компьютера, если выбрана опция сортировки по размеру ОЗУ
                if (selectedItem == "По размеру ОЗУ")
                {
                    listBox2.Items.Add("ID компьютера: " + (Array.IndexOf(computers, computer) + 1));
                }
                // Вывести название процессора, если выбрана опция сортировки по частоте процессора
                else if (selectedItem == "По частоте процессора")
                {
                    listBox2.Items.Add(computer.ProcessorInfo.Manufacturer + " " + computer.Processor);
                }
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Создаем новый список для хранения данных
            var data = new List<object>();

            // Добавляем все элементы из listBox1 и listBox2 в список данных
            foreach (var item in listBox1.Items)
            {
                data.Add(item);
            }
            foreach (var item in listBox2.Items)
            {
                data.Add(item);
            }

            // Открываем диалог сохранения файла
            var dialog = new SaveFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Создаем новый объект DataContractJsonSerializer для сериализации данных
                var serializer = new DataContractJsonSerializer(typeof(List<object>));

                // Создаем новый поток для записи данных в файл
                using (var stream = new FileStream(dialog.FileName, FileMode.Create))
                {
                    // Сериализуем данные в JSON формат и записываем их в файл
                    serializer.WriteObject(stream, data);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidationContext context = new ValidationContext(computers[0]);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(computers[0], context, results, true);
            if (isValid)
            {
                MessageBox.Show("Данные для компьютера 1 валидны!");
            } else
            {
                MessageBox.Show("Данные для компьютера 1 не валидны!");
            }

            ValidationContext context2 = new ValidationContext(computers[0].ProcessorInfo);
            List<ValidationResult> results2 = new List<ValidationResult>();
            bool isValid2 = Validator.TryValidateObject(computers[0].ProcessorInfo, context2, results2, true);
            if (!isValid2)
            {
                foreach (var validationResult in results2)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                }
            } else
            {
                MessageBox.Show("Процессор валидный");
            }

        }
    }
}
