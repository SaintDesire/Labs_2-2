using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{

    public partial class Form2 : Form
    {
        private Processor _selectedProcessor;

        public Form2(Processor selectedProcessor)
        {
            InitializeComponent();

            _selectedProcessor = selectedProcessor;
            label2.Text  = _selectedProcessor.Manufacturer;
            label3.Text  = _selectedProcessor.Series;
            label5.Text  = _selectedProcessor.Model;
            label7.Text  = _selectedProcessor.NumberOfCores.ToString();
            label9.Text  = _selectedProcessor.Frequency.ToString();
            label11.Text = _selectedProcessor.MaxFrequency.ToString();
            label13.Text = _selectedProcessor.ArchitectureBits.ToString();
            label15.Text = _selectedProcessor.CacheSize;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

    }


}
