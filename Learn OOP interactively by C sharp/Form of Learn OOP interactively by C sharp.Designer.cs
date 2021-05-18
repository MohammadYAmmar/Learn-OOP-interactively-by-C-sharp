
namespace Learn_OOP_interactively_by_C_sharp
{
    partial class Form_OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OOP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_obj_textBox = new System.Windows.Forms.TextBox();
            this.object_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.class_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interface_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.class_listView = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.objects_listView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.Start_simulation_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.interfaces_listView = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.class_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.interfaces_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.arrow_pictureBox = new System.Windows.Forms.PictureBox();
            this.check_py_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.Access_Modifiers_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of object:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of object:";
            // 
            // name_obj_textBox
            // 
            this.name_obj_textBox.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.name_obj_textBox.Location = new System.Drawing.Point(460, 57);
            this.name_obj_textBox.Name = "name_obj_textBox";
            this.name_obj_textBox.Size = new System.Drawing.Size(364, 67);
            this.name_obj_textBox.TabIndex = 2;
            this.name_obj_textBox.Text = "obj1";
            // 
            // object_checkedListBox
            // 
            this.object_checkedListBox.CheckOnClick = true;
            this.object_checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.object_checkedListBox.FormattingEnabled = true;
            this.object_checkedListBox.Items.AddRange(new object[] {
            "Car",
            "Computer"});
            this.object_checkedListBox.Location = new System.Drawing.Point(460, 181);
            this.object_checkedListBox.Name = "object_checkedListBox";
            this.object_checkedListBox.Size = new System.Drawing.Size(371, 151);
            this.object_checkedListBox.TabIndex = 4;
            this.object_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.object_checkedListBox_SelectedIndexChanged);
            // 
            // class_checkedListBox
            // 
            this.class_checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.class_checkedListBox.FormattingEnabled = true;
            this.class_checkedListBox.Items.AddRange(new object[] {
            "PC",
            "Laptop",
            "Electric car",
            "Gasoline cars",
            "Hybrid cars"});
            this.class_checkedListBox.Location = new System.Drawing.Point(460, 340);
            this.class_checkedListBox.Name = "class_checkedListBox";
            this.class_checkedListBox.Size = new System.Drawing.Size(371, 298);
            this.class_checkedListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 67);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type of class:";
            // 
            // interface_checkedListBox
            // 
            this.interface_checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.interface_checkedListBox.FormattingEnabled = true;
            this.interface_checkedListBox.Items.AddRange(new object[] {
            "Sale",
            "Maintenance"});
            this.interface_checkedListBox.Location = new System.Drawing.Point(460, 664);
            this.interface_checkedListBox.Name = "interface_checkedListBox";
            this.interface_checkedListBox.Size = new System.Drawing.Size(371, 151);
            this.interface_checkedListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 67);
            this.label4.TabIndex = 7;
            this.label4.Text = "Support interfaces:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.class_listView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(1264, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 432);
            this.panel1.TabIndex = 9;
            // 
            // class_listView
            // 
            this.class_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.class_listView.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.class_listView.Location = new System.Drawing.Point(0, 72);
            this.class_listView.Name = "class_listView";
            this.class_listView.Size = new System.Drawing.Size(392, 354);
            this.class_listView.TabIndex = 11;
            this.class_listView.UseCompatibleStateImageBehavior = false;
            this.class_listView.View = System.Windows.Forms.View.List;
            this.class_listView.SelectedIndexChanged += new System.EventHandler(this.class_listView_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(112, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 67);
            this.label5.TabIndex = 11;
            this.label5.Text = "class";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.objects_listView);
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(852, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 432);
            this.panel2.TabIndex = 10;
            // 
            // objects_listView
            // 
            this.objects_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objects_listView.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.objects_listView.Location = new System.Drawing.Point(0, 72);
            this.objects_listView.Name = "objects_listView";
            this.objects_listView.Size = new System.Drawing.Size(392, 350);
            this.objects_listView.TabIndex = 12;
            this.objects_listView.UseCompatibleStateImageBehavior = false;
            this.objects_listView.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(84, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 67);
            this.label6.TabIndex = 12;
            this.label6.Text = "objects";
            // 
            // Start_simulation_button
            // 
            this.Start_simulation_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Start_simulation_button.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.Start_simulation_button.Location = new System.Drawing.Point(460, 829);
            this.Start_simulation_button.Name = "Start_simulation_button";
            this.Start_simulation_button.Size = new System.Drawing.Size(371, 151);
            this.Start_simulation_button.TabIndex = 11;
            this.Start_simulation_button.Text = "Start simulation";
            this.Start_simulation_button.UseVisualStyleBackColor = false;
            this.Start_simulation_button.Click += new System.EventHandler(this.Start_simulation_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.interfaces_listView);
            this.panel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(1676, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 432);
            this.panel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(58, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 67);
            this.label7.TabIndex = 13;
            this.label7.Text = "interfaces";
            // 
            // interfaces_listView
            // 
            this.interfaces_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.interfaces_listView.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.interfaces_listView.Location = new System.Drawing.Point(0, 72);
            this.interfaces_listView.Name = "interfaces_listView";
            this.interfaces_listView.Size = new System.Drawing.Size(392, 350);
            this.interfaces_listView.TabIndex = 12;
            this.interfaces_listView.UseCompatibleStateImageBehavior = false;
            this.interfaces_listView.View = System.Windows.Forms.View.List;
            this.interfaces_listView.SelectedIndexChanged += new System.EventHandler(this.interfaces_listView_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Controls.Add(this.class_label);
            this.panel4.Controls.Add(this.label8);
            this.panel4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(852, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 432);
            this.panel4.TabIndex = 12;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.class_label.Location = new System.Drawing.Point(57, 163);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(263, 67);
            this.class_label.TabIndex = 12;
            this.class_label.Text = "Wait class";
            this.class_label.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(112, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 67);
            this.label8.TabIndex = 11;
            this.label8.Text = "class";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel5.Controls.Add(this.interfaces_label);
            this.panel5.Controls.Add(this.label9);
            this.panel5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(1676, 518);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 432);
            this.panel5.TabIndex = 13;
            // 
            // interfaces_label
            // 
            this.interfaces_label.AutoSize = true;
            this.interfaces_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaces_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.interfaces_label.Location = new System.Drawing.Point(5, 173);
            this.interfaces_label.Name = "interfaces_label";
            this.interfaces_label.Size = new System.Drawing.Size(387, 67);
            this.interfaces_label.TabIndex = 13;
            this.interfaces_label.Text = "Wait interfaces";
            this.interfaces_label.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(58, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 67);
            this.label9.TabIndex = 11;
            this.label9.Text = "interfaces";
            // 
            // arrow_pictureBox
            // 
            this.arrow_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("arrow_pictureBox.Image")));
            this.arrow_pictureBox.Location = new System.Drawing.Point(1250, 691);
            this.arrow_pictureBox.Name = "arrow_pictureBox";
            this.arrow_pictureBox.Size = new System.Drawing.Size(420, 77);
            this.arrow_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow_pictureBox.TabIndex = 14;
            this.arrow_pictureBox.TabStop = false;
            this.arrow_pictureBox.Visible = false;
            // 
            // check_py_button
            // 
            this.check_py_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.check_py_button.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.check_py_button.Location = new System.Drawing.Point(1, 857);
            this.check_py_button.Name = "check_py_button";
            this.check_py_button.Size = new System.Drawing.Size(291, 123);
            this.check_py_button.TabIndex = 15;
            this.check_py_button.Text = "Feature: Check if python installed";
            this.check_py_button.UseVisualStyleBackColor = false;
            this.check_py_button.Visible = false;
            this.check_py_button.Click += new System.EventHandler(this.check_py_button_Click);
            // 
            // about_button
            // 
            this.about_button.BackColor = System.Drawing.Color.DarkOrange;
            this.about_button.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.about_button.Location = new System.Drawing.Point(1874, 956);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(194, 58);
            this.about_button.TabIndex = 16;
            this.about_button.Text = "About program";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // Access_Modifiers_button
            // 
            this.Access_Modifiers_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Access_Modifiers_button.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.Access_Modifiers_button.Location = new System.Drawing.Point(1264, 799);
            this.Access_Modifiers_button.Name = "Access_Modifiers_button";
            this.Access_Modifiers_button.Size = new System.Drawing.Size(371, 151);
            this.Access_Modifiers_button.TabIndex = 17;
            this.Access_Modifiers_button.Text = "Beta:Access Modifiers";
            this.Access_Modifiers_button.UseVisualStyleBackColor = false;
            this.Access_Modifiers_button.Click += new System.EventHandler(this.Access_Modifiers_button_Click);
            // 
            // Form_OOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(2080, 1012);
            this.Controls.Add(this.Access_Modifiers_button);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.check_py_button);
            this.Controls.Add(this.arrow_pictureBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Start_simulation_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.interface_checkedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.class_checkedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.object_checkedListBox);
            this.Controls.Add(this.name_obj_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_OOP";
            this.Text = "Learn OOP interactively by C sharp | By: Eng. Mohammad Yaser Ammar";
            this.Load += new System.EventHandler(this.Form_OOP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_obj_textBox;
        private System.Windows.Forms.CheckedListBox object_checkedListBox;
        private System.Windows.Forms.CheckedListBox class_checkedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox interface_checkedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView class_listView;
        private System.Windows.Forms.ListView objects_listView;
        private System.Windows.Forms.Button Start_simulation_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView interfaces_listView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox arrow_pictureBox;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.Label interfaces_label;
        private System.Windows.Forms.Button check_py_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button Access_Modifiers_button;
    }
}

