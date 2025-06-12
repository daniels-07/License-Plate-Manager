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
            this.main_listbox = new System.Windows.Forms.ListBox();
            this.open_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.entry_txtbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.tagged_listbox = new System.Windows.Forms.ListBox();
            this.binary_searchbtn = new System.Windows.Forms.Button();
            this.Linear_searchbtn = new System.Windows.Forms.Button();
            this.tag_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.display_btn = new System.Windows.Forms.Button();
            this.display_btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_listbox
            // 
            this.main_listbox.FormattingEnabled = true;
            this.main_listbox.Location = new System.Drawing.Point(29, 148);
            this.main_listbox.Name = "main_listbox";
            this.main_listbox.Size = new System.Drawing.Size(120, 160);
            this.main_listbox.TabIndex = 0;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(29, 80);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(146, 358);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // entry_txtbox
            // 
            this.entry_txtbox.Location = new System.Drawing.Point(112, 326);
            this.entry_txtbox.Name = "entry_txtbox";
            this.entry_txtbox.Size = new System.Drawing.Size(137, 20);
            this.entry_txtbox.TabIndex = 3;
            this.entry_txtbox.TextChanged += new System.EventHandler(this.entry_txtbox_TextChanged);
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(45, 358);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(75, 23);
            this.enter_button.TabIndex = 4;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(137, 80);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // tagged_listbox
            // 
            this.tagged_listbox.FormattingEnabled = true;
            this.tagged_listbox.Location = new System.Drawing.Point(208, 148);
            this.tagged_listbox.Name = "tagged_listbox";
            this.tagged_listbox.Size = new System.Drawing.Size(120, 160);
            this.tagged_listbox.TabIndex = 8;
            // 
            // binary_searchbtn
            // 
            this.binary_searchbtn.Location = new System.Drawing.Point(83, 428);
            this.binary_searchbtn.Name = "binary_searchbtn";
            this.binary_searchbtn.Size = new System.Drawing.Size(94, 23);
            this.binary_searchbtn.TabIndex = 9;
            this.binary_searchbtn.Text = "Binary Search";
            this.binary_searchbtn.UseVisualStyleBackColor = true;
            this.binary_searchbtn.Click += new System.EventHandler(this.binary_searchbtn_Click);
            // 
            // Linear_searchbtn
            // 
            this.Linear_searchbtn.Location = new System.Drawing.Point(183, 428);
            this.Linear_searchbtn.Name = "Linear_searchbtn";
            this.Linear_searchbtn.Size = new System.Drawing.Size(94, 23);
            this.Linear_searchbtn.TabIndex = 10;
            this.Linear_searchbtn.Text = "Linear Search";
            this.Linear_searchbtn.UseVisualStyleBackColor = true;
            this.Linear_searchbtn.Click += new System.EventHandler(this.Linear_searchbtn_Click);
            // 
            // tag_button
            // 
            this.tag_button.Location = new System.Drawing.Point(245, 358);
            this.tag_button.Name = "tag_button";
            this.tag_button.Size = new System.Drawing.Size(75, 23);
            this.tag_button.TabIndex = 11;
            this.tag_button.Text = "Tag Plate";
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
            this.reset_button.Location = new System.Drawing.Point(253, 80);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "Reset";
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
            this.search_txtbox.Location = new System.Drawing.Point(112, 402);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(137, 20);
            this.search_txtbox.TabIndex = 15;
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(29, 119);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(75, 23);
            this.display_btn.TabIndex = 16;
            this.display_btn.Text = "Display";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // display_btn2
            // 
            this.display_btn2.Location = new System.Drawing.Point(253, 119);
            this.display_btn2.Name = "display_btn2";
            this.display_btn2.Size = new System.Drawing.Size(75, 23);
            this.display_btn2.TabIndex = 17;
            this.display_btn2.Text = "Display";
            this.display_btn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(356, 463);
            this.Controls.Add(this.display_btn2);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tag_button);
            this.Controls.Add(this.Linear_searchbtn);
            this.Controls.Add(this.binary_searchbtn);
            this.Controls.Add(this.tagged_listbox);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.entry_txtbox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.main_listbox);
            this.Name = "Form1";
            this.Text = "Active Systems PTY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox main_listbox;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TextBox entry_txtbox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListBox tagged_listbox;
        private System.Windows.Forms.Button binary_searchbtn;
        private System.Windows.Forms.Button Linear_searchbtn;
        private System.Windows.Forms.Button tag_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Button display_btn;
        private System.Windows.Forms.Button display_btn2;
    }
}

