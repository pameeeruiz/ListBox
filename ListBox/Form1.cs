using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBoxAnimales.Items.Add("Perro");
            ListBoxAnimales.Items.Add("Gato");
            ListBoxAnimales.Items.Add("Conejo");
            ListBoxAnimales.Items.Add("Pez");
        }

        private void ListBoxAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string animal = ListBoxAnimales.SelectedItem.ToString();
            switch (animal)
            {
                case "Perro":
                    PictureBoxAnimales.Image = Image.FromFile("C:\\Users\\MiniLab-ing05\\source\\repos\\ListBox\\ListBox\\perro.jpg");
                    break;
                case "Gato":
                    PictureBoxAnimales.Image = Image.FromFile("gato.jpg");
                    break;
                case "Conejo":
                    PictureBoxAnimales.Image = Image.FromFile("conejo.jpg");
                    break;
                case "Pez":
                    PictureBoxAnimales.Image = Image.FromFile("pez.jpg");
                    break;
                default:
                    PictureBoxAnimales.Image = null;
                    break;
            }

        }
    }
}
