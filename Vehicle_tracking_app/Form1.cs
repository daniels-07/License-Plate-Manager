using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// Daniel Shadbolt
// Date: 19/06/2025
// Version: 1.0
// Vehicle Tracking Application
// This program is used to keep track of license plate numbers, it allows the user to tag, untag, edit, delete, search for and add license plates.

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
            // Open a file dialog and select a file
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFile.Title = "Please select a file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Load the selected text file
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
                // Display untagged entries in the main listbox
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
                // Display untagged entries in the main listbox
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
            //string pattern = @"^[A-Za-z0-9]{6,7}$";
            string pattern = @"^[A-Za-z0-9]{3,4}-[A-Za-z0-9]{3,4}$";

            if (string.IsNullOrEmpty(new_entry)) // Check if the entry is empty
            {
                Error_txtbox.Clear();
                Error_txtbox.Text = "Please enter an entry";
            }
            else if (!Regex.IsMatch(new_entry, pattern)) // Check if the entry matches the regex pattern
            {
                Error_txtbox.Clear();
                Error_txtbox.Text = "Please enter a valid number plate";
            }
            else if (!string.IsNullOrEmpty(new_entry))
            {
                string entrywithtag = "[UnTagged]" + new_entry;

                //Check if the file has content
                string prefix = File.Exists(filepath) && new FileInfo(filepath).Length > 0 ? Environment.NewLine: "";
                Error_txtbox.Clear();
                Error_txtbox.Text = "Entry added successfully!";
                main.Add("[UnTagged]" + new_entry);
                main = main.OrderBy(line => line.Substring("[UnTagged]".Length).Trim()).ToList();
            }
            else
            {
                MessageBox.Show("No file to write to. Please load the file.");
            }
        }
        private void reset(object sender, EventArgs e)
        {
            // Reset the contents of the list
            DialogResult result = MessageBox.Show($"Are you sure you want to delete all data?", "Delete Entry", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                main.Clear();
                tagged.Clear();
                main_listbox.Items.Clear();
                tagged_listbox.Items.Clear();
                Error_txtbox.Clear();
                Error_txtbox.Text = "All entries have been deleted.";
            }
        }
        private void main_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Handle double-click on the main listbox to delete an entry
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
            // Handle Double click on the tagged list to delete an entry
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
            // Handle click on the main listbox to select an entry for editing
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
            // Handle click on the tagged listbox to select an entry for editing
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
            // Validate the input for editing
            string pattern = @"^[A-Za-z0-9]{3-4}-[A-Za-z0-9]{3-4}$";
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
                main_listbox.Items.Clear();
                tagged_listbox.Items.Clear();
                display_main_list(sender, e); 
                display_tagged_list(sender, e); 
            }
            else if (selectedList == "tagged")
            {
                // Update the tagged list
                tagged[selectedIndex] = "[Tagged]" + newEdit;
            }
            else
            {
                Error_txtbox.Text = "Error when trying to edit";
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
                Error_txtbox.Text = "Please load a file first.";
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
            // Save the contents of the main and tagged list as a new text document
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
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
            // Unload the selected file
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
                main.Clear();
                tagged.Clear();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }
        private void binary_search(object sender, EventArgs e)
        {
            string searchEntry = search_txtbox.Text.Trim();
            // Validate the input
            if (string.IsNullOrEmpty(searchEntry))
            {
                Error_txtbox.Text = "Please enter a value to search for.";
                return;
            }
            if (!Regex.IsMatch(searchEntry, @"^[A-Za-z0-9]{3-4}-[A-Za-z0-9]{3-4}$"))
            {
                Error_txtbox.Text = "Please enter a valid number plate.";
                return;
            }

            if (search_mainList.Checked)
            {
                // Perform a binary search on the main list
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
                // Perform a binary search on the tagged list
                int index = tagged.BinarySearch("[Tagged]" + searchEntry);
                if (index >= 0)
                {
                    Error_txtbox.Text = $"Found '{searchEntry}' at index {index} in the tagged list.";
                    tagged_listbox.SelectedIndex = index;
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

            // Validate the input
            if (string.IsNullOrEmpty(searchEntry))
            {
                Error_txtbox.Text = "Please enter a value to search for.";
                return;
            }
            if (!Regex.IsMatch(searchEntry, @"^[A-Za-z0-9]{3-4}-[A-Za-z0-9]{3-4}$"))
            {
                Error_txtbox.Text = "Please enter a valid number plate.";
                return;
            }
            if (search_mainList.Checked)
            {
                // Perform a linear searh on the main list
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
                        main_listbox.SelectedIndex = i;
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
                // Perform a linear search on the tagged list
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
                        tagged_listbox.SelectedIndex = i;
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
            // Move an entry from the main list to the tagged list or vice versa
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

                main_listbox.Items.Clear();
                tagged_listbox.Items.Clear();
                display_main_list(sender, e);
                display_tagged_list(sender, e);
            }
            else
            {
                tagged.Remove("[Tagged]" + selectedText);
                main.Add("[UnTagged]" + selectedText);

                Error_txtbox.Text = $"Untagged: {selectedText}";

                main_listbox.Items.Clear();
                tagged_listbox.Items.Clear();
                display_main_list(sender, e);
                display_tagged_list(sender, e);
            }

            // Refresh the listboxes and sort the lists
            tagged_listbox.ClearSelected();
            main_listbox.ClearSelected();

            main = main.OrderBy(x => x.Substring("[UnTagged]".Length)).ToList();
            tagged = tagged.OrderBy(x => x.Substring("[Tagged]".Length)).ToList();

            Error_txtbox.Text = "Entry tag sucessfully changed";
        }
        private void main_Listbox_selectedIndexChanged(object sender, EventArgs e)
        {
            // This code clears the selection in the tagged listbox when an item in the main listbox is selected
            if (main_listbox.SelectedIndex != -1)
            {
                tagged_listbox.ClearSelected();
            }
        }
        private void tagged_Listbox_selectedIndexChanged(object sender, EventArgs e)
        {
            // This code clears the selection in the main listbox when an item in the tagged listbox is selected
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
