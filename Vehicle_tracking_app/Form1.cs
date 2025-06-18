using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_tracking_app
{
    public partial class Form1 : Form
    {
        private string filepath = "";
        List<string> main = new List<string>();
        List<string> tagged = new List<string>();

        private int selectedIndex = -1;
        private string selectedList = "";
        public Form1()
        {
            InitializeComponent();
            main_listbox.MouseDoubleClick += main_listbox_MouseDoubleClick;
            tagged_listbox.MouseDoubleClick += tagged_listbox_MouseDoubleClick;
            main_listbox.MouseClick += main_listbox_MouseClick;
            tagged_listbox.MouseClick += tagged_listbox_MouseClick;
            main_listbox.SelectedIndexChanged += main_Listbox_selectedIndexChanged;
            tagged_listbox.SelectedIndexChanged += tagged_Listbox_selectedIndexChanged;
            search_mainList.Checked = true;

            save_btn.Click += (s, args) =>
            {
                save(s, args);
            };
            saveAs_btn.Click += (s, args) =>
            {
                saveAs(s, args);
            };
            open_button.Click += (s, args) =>
            {
                load_file(s, args);
            };
            enter_button.Click += (s, args) =>
             {
                 enter_entry(s, args);
             };
            exit_button.Click += (s, args) =>
            {
                exit(s, args);
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
            edit_button.Click += (s, args) =>
            {
                edit(s, args);
            };
            tag_button.Click += (s, args) =>
            {
                tag_plate(s, args);
            };
            binary_searchbtn.Click += (s, args) =>
            {
                binary_search(s, args);
            };
            Linear_searchbtn.Click += (s, args) =>
            {
                linear_search(s, args);
            };

        }
        private void load_file(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFile.Title = "Please select a file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filepath = openFile.FileName;

                main = File.ReadAllLines(filepath).Where(line => line.StartsWith("[UnTagged")).ToList();
                tagged = File.ReadAllLines(filepath).Where(line => line.StartsWith("[Tagged")).ToList();

                Error_txtbox.Clear();
                Error_txtbox.Text = $"You have selected: {filepath}";
            }
        }
        private void display_main_list(object sender, EventArgs e)
        {
            main_listbox.Items.Clear();
            main = main.OrderBy(line => line.Substring("[UnTagged]".Length).Trim()).ToList();

            foreach (string line in main)
            {
                //Display untagged entries in the main listbox
                if (line.StartsWith("[UnTagged]"))
                {
                    string cleanedLine = line.Substring("[UnTagged]".Length).Trim(); 
                    main_listbox.Items.Add(cleanedLine);
                }
                else
                {

                }
            }
        }
        private void display_tagged_list(object sender, EventArgs e)
        {
            tagged_listbox.Items.Clear();
            tagged = tagged.OrderBy(line => line.Substring("[Tagged]".Length).Trim()).ToList();

            foreach (string line in tagged)
            {
                //Display untagged entries in the main listbox
                if (line.StartsWith("[Tagged]"))
                {
                    string cleanedLine = line.Substring("[Tagged]".Length).Trim(); 
                    tagged_listbox.Items.Add(cleanedLine);
                }
                else
                {

                }
            }
        }
        private void enter_entry(object sender, EventArgs e)
        {
            string new_entry = entry_txtbox.Text.Trim();
            string pattern = @"^[A-Za-z0-9]{6,7}$";

            if (string.IsNullOrEmpty(new_entry)) //Check if the entry is empty
            {
                Error_txtbox.Clear();
                Error_txtbox.Text = "Please enter an entry";
            }
            else if (!Regex.IsMatch(new_entry, pattern)) //Check if the entry matches the pattern
            {
                Error_txtbox.Clear();
                Error_txtbox.Text = "Please enter a valid number plate";
            }
            else if (!string.IsNullOrEmpty(new_entry))
            {
                string entrywithtag = "[UnTagged]" + new_entry;

                //Check if the file has content
                string prefix = File.Exists(filepath) && new FileInfo(filepath).Length > 0 ? Environment.NewLine: "";
                //Add the new entry to the loaded text file
                //File.AppendAllText(filepath, "[UnTagged]" + new_entry + Environment.NewLine);
                Error_txtbox.Clear();
                Error_txtbox.Text = "Entry added successfully!";
                main.Add("[UnTagged] " + new_entry);
                main = main.OrderBy(line => line.Substring("[UnTagged]".Length).Trim()).ToList();
            }
            else
            {
                MessageBox.Show("No file to write to. Please load the file.");
            }
        }
        private void reset(object sender, EventArgs e)
        {
            main_listbox.Items.Clear();
            tagged_listbox.Items.Clear();
        }
        private void main_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = main_listbox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string selectedItem = main_listbox.Items[index].ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedItem}'?", "Delete Entry", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    main.Remove("[UnTagged]" + selectedItem);
                    //File.WriteAllLines(filepath, main.Concat(tagged));
                    Error_txtbox.Text = $"Deleted entry: {selectedItem}";
                }
            }
        }
        private void tagged_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = tagged_listbox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string selectedItem = tagged_listbox.Items[index].ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedItem}'?", "Delete Entry", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    tagged.Remove("[Tagged]" + selectedItem);
                    //File.WriteAllLines(filepath, main.Concat(main));
                    Error_txtbox.Text = $"Deleted entry: {selectedItem}";
                }
            }
        }
        private void main_listbox_MouseClick(object sender, MouseEventArgs e)
        {
            selectedIndex = main_listbox.IndexFromPoint(e.Location);
            if (selectedIndex != ListBox.NoMatches)
            {
                string selectedItem = main_listbox.Items[selectedIndex].ToString();
                editplate_txtbox.Text = selectedItem;
                selectedList = "main";
            }
        }
        private void tagged_listbox_MouseClick(object sender, MouseEventArgs e)
        {
            selectedIndex = tagged_listbox.IndexFromPoint(e.Location);
            if (selectedIndex != ListBox.NoMatches)
            {
                string selectedItem = tagged_listbox.Items[selectedIndex].ToString();
                editplate_txtbox.Text = selectedItem;
                selectedList = "tagged";
            }
        }

        private void edit(object sender, EventArgs e)
        {
            string pattern = @"^[A-Z][0-9]{2,4}[A-Z][0-9]{2,4}$";
            string newEdit = editplate_txtbox.Text.Trim();

            if (selectedIndex == -1 || string.IsNullOrEmpty(selectedList))
            {
                Error_txtbox.Text = "Please select an entry to edit first";
                return;
            }
            if (string.IsNullOrEmpty(newEdit))
            {
                Error_txtbox.Text = "Please enter a value to edit";
                return;
            }
            if (!Regex.IsMatch(newEdit, pattern))
            {
                Error_txtbox.Text = "Please enter a valid number plate";
                return;
            }
            if (selectedList == "main")
            {
                // Update the main list
                main[selectedIndex] = "[UnTagged]" + newEdit;
            }
            else if (selectedList == "tagged")
            {
                // Update the tagged list
                tagged[selectedIndex] = "[Tagged]" + newEdit;
            }
            else
            {
                Error_txtbox.Text = "Error editing";
                return;
            }
                Error_txtbox.Text = "Entry successfully edited!";

            // Reset the selection
            selectedList = "";
            selectedIndex = -1;
            editplate_txtbox.Clear();
        }

        private void save(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Please load a file first.");
                return;
            }
            try
            {
                // Save the main and tagged lists back to the file
                File.WriteAllLines(filepath, main.Concat(tagged));
                Error_txtbox.Text = "File saved successfully!";
            }
            catch (Exception ex)
            {
                Error_txtbox.Text = $"Error saving file: {ex.Message}";
            }
        }
        private void saveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save File As";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                File.WriteAllLines(filepath, main.Concat(tagged));
                Error_txtbox.Clear();
                Error_txtbox.Text = $"File saved as: {filepath}";
            }
        }
        private void exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save before exiting?", "Exit Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                save(sender, e);
                filepath = "";
                Error_txtbox.Clear();
                Error_txtbox.Text = "Closing loaded file";
            }
            else if (result == DialogResult.No)
            {
                filepath = "";
                Error_txtbox.Clear();
                Error_txtbox.Text = "Closing loaded file";
            }
        }
        private void binary_search(object sender, EventArgs e)
        {
            string searchEntry = search_txtbox.Text.Trim();
            if (string.IsNullOrEmpty(searchEntry))
            {
                Error_txtbox.Text = "Please enter a value to search for.";
                return;
            }
            if (!Regex.IsMatch(searchEntry, @"^[A-Za-z0-9]{6,7}$"))
            {
                Error_txtbox.Text = "Please enter a valid number plate.";
                return;
            }

            if (search_mainList.Checked)
            {
                int index = main.BinarySearch("[UnTagged]" + searchEntry);
                if (index >= 0)
                {
                    Error_txtbox.Text = $"Found '{searchEntry}' at index {index} in the main list.";
                    main_listbox.SelectedIndex = index;
                }
                else
                {
                    Error_txtbox.Text = $"'{searchEntry}' not found in the main list.";
                }
            }
            else if (search_TaggedList.Checked)
            {
                int index = tagged.BinarySearch("[Tagged]" + searchEntry);
                if (index >= 0)
                {
                    Error_txtbox.Text = $"Found '{searchEntry}' at index {index} in the tagged list.";
                    main_listbox.SelectedIndex = index;
                }
                else
                {
                    Error_txtbox.Text = $"'{searchEntry}' not found in the tagged list.";
                }
            }
            
        }
        private void linear_search(object sender, EventArgs e)
        {
            string searchEntry = search_txtbox.Text.Trim();
            string formattedsearch = "[UnTagged]" + searchEntry;
            string formattedsearchTagged = "[Tagged]" + searchEntry;
            bool isfound = false;

            if (string.IsNullOrEmpty(searchEntry))
            {
                Error_txtbox.Text = "Please enter a value to search for.";
                return;
            }
            if (!Regex.IsMatch(searchEntry, @"^[A-Za-z0-9]{6,7}$"))
            {
                Error_txtbox.Text = "Please enter a valid number plate.";
                return;
            }
            if (search_mainList.Checked)
            {
                for (int i = 0; i < main.Count; i++)
                {
                    if (main[i].Equals(formattedsearch, StringComparison.OrdinalIgnoreCase))
                    {
                        Error_txtbox.Text = $"Found '{searchEntry}' at index {i} in the main list.";

                        main_listbox.Items.Clear();
                        foreach (var line in main)
                        {
                            string cleaned = line.Substring("[UnTagged]".Length).Trim();
                            main_listbox.Items.Add(cleaned);
                        }
                        isfound = true;
                        break;
                    }
                }
                if (!isfound)
                {
                    Error_txtbox.Text = $"'{searchEntry}' not found in the main list.";
                    main_listbox.ClearSelected();
                }
            }
            else if (search_TaggedList.Checked)
            {
                for (int i = 0; i < tagged.Count; i++)
                {
                    if (tagged[i].Equals(formattedsearchTagged, StringComparison.OrdinalIgnoreCase))
                    {
                        Error_txtbox.Text = $"Found '{searchEntry}' at index {i} in the tagged list.";

                        tagged_listbox.Items.Clear();
                        foreach (var line in tagged)
                        {
                            string cleaned = line.Substring("[Tagged]".Length).Trim();
                            tagged_listbox.Items.Add(cleaned);
                        }
                        isfound = true;
                        break;
                    }
                }
                if (!isfound)
                {
                    Error_txtbox.Text = $"'{searchEntry}' not found in the tagged list.";
                    main_listbox.ClearSelected();
                }
            }
        }
        private void tag_plate(object sender, EventArgs e)
        {
            string selectedText = "";
            bool isMainSelected = false;

            if (main_listbox.SelectedItem != null)
            {
                selectedText = main_listbox.SelectedItem.ToString();
                isMainSelected = true;
            }
            else if (tagged_listbox.SelectedItem != null)
            {
                selectedText = tagged_listbox.SelectedItem.ToString();
            }
            else
            {
                Error_txtbox.Text = "Please select an entry to tag or untag.";
                return;
            }

            if (isMainSelected)
            {
                main.Remove("[UnTagged]" + selectedText);
                tagged.Add("[Tagged]" + selectedText);

                Error_txtbox.Text = $"Tagged: {selectedText}";
            }
            else
            {
                tagged.Remove("[Tagged]" + selectedText);
                main.Add("[UnTagged]" + selectedText);

                Error_txtbox.Text = $"Untagged: {selectedText}";
            }

            tagged_listbox.ClearSelected();
            main_listbox.ClearSelected();

            main = main.OrderBy(x => x.Substring("[UnTagged]".Length)).ToList();
            tagged = tagged.OrderBy(x => x.Substring("[Tagged]".Length)).ToList();

            Error_txtbox.Text = "Entry tag sucessfully changed";
        }
        private void main_Listbox_selectedIndexChanged(object sender, EventArgs e)
        {
            if (main_listbox.SelectedIndex != -1)
            {
                tagged_listbox.ClearSelected();
            }
        }
        private void tagged_Listbox_selectedIndexChanged(object sender, EventArgs e)
        {
            if (tagged_listbox.SelectedIndex != -1)
            {
                main_listbox.ClearSelected();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
