
namespace Learn_OOP_interactively_by_C_sharp
{
    partial class Form_Access_Modifiers
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
            this.name_obj_label = new System.Windows.Forms.Label();
            this.type_obj_label = new System.Windows.Forms.Label();
            this.type_class_label = new System.Windows.Forms.Label();
            this.support_interface_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.access_modifier_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.class_members_checkedListBox = new System.Windows.Forms.CheckedListBox();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.info_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_pictureBox)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_obj_label
            // 
            this.name_obj_label.AutoSize = true;
            this.name_obj_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_obj_label.Location = new System.Drawing.Point(0, 86);
            this.name_obj_label.Name = "name_obj_label";
            this.name_obj_label.Size = new System.Drawing.Size(406, 67);
            this.name_obj_label.TabIndex = 0;
            this.name_obj_label.Text = "Name of object: ";
            // 
            // type_obj_label
            // 
            this.type_obj_label.AutoSize = true;
            this.type_obj_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_obj_label.Location = new System.Drawing.Point(0, 190);
            this.type_obj_label.Name = "type_obj_label";
            this.type_obj_label.Size = new System.Drawing.Size(390, 67);
            this.type_obj_label.TabIndex = 1;
            this.type_obj_label.Text = "Type of object: ";
            // 
            // type_class_label
            // 
            this.type_class_label.AutoSize = true;
            this.type_class_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_class_label.Location = new System.Drawing.Point(0, 287);
            this.type_class_label.Name = "type_class_label";
            this.type_class_label.Size = new System.Drawing.Size(353, 67);
            this.type_class_label.TabIndex = 5;
            this.type_class_label.Text = "Type of class: ";
            // 
            // support_interface_label
            // 
            this.support_interface_label.AutoSize = true;
            this.support_interface_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.support_interface_label.Location = new System.Drawing.Point(0, 400);
            this.support_interface_label.Name = "support_interface_label";
            this.support_interface_label.Size = new System.Drawing.Size(485, 67);
            this.support_interface_label.TabIndex = 7;
            this.support_interface_label.Text = "Support interfaces: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.access_modifier_checkedListBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(1222, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 432);
            this.panel1.TabIndex = 9;
            // 
            // access_modifier_checkedListBox
            // 
            this.access_modifier_checkedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.access_modifier_checkedListBox.CheckOnClick = true;
            this.access_modifier_checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.access_modifier_checkedListBox.FormattingEnabled = true;
            this.access_modifier_checkedListBox.Items.AddRange(new object[] {
            "public",
            "private",
            "protected",
            "internal - soon -"});
            this.access_modifier_checkedListBox.Location = new System.Drawing.Point(3, 82);
            this.access_modifier_checkedListBox.Name = "access_modifier_checkedListBox";
            this.access_modifier_checkedListBox.Size = new System.Drawing.Size(386, 347);
            this.access_modifier_checkedListBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 67);
            this.label5.TabIndex = 11;
            this.label5.Text = "Access modifier";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.class_members_checkedListBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(810, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 432);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // class_members_checkedListBox
            // 
            this.class_members_checkedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.class_members_checkedListBox.CheckOnClick = true;
            this.class_members_checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.class_members_checkedListBox.FormattingEnabled = true;
            this.class_members_checkedListBox.Items.AddRange(new object[] {
            "Car",
            "Computer"});
            this.class_members_checkedListBox.Location = new System.Drawing.Point(3, 82);
            this.class_members_checkedListBox.Name = "class_members_checkedListBox";
            this.class_members_checkedListBox.Size = new System.Drawing.Size(386, 347);
            this.class_members_checkedListBox.TabIndex = 17;
            this.class_members_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.class_members_checkedListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(33, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 67);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class members";
            // 
            // Start_simulation_button
            // 
            this.Start_simulation_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Start_simulation_button.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.Start_simulation_button.Location = new System.Drawing.Point(85, 712);
            this.Start_simulation_button.Name = "Start_simulation_button";
            this.Start_simulation_button.Size = new System.Drawing.Size(516, 151);
            this.Start_simulation_button.TabIndex = 11;
            this.Start_simulation_button.Text = "Start simulation??";
            this.Start_simulation_button.UseVisualStyleBackColor = false;
            this.Start_simulation_button.Click += new System.EventHandler(this.Start_simulation_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.interfaces_listView);
            this.panel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(1634, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 432);
            this.panel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(58, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 67);
            this.label7.TabIndex = 13;
            this.label7.Text = "interfaces??";
            // 
            // interfaces_listView
            // 
            this.interfaces_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.interfaces_listView.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.interfaces_listView.Location = new System.Drawing.Point(0, 82);
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
            this.panel4.Location = new System.Drawing.Point(810, 733);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 249);
            this.panel4.TabIndex = 12;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.class_label.Location = new System.Drawing.Point(33, 128);
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
            this.label8.Location = new System.Drawing.Point(112, 12);
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
            this.panel5.Location = new System.Drawing.Point(1634, 733);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 249);
            this.panel5.TabIndex = 13;
            // 
            // interfaces_label
            // 
            this.interfaces_label.AutoSize = true;
            this.interfaces_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaces_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.interfaces_label.Location = new System.Drawing.Point(5, 128);
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
            this.label9.Location = new System.Drawing.Point(58, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 67);
            this.label9.TabIndex = 11;
            this.label9.Text = "interfaces";
            // 
            // arrow_pictureBox
            // 
            this.arrow_pictureBox.Location = new System.Drawing.Point(1208, 826);
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
            this.check_py_button.Location = new System.Drawing.Point(-3, 889);
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
            this.about_button.Location = new System.Drawing.Point(1832, 12);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(194, 58);
            this.about_button.TabIndex = 16;
            this.about_button.Text = "About program";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.error_label);
            this.panel6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Location = new System.Drawing.Point(807, 534);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1219, 172);
            this.panel6.TabIndex = 18;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Blue;
            this.error_label.Location = new System.Drawing.Point(14, 9);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(226, 67);
            this.error_label.TabIndex = 12;
            this.error_label.Text = "No error";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.info_label);
            this.panel7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Location = new System.Drawing.Point(12, 534);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(683, 172);
            this.panel7.TabIndex = 19;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.info_label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.info_label.Location = new System.Drawing.Point(15, 23);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(629, 49);
            this.info_label.TabIndex = 20;
            this.info_label.Text = "Waiting for the user to fill the boxes";
            // 
            // Form_Access_Modifiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(2037, 1012);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.check_py_button);
            this.Controls.Add(this.arrow_pictureBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Start_simulation_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.support_interface_label);
            this.Controls.Add(this.type_class_label);
            this.Controls.Add(this.type_obj_label);
            this.Controls.Add(this.name_obj_label);
            this.Name = "Form_Access_Modifiers";
            this.Text = "Learn OOP interactively by C sharp | Access modifier: Set and Get | By: Eng. Moha" +
    "mmad Yaser Ammar";
            this.Load += new System.EventHandler(this.Form_Access_Modifiers_Load);
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label name_obj_label;
            private System.Windows.Forms.Label type_obj_label;
            private System.Windows.Forms.Label type_class_label;
            private System.Windows.Forms.Label support_interface_label;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Panel panel2;
            private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.CheckedListBox class_members_checkedListBox;
        private System.Windows.Forms.CheckedListBox access_modifier_checkedListBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label info_label;
    }
    }

