using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
                 //enter_entry(s, args); WIP
             };
            display_btn.Click += (s, args) =>
            {
                display_main_list(s, args);
            };
            display_btn2.Click += (s, args) =>
            {
                display_tagged_list(s, args);
            };
            reset_button.Click += (s, args) =>
            {
                reset(s, args);
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
            main.Sort();
            main_listbox.Items.Clear();
            foreach (string line in main)
            {
                //Display untagged entries in the main listbox
                if (line.StartsWith("[UnTagged]"))
                {
                    string cleanedLine = line.Substring("[UnTagged]".Length).Trim(); //Note: The program seems to be writing the tagged entries to the main list and vice versa, fix this later
                    main_listbox.Items.Add(cleanedLine);
                }
                else
                {

                }
            }
        }
        private void display_tagged_list(object sender, EventArgs e)
        {
            tagged.Sort();
            tagged_listbox.Items.Clear();
            foreach (string line in main)
            {
                //Display tagged entries in the tagged listbox
                if (line.StartsWith("[Tagged]"))
                {
                    string cleanedLine2 = line.Substring("[Tagged]".Length).Trim();
                    tagged_listbox.Items.Add(cleanedLine2);
                }
                else
                {

                }
            }
        }
        /*private void enter_entry(object sender, EventArgs e)
        {
            string new_entry = entry_txtbox.Text.Trim();

            if (string.IsNullOrEmpty(new_entry)) //Must remember to add filter
            {

            }
            else if (!string.IsNullOrEmpty(new_entry))
            {
                //Add the new entry to the loaded text file
                File.AppendAllText(filepath, new_entry + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("No file to write to. Please load the file.");
            }
        }*/
        private void reset(object sender, EventArgs e)
        {
            main_listbox.Items.Clear();
            tagged_listbox.Items.Clear();
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
