using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_tracking_app
{
    public partial class Form1 : Form
    {

        List<string> main = new List<string>();
        List<string> tagged = new List<string>();
        public Form1()
        {
            InitializeComponent();

            open_button.Click += (s, args) =>
            {
                load_file(s, args);
            };

            enter_button.Click += (s, args) =>
             {
                 string input = entry_txtbox.Text;
                 main.Add(input);
                 entry_txtbox.Clear();
                 
             };
            display_btn.Click += (s, args) =>
            {
                display_main_list(s, args);
            };

        }
        private void load_file(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFile.Title = "Please select a file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFile.FileName;

                main = File.ReadAllLines(filepath).ToList();

                entry_txtbox.Text = $"You have selected: {filepath}";
            }
        }
        private void display_main_list(object sender, EventArgs e)
        {
            foreach (string item in main)
            {
                main_listbox.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void binary_searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tag_button_Click(object sender, EventArgs e)
        {

        }

        private void entry_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Linear_searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
