using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace Lab3
{
    public partial class Form1 : Form
    {

        private Control lastHoveredControl;

        private int objectCount = 0;

        Computer pc = new Computer();

        Processor[] processors = new Processor[]
        {
            new Processor()
        {
            Manufacturer = "Intel",
            Series = "Core i5",
            Model = "10400F",
            NumberOfCores = 6,
            Frequency = 2.9f,
            MaxFrequency = 4.3f,
            ArchitectureBits = 64,
            CacheSize = "12 MB"
        },
            new Processor()
        {
            Manufacturer = "Intel",
            Series = "Core i3",
            Model = "12100F",
            NumberOfCores = 4,
            Frequency = 3.0f,
            MaxFrequency = 4.1f,
            ArchitectureBits = 64,
            CacheSize = "6 MB"
        },
            new Processor()
        {
            Manufacturer = "Intel",
            Series = "Core i9",
            Model = "13900K",
            NumberOfCores = 8,
            Frequency = 3.5f,
            MaxFrequency = 5.0f,
            ArchitectureBits = 64,
            CacheSize = "24.75 MB"
        },
            new Processor()
        {
            Manufacturer = "AMD",
            Series = "Ryzen 5",
            Model = "3600",
            NumberOfCores = 6,
            Frequency = 3.6f,
            MaxFrequency = 4.2f,
            ArchitectureBits = 64,
            CacheSize = "35 MB"
        },
            new Processor()
        {
            Manufacturer = "AMD",
            Series = "Ryzen 5",
            Model = "5700X",
            NumberOfCores = 8,
            Frequency = 3.8f,
            MaxFrequency = 4.6f,
            ArchitectureBits = 64,
            CacheSize = "32 MB"
        },
            new Processor()
        {
            Manufacturer = "AMD",
            Series = "Ryzen 7",
            Model = "2700X",
            NumberOfCores = 8,
            Frequency = 3.7f,
            MaxFrequency = 4.3f,
            ArchitectureBits = 64,
            CacheSize = "20 MB"
        },

    };
        public Form1()
        {
            InitializeComponent();

            foreach (Control control in Controls)
            {
                control.MouseHover += new EventHandler(control_MouseHover);
            }
        }

        private void control_MouseHover(object sender, EventArgs e)
        {
            // ���������� ������ �� �������, �� ������� ������� ������ ����, � ����������
            lastHoveredControl = sender as Control;
        }

        // ������� ���������� ������� Click ��� ������ "�������"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // �������� ����� ������� ���������� ����������� ��������
            ClearLastHoveredControl();
        }

        // ������� ����� ��� ������� ���������� ����������� ��������
        private void ClearLastHoveredControl()
        {
            if (lastHoveredControl != null)
            {
                if (lastHoveredControl is TextBox)
                {
                    // ������� ��������� ����
                    ((TextBox)lastHoveredControl).Text = "";
                }
                else if (lastHoveredControl is ComboBox)
                {
                    // ���������� ��������� �������� � ����������
                    ((ComboBox)lastHoveredControl).SelectedIndex = -1;
                }
                else if (lastHoveredControl is CheckedListBox)
                {
                    // ������� ��� ������� � CheckedListBox
                    for (int i = 0; i < ((CheckedListBox)lastHoveredControl).Items.Count; i++)
                    {
                        ((CheckedListBox)lastHoveredControl).SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
                else
                {
                    // ���� ������� �� ��������������, �� ������� ��������� �� ������
                    MessageBox.Show("���� ������� �� ��������������!");
                }
            }
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
            control_MouseHover(sender, e);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // ���������� ������������ �������� ����������
                comboBox1.Items.Add("Ryzen 5 3600");
                comboBox1.Items.Add("Ryzen 5 5700X");
                comboBox1.Items.Add("Ryzen 7 2700X");
            }
            else
            {
                // �������� ������������ �������� ����������
                comboBox1.Items.Remove("Ryzen 5 3600");
                comboBox1.Items.Remove("Ryzen 5 5700X");
                comboBox1.Items.Remove("Ryzen 7 2700X");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // ���������� ������������ �������� ����������
                comboBox1.Items.Add("Core i5 10400F");
                comboBox1.Items.Add("Core i3 12100F");
                comboBox1.Items.Add("Core i9 13900K");
            }
            else
            {
                // �������� ������������ �������� ����������
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
            // �������� �������� �������� � ��������� �� ���������� ������� �����
            int value = CoresAmount.Value;
            int roundedValue = (int)Math.Round((double)value / 2) * 2;
            pc.RAMSize = roundedValue;
            // ��������� ����� Label
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
            // �������� �������� �������� � ��������� �� ���������� ������� �����
            int value = trackBar1.Value;
            int roundedValue = (int)Math.Round((double)value / 2) * 2;
            pc.HardDriveSize= roundedValue;
            // ��������� ����� Label
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
                        selectedProcessor = processors[0];
                        break;
                    case "Core i3 12100F":
                        selectedProcessor = processors[1];
                        break;
                    case "Core i9 13900K":
                        selectedProcessor = processors[2];
                        break;
                    case "Ryzen 5 3600":
                        selectedProcessor = processors[3];
                        break;
                    case "Ryzen 5 5700X":
                        selectedProcessor = processors[4];
                        break;
                    case "Ryzen 7 2700X":
                        selectedProcessor = processors[5];
                        break;
                    // � �.�. ��� ������� ����������
                    default:
                        MessageBox.Show("������ ������������ ��� ����������");
                        break;
                }

                if (selectedProcessor != null)
                {
                    // ������� ����� ����� � �������� �������� ������� ���������� ����������
                    Form2 newForm = new Form2(selectedProcessor);
                    newForm.Show();
                }
            }
            else
            {
                MessageBox.Show("�� ������ ��� ����������");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �������� ���� ����������

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
                MessageBox.Show("����������, �������� ���� �� ���� ��������� ���� ����������.");
                return;
            }

            // �������� ����������

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("�������� ��������� �� ������!");
                return;
            }

            // �������� ���������� 

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("�������� ���������� �� ������!");
                return;
            }

            // �������� ���� ����������

            if (string.IsNullOrEmpty(label6.Text))
            {
                MessageBox.Show("�������� ���������� ���� ����������!");
                return;
            }

            // �������� ���

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("�������� ��� �� ������!");
                return;
            }

            // �������� ������� ����������

            if (string.IsNullOrEmpty(label8.Text))
            {
                MessageBox.Show("�������� ������ ����������!");
                return;
            }

            // �������� ���� ���

            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("�������� ��� �� ������!");
                return;
            }

            // �������� ����

            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show("��������� ���� �� ����� ���� ������ �����������");
                return;
            }

            // �������� �������� ��

            if (numericUpDown1.Value > 1000 || numericUpDown1.Value < 300)
            {
                MessageBox.Show("��������� ���� �� ����� ���� ������ �����������");
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
            control_MouseHover(sender, e);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc.HardDriveType = comboBox3.Text;
            control_MouseHover(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pc.DateOfPurchase = dateTimePicker1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            control_MouseHover(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ������� ������ XmlDocument ��� ������ � XML
            XmlDocument xmlDocument = new XmlDocument();

            // ������� �������� �������
            XmlElement root = xmlDocument.CreateElement("Computer");
            xmlDocument.AppendChild(root);

            // ������� �������� � ��������� �� � ��������
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

            // ��������� �������� � ����
            xmlDocument.Save("computer.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // ��������� XML ����
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load("computer.xml");

                // �������� �������� �������
                XmlElement root = xmlDocument.DocumentElement;

                // �������� �������� ������� �� XML � ������� �� � MessageBox
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(processors);
            newForm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ���������: 2.1 \n��� ������������: ������ ������ ��������", "� ���������");
        }


        private void button8_Click(object sender, EventArgs e)
        {
            ClearLastHoveredControl();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible)
            {
                groupBox1.Hide();
            } else
            {
                groupBox1.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex= -1;
            comboBox3.SelectedIndex= -1;

            numericUpDown1.Value = 300;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3(processors);
            newform.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3(processors);
            newform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3(processors);
            newform.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���������� ������� ���!");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            // ��� ��� ���������� �������
            if (objectCount >= 0)
            {
                objectCount++; // ����������� ������� ��������

                // ��������� ����� � ������ ���������
                toolStripStatusLabel2.Text = $"�������� ������. ����� ��������: {objectCount}. {DateTime.Now.ToString()}";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            // ��� ��� �������� �������
            if (objectCount > 0)
            {
                objectCount--; // ��������� ������� ��������

                // ��������� ����� � ������ ���������
                toolStripStatusLabel2.Text = $"������ ������. ����� ��������: {objectCount}. {DateTime.Now.ToString()}";
            }
        }
    }
}