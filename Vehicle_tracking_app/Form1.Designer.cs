namespace Vehicle_tracking_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.main_listbox = new System.Windows.Forms.ListBox();
            this.open_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.entry_txtbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.tagged_listbox = new System.Windows.Forms.ListBox();
            this.binary_searchbtn = new System.Windows.Forms.Button();
            this.Linear_searchbtn = new System.Windows.Forms.Button();
            this.tag_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.editplate_txtbox = new System.Windows.Forms.TextBox();
            this.Error_txtbox = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.enter_label = new System.Windows.Forms.Label();
            this.edit_label = new System.Windows.Forms.Label();
            this.search_label = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.saveAs_btn = new System.Windows.Forms.Button();
            this.list_search_groupbox = new System.Windows.Forms.GroupBox();
            this.search_TaggedList = new System.Windows.Forms.RadioButton();
            this.search_mainList = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.list_search_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_listbox
            // 
            this.main_listbox.FormattingEnabled = true;
            this.main_listbox.Location = new System.Drawing.Point(31, 222);
            this.main_listbox.Name = "main_listbox";
            this.main_listbox.Size = new System.Drawing.Size(120, 160);
            this.main_listbox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.main_listbox, "Untagged entries are displayed here");
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(29, 125);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Open";
            this.toolTip1.SetToolTip(this.open_button, "Used to load a document");
            this.open_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(152, 432);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Edit";
            this.toolTip1.SetToolTip(this.edit_button, "This button applies changes to the selected entry");
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // entry_txtbox
            // 
            this.entry_txtbox.Location = new System.Drawing.Point(30, 408);
            this.entry_txtbox.Name = "entry_txtbox";
            this.entry_txtbox.Size = new System.Drawing.Size(98, 20);
            this.entry_txtbox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.entry_txtbox, "This textbox is used to add an untagged entry");
            this.entry_txtbox.TextChanged += new System.EventHandler(this.entry_txtbox_TextChanged);
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(30, 432);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(75, 23);
            this.enter_button.TabIndex = 4;
            this.enter_button.Text = "Enter";
            this.toolTip1.SetToolTip(this.enter_button, "This button adds the entered value to the main list");
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // tagged_listbox
            // 
            this.tagged_listbox.FormattingEnabled = true;
            this.tagged_listbox.Location = new System.Drawing.Point(209, 222);
            this.tagged_listbox.Name = "tagged_listbox";
            this.tagged_listbox.Size = new System.Drawing.Size(120, 160);
            this.tagged_listbox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tagged_listbox, "Tagged entries are displayed here");
            // 
            // binary_searchbtn
            // 
            this.binary_searchbtn.Location = new System.Drawing.Point(29, 502);
            this.binary_searchbtn.Name = "binary_searchbtn";
            this.binary_searchbtn.Size = new System.Drawing.Size(94, 23);
            this.binary_searchbtn.TabIndex = 9;
            this.binary_searchbtn.Text = "Binary Search";
            this.toolTip1.SetToolTip(this.binary_searchbtn, "This button initiates a binary search for the value entered above");
            this.binary_searchbtn.UseVisualStyleBackColor = true;
            this.binary_searchbtn.Click += new System.EventHandler(this.binary_searchbtn_Click);
            // 
            // Linear_searchbtn
            // 
            this.Linear_searchbtn.Location = new System.Drawing.Point(30, 531);
            this.Linear_searchbtn.Name = "Linear_searchbtn";
            this.Linear_searchbtn.Size = new System.Drawing.Size(94, 23);
            this.Linear_searchbtn.TabIndex = 10;
            this.Linear_searchbtn.Text = "Linear Search";
            this.toolTip1.SetToolTip(this.Linear_searchbtn, "This button initiates a Linear search for the value entered above");
            this.Linear_searchbtn.UseVisualStyleBackColor = true;
            this.Linear_searchbtn.Click += new System.EventHandler(this.Linear_searchbtn_Click);
            // 
            // tag_button
            // 
            this.tag_button.Location = new System.Drawing.Point(237, 432);
            this.tag_button.Name = "tag_button";
            this.tag_button.Size = new System.Drawing.Size(92, 23);
            this.tag_button.TabIndex = 11;
            this.tag_button.Text = "Tag/Untag Plate";
            this.toolTip1.SetToolTip(this.tag_button, "This button switches the state of a selected entry to Tagged from Untagged or Vic" +
        "e versa");
            this.tag_button.UseVisualStyleBackColor = true;
            this.tag_button.Click += new System.EventHandler(this.tag_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Active Systems PTY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "License Plate Management";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(253, 125);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "Reset";
            this.toolTip1.SetToolTip(this.reset_button, "Used to delete all data");
            this.reset_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::Vehicle_tracking_app.Properties.Resources.logo__1__removebg_preview;
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 65);
            this.label3.TabIndex = 14;
            this.label3.Text = "                    \r\n\r\n\r\n\r\n \r\n";
            // 
            // search_txtbox
            // 
            this.search_txtbox.Location = new System.Drawing.Point(30, 478);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(137, 20);
            this.search_txtbox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.search_txtbox, "This textbox is used to input a value you wish to search for");
            // 
            // editplate_txtbox
            // 
            this.editplate_txtbox.Location = new System.Drawing.Point(230, 408);
            this.editplate_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.editplate_txtbox.Name = "editplate_txtbox";
            this.editplate_txtbox.Size = new System.Drawing.Size(101, 20);
            this.editplate_txtbox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.editplate_txtbox, "This textbox is used to edit selected values or tag a selected value. \r\nNote: Ple" +
        "ase select an entry from either listbox");
            // 
            // Error_txtbox
            // 
            this.Error_txtbox.Location = new System.Drawing.Point(28, 169);
            this.Error_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.Error_txtbox.Name = "Error_txtbox";
            this.Error_txtbox.ReadOnly = true;
            this.Error_txtbox.Size = new System.Drawing.Size(302, 20);
            this.Error_txtbox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.Error_txtbox, "Used to display messages, errors and other useful information from the program");
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(29, 154);
            this.error_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(58, 13);
            this.error_label.TabIndex = 20;
            this.error_label.Text = "Messages:";
            this.error_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // enter_label
            // 
            this.enter_label.AutoSize = true;
            this.enter_label.Location = new System.Drawing.Point(28, 392);
            this.enter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enter_label.Name = "enter_label";
            this.enter_label.Size = new System.Drawing.Size(97, 13);
            this.enter_label.TabIndex = 21;
            this.enter_label.Text = "Enter value to add:";
            this.enter_label.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // edit_label
            // 
            this.edit_label.AutoSize = true;
            this.edit_label.Location = new System.Drawing.Point(227, 392);
            this.edit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edit_label.Name = "edit_label";
            this.edit_label.Size = new System.Drawing.Size(81, 13);
            this.edit_label.TabIndex = 22;
            this.edit_label.Text = "Edit/Tag value:";
            this.edit_label.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(30, 462);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(126, 13);
            this.search_label.TabIndex = 23;
            this.search_label.Text = "Enter value to search for:";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(30, 85);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(74, 23);
            this.save_btn.TabIndex = 24;
            this.save_btn.Text = "Save";
            this.toolTip1.SetToolTip(this.save_btn, "Used to save data to the loaded document");
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // saveAs_btn
            // 
            this.saveAs_btn.Location = new System.Drawing.Point(253, 85);
            this.saveAs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.saveAs_btn.Name = "saveAs_btn";
            this.saveAs_btn.Size = new System.Drawing.Size(74, 23);
            this.saveAs_btn.TabIndex = 25;
            this.saveAs_btn.Text = "Save As";
            this.toolTip1.SetToolTip(this.saveAs_btn, "Used to save the data to a new document");
            this.saveAs_btn.UseVisualStyleBackColor = true;
            // 
            // list_search_groupbox
            // 
            this.list_search_groupbox.Controls.Add(this.search_TaggedList);
            this.list_search_groupbox.Controls.Add(this.search_mainList);
            this.list_search_groupbox.Location = new System.Drawing.Point(178, 491);
            this.list_search_groupbox.Margin = new System.Windows.Forms.Padding(2);
            this.list_search_groupbox.Name = "list_search_groupbox";
            this.list_search_groupbox.Padding = new System.Windows.Forms.Padding(2);
            this.list_search_groupbox.Size = new System.Drawing.Size(150, 68);
            this.list_search_groupbox.TabIndex = 26;
            this.list_search_groupbox.TabStop = false;
            this.list_search_groupbox.Text = "Select List to search";
            this.toolTip1.SetToolTip(this.list_search_groupbox, "These buttons allow you to switch between which list you wish to search");
            this.list_search_groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // search_TaggedList
            // 
            this.search_TaggedList.AutoSize = true;
            this.search_TaggedList.Location = new System.Drawing.Point(4, 38);
            this.search_TaggedList.Margin = new System.Windows.Forms.Padding(2);
            this.search_TaggedList.Name = "search_TaggedList";
            this.search_TaggedList.Size = new System.Drawing.Size(81, 17);
            this.search_TaggedList.TabIndex = 1;
            this.search_TaggedList.TabStop = true;
            this.search_TaggedList.Text = "Tagged List";
            this.search_TaggedList.UseVisualStyleBackColor = true;
            // 
            // search_mainList
            // 
            this.search_mainList.AutoSize = true;
            this.search_mainList.Location = new System.Drawing.Point(4, 17);
            this.search_mainList.Margin = new System.Windows.Forms.Padding(2);
            this.search_mainList.Name = "search_mainList";
            this.search_mainList.Size = new System.Drawing.Size(67, 17);
            this.search_mainList.TabIndex = 0;
            this.search_mainList.TabStop = true;
            this.search_mainList.Text = "Main List";
            this.search_mainList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(356, 566);
            this.Controls.Add(this.list_search_groupbox);
            this.Controls.Add(this.saveAs_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.edit_label);
            this.Controls.Add(this.enter_label);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.Error_txtbox);
            this.Controls.Add(this.editplate_txtbox);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tag_button);
            this.Controls.Add(this.Linear_searchbtn);
            this.Controls.Add(this.binary_searchbtn);
            this.Controls.Add(this.tagged_listbox);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.entry_txtbox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.main_listbox);
            this.Name = "Form1";
            this.Text = "Active Systems PTY";
            this.list_search_groupbox.ResumeLayout(false);
            this.list_search_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox main_listbox;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TextBox entry_txtbox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.ListBox tagged_listbox;
        private System.Windows.Forms.Button binary_searchbtn;
        private System.Windows.Forms.Button Linear_searchbtn;
        private System.Windows.Forms.Button tag_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.TextBox editplate_txtbox;
        private System.Windows.Forms.TextBox Error_txtbox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label enter_label;
        private System.Windows.Forms.Label edit_label;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button saveAs_btn;
        private System.Windows.Forms.GroupBox list_search_groupbox;
        private System.Windows.Forms.RadioButton search_TaggedList;
        private System.Windows.Forms.RadioButton search_mainList;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

