using System.Xml;
using System.Xml.Linq;


namespace Lab2
{
    public partial class Form1 : Form
    {
        Computer pc = new Computer();
        Processor core_i5_10400F = new Processor()
        {
            Manufacturer = "Intel",
            Series = "Core i5",
            Model = "10400F",
            NumberOfCores = 6,
            Frequency = 2.9f,
            MaxFrequency = 4.3f,
            ArchitectureBits = 64,
            CacheSize = "12 MB"
        };
        Processor core_i3_12100F = new Processor()
        {
            Manufacturer = "Intel",
            Series = "Core i3",
            Model = "12100F",
            NumberOfCores = 4,
            Frequency = 3.0f,
            MaxFrequency = 4.1f,
            ArchitectureBits = 64,
            CacheSize = "6 MB"
        };

        Processor core_i9_13900K = new Processor()
        {
            Manufacturer = "Intel",
            Series = "Core i9",
            Model = "13900K",
            NumberOfCores = 8,
            Frequency = 3.5f,
            MaxFrequency = 5.0f,
            ArchitectureBits = 64,
            CacheSize = "24.75 MB"
        };

        Processor ryzen_5_3600 = new Processor()
        {
            Manufacturer = "AMD",
            Series = "Ryzen 5",
            Model = "3600",
            NumberOfCores = 6,
            Frequency = 3.6f,
            MaxFrequency = 4.2f,
            ArchitectureBits = 64,
            CacheSize = "35 MB"
        };

        Processor ryzen_5_5700X = new Processor()
        {
            Manufacturer = "AMD",
            Series = "Ryzen 5",
            Model = "5700X",
            NumberOfCores = 8,
            Frequency = 3.8f,
            MaxFrequency = 4.6f,
            ArchitectureBits = 64,
            CacheSize = "32 MB"
        };

        Processor ryzen_7_2700X = new Processor()
        {
            Manufacturer = "AMD",
            Series = "Ryzen 7",
            Model = "2700X",
            NumberOfCores = 8,
            Frequency = 3.7f,
            MaxFrequency = 4.3f,
            ArchitectureBits = 64,
            CacheSize = "20 MB"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc.Processor = comboBox1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Показываем определенные элементы комбобокса
                comboBox1.Items.Add("Ryzen 5 3600");
                comboBox1.Items.Add("Ryzen 5 5700X");
                comboBox1.Items.Add("Ryzen 7 2700X");
            }
            else
            {
                // Скрываем определенные элементы комбобокса
                comboBox1.Items.Remove("Ryzen 5 3600");
                comboBox1.Items.Remove("Ryzen 5 5700X");
                comboBox1.Items.Remove("Ryzen 7 2700X");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Показываем определенные элементы комбобокса
                comboBox1.Items.Add("Core i5 10400F");
                comboBox1.Items.Add("Core i3 12100F");
                comboBox1.Items.Add("Core i9 13900K");
            }
            else
            {
                // Скрываем определенные элементы комбобокса
                comboBox1.Items.Remove("Core i5 10400F");
                comboBox1.Items.Remove("Core i3 12100F");
                comboBox1.Items.Remove("Core i9 13900K");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CoresAmount_Scroll(object sender, EventArgs e)
        {
            // Получаем значение ползунка и округляем до ближайшего четного числа
            int value = CoresAmount.Value;
            int roundedValue = (int)Math.Round((double)value / 2) * 2;
            pc.RAMSize = roundedValue;
            // Обновляем текст Label
            label6.Text = roundedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Получаем значение ползунка и округляем до ближайшего четного числа
            int value = trackBar1.Value;
            int roundedValue = (int)Math.Round((double)value / 2) * 2;
            pc.HardDriveSize= roundedValue;
            // Обновляем текст Label
            label8.Text = roundedValue.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processorType = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(processorType))
            {
                Processor selectedProcessor = null;
                switch (processorType)
                {
                    case "Core i5 10400F":
                        selectedProcessor = core_i5_10400F;
                        break;
                    case "Core i3 12100F":
                        selectedProcessor = core_i3_12100F;
                        break;
                    case "Core i9 13900K":
                        selectedProcessor = core_i9_13900K;
                        break;
                    case "Ryzen 5 3600":
                        selectedProcessor = ryzen_5_3600;
                        break;
                    case "Ryzen 5 5700X":
                        selectedProcessor = ryzen_5_5700X;
                        break;
                    case "Ryzen 7 2700X":
                        selectedProcessor = ryzen_7_2700X;
                        break;
                    // и т.д. для каждого процессора
                    default:
                        MessageBox.Show("Выбран некорректный тип процессора");
                        break;
                }

                if (selectedProcessor != null)
                {
                    // Открыть новую форму и передать значения свойств выбранного процессора
                    Form2 newForm = new Form2(selectedProcessor);
                    newForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Не выбран тип процессора");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Проверка типа компьютера

            int checkedCount = 0;

            if (checkBox1.Checked)
            {
                checkedCount++;
            }
            if (checkBox2.Checked)
            {
                checkedCount++;
            }
            if (checkBox3.Checked)
            {
                checkedCount++;
            }

            if (checkedCount != 1)
            {
                MessageBox.Show("Пожалуйста, выберите один из трех вариантов типа компьютера.");
                return;
            }

            // Проверка процессора

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите процессор из списка!");
                return;
            }

            // Проверка видеокарты 

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите видеокарту из списка!");
                return;
            }

            // Проверка ядер процессора

            if (string.IsNullOrEmpty(label6.Text))
            {
                MessageBox.Show("Выберите количество ядер процессора!");
                return;
            }

            // Проверка ОЗУ

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ОЗУ из списка!");
                return;
            }

            // Проверка размера накопителя

            if (string.IsNullOrEmpty(label8.Text))
            {
                MessageBox.Show("Выберите размер накопителя!");
                return;
            }

            // Проверка типа ОЗУ

            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ОЗУ из списка!");
                return;
            }

            // Проверка даты

            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Выбранная дата не может быть больше сегодняшней");
                return;
            }

            // Проверка мощности БП

            if (numericUpDown1.Value > 1000 || numericUpDown1.Value < 300)
            {
                MessageBox.Show("Выбранная дата не может быть больше сегодняшней");
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            if(checkBox1.Checked)
            {
                pc.ComputerType = "Server";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pc.ComputerType = "Laptop";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pc.ComputerType = "Desktop";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc.VideoCard = listBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc.RAMType = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc.HardDriveType = comboBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pc.DateOfPurchase = dateTimePicker1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Создаем объект XmlDocument для работы с XML
            XmlDocument xmlDocument = new XmlDocument();

            // Создаем корневой элемент
            XmlElement root = xmlDocument.CreateElement("Computer");
            xmlDocument.AppendChild(root);

            // Создаем элементы и добавляем их в документ
            XmlElement computerTypeElement = xmlDocument.CreateElement("ComputerType");
            computerTypeElement.InnerText = pc.ComputerType;
            root.AppendChild(computerTypeElement);

            XmlElement processorElement = xmlDocument.CreateElement("Processor");
            processorElement.InnerText = pc.Processor;
            root.AppendChild(processorElement);

            XmlElement videoCardElement = xmlDocument.CreateElement("VideoCard");
            videoCardElement.InnerText = pc.VideoCard;
            root.AppendChild(videoCardElement);

            XmlElement ramTypeElement = xmlDocument.CreateElement("RAMType");
            ramTypeElement.InnerText = pc.RAMType;
            root.AppendChild(ramTypeElement);

            XmlElement ramSizeElement = xmlDocument.CreateElement("RAMSize");
            ramSizeElement.InnerText = pc.RAMSize.ToString();
            root.AppendChild(ramSizeElement);

            XmlElement hardDriveTypeElement = xmlDocument.CreateElement("HardDriveType");
            hardDriveTypeElement.InnerText = pc.HardDriveType;
            root.AppendChild(hardDriveTypeElement);

            XmlElement hardDriveSizeElement = xmlDocument.CreateElement("HardDriveSize");
            hardDriveSizeElement.InnerText = pc.HardDriveSize.ToString();
            root.AppendChild(hardDriveSizeElement);

            XmlElement dateOfPurchaseElement = xmlDocument.CreateElement("DateOfPurchase");
            dateOfPurchaseElement.InnerText = pc.DateOfPurchase.ToString();
            root.AppendChild(dateOfPurchaseElement);

            // Сохраняем документ в файл
            xmlDocument.Save("computer.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Загружаем XML файл
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load("computer.xml");

                // Получаем корневой элемент
                XmlElement root = xmlDocument.DocumentElement;

                // Получаем значения свойств из XML и выводим их в MessageBox
                string computerType = root.SelectSingleNode("ComputerType").InnerText;
                string processor = root.SelectSingleNode("Processor").InnerText;
                string videoCard = root.SelectSingleNode("VideoCard").InnerText;
                string ramType = root.SelectSingleNode("RAMType").InnerText;
                int ramSize = int.Parse(root.SelectSingleNode("RAMSize").InnerText);
                string hardDriveType = root.SelectSingleNode("HardDriveType").InnerText;
                int hardDriveSize = int.Parse(root.SelectSingleNode("HardDriveSize").InnerText);
                DateTime dateOfPurchase = DateTime.Parse(root.SelectSingleNode("DateOfPurchase").InnerText);

                string message = $"Computer Type: {computerType}\nProcessor: {processor}\nVideo Card: {videoCard}\nRAM Type: {ramType}\nRAM Size: {ramSize}\nHard Drive Type: {hardDriveType}\nHard Drive Size: {hardDriveSize}\nDate of Purchase: {dateOfPurchase.ToString()}";

                MessageBox.Show(message, "Computer Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading computer information from XML file: " + ex.Message, "Error");
            }
        }
    }
}