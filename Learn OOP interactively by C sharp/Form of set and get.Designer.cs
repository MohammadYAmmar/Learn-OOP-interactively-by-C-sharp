
namespace Learn_OOP_interactively_by_C_sharp
{
    partial class Form_of_set_and_get
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // name_obj_label
            // 
            this.name_obj_label.AutoSize = true;
            this.name_obj_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_obj_label.Location = new System.Drawing.Point(4, 86);
            this.name_obj_label.Name = "name_obj_label";
            this.name_obj_label.Size = new System.Drawing.Size(406, 67);
            this.name_obj_label.TabIndex = 0;
            this.name_obj_label.Text = "Name of object: ";
            // 
            // type_obj_label
            // 
            this.type_obj_label.AutoSize = true;
            this.type_obj_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_obj_label.Location = new System.Drawing.Point(4, 213);
            this.type_obj_label.Name = "type_obj_label";
            this.type_obj_label.Size = new System.Drawing.Size(390, 67);
            this.type_obj_label.TabIndex = 1;
            this.type_obj_label.Text = "Type of object: ";
            // 
            // type_class_label
            // 
            this.type_class_label.AutoSize = true;
            this.type_class_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_class_label.Location = new System.Drawing.Point(4, 372);
            this.type_class_label.Name = "type_class_label";
            this.type_class_label.Size = new System.Drawing.Size(353, 67);
            this.type_class_label.TabIndex = 5;
            this.type_class_label.Text = "Type of class: ";
            // 
            // support_interface_label
            // 
            this.support_interface_label.AutoSize = true;
            this.support_interface_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.support_interface_label.Location = new System.Drawing.Point(4, 696);
            this.support_interface_label.Name = "support_interface_label";
            this.support_interface_label.Size = new System.Drawing.Size(485, 67);
            this.support_interface_label.TabIndex = 7;
            this.support_interface_label.Text = "Support interfaces: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.class_listView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(1264, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 432);
            this.panel1.TabIndex = 9;
            // 
            // class_listView
            // 
            this.class_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.class_listView.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.class_listView.Location = new System.Drawing.Point(0, 82);
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
            this.label5.Location = new System.Drawing.Point(112, 12);
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
            this.panel2.Location = new System.Drawing.Point(852, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 432);
            this.panel2.TabIndex = 10;
            // 
            // objects_listView
            // 
            this.objects_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objects_listView.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.objects_listView.Location = new System.Drawing.Point(0, 82);
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
            this.label6.Location = new System.Drawing.Point(84, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 67);
            this.label6.TabIndex = 12;
            this.label6.Text = "objects";
            // 
            // Start_simulation_button
            // 
            this.Start_simulation_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Start_simulation_button.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.Start_simulation_button.Location = new System.Drawing.Point(460, 861);
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
            this.panel3.Location = new System.Drawing.Point(1676, 98);
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
            this.label7.Size = new System.Drawing.Size(262, 67);
            this.label7.TabIndex = 13;
            this.label7.Text = "interfaces";
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
            this.panel4.Location = new System.Drawing.Point(852, 550);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 432);
            this.panel4.TabIndex = 12;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.class_label.Location = new System.Drawing.Point(57, 173);
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
            this.panel5.Location = new System.Drawing.Point(1676, 550);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 432);
            this.panel5.TabIndex = 13;
            // 
            // interfaces_label
            // 
            this.interfaces_label.AutoSize = true;
            this.interfaces_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaces_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.interfaces_label.Location = new System.Drawing.Point(5, 183);
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
            this.arrow_pictureBox.Location = new System.Drawing.Point(1250, 723);
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
            this.check_py_button.Location = new System.Drawing.Point(1, 889);
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
            this.about_button.Location = new System.Drawing.Point(1874, 12);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(194, 58);
            this.about_button.TabIndex = 16;
            this.about_button.Text = "About program";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // Form_of_set_and_get
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(2080, 1012);
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
            this.Name = "Form_of_set_and_get";
            this.Text = "Learn OOP interactively by C sharp | By: Eng. Mohammad Yaser Ammar";
            this.Load += new System.EventHandler(this.Form_of_set_and_get_Load);
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

            private System.Windows.Forms.Label name_obj_label;
            private System.Windows.Forms.Label type_obj_label;
            private System.Windows.Forms.Label type_class_label;
            private System.Windows.Forms.Label support_interface_label;
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
        }
    }

