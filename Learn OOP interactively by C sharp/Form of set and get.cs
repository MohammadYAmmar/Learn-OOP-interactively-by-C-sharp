﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_OOP_interactively_by_C_sharp
{
    public partial class Form_of_set_and_get : Form
    {
        //#todo write
        public Form_of_set_and_get()
        {
            InitializeComponent();
        }

        //#todo write
        public Form_of_set_and_get(string name_obj , string type_obj, string type_class , string support_interfaces)
        {
            InitializeComponent();
            name_obj_label.Text += name_obj;
            type_obj_label.Text += type_obj;
            type_class_label.Text += type_class;
            support_interface_label.Text += support_interfaces;


        }

        private void Form_of_set_and_get_Load(object sender, EventArgs e)
        {
            //#todo
            error_label.Text = "error";
        }
        private void check_py_button_Click(object sender, EventArgs e)
        {
            checkPython();
        }
        private void checkPython()
        {

            //https://www.codeproject.com/Articles/25983/How-to-Execute-a-Command-in-C
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                                       new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "python --version");

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine("checkPython: " + result);//For debug

                if (result.Contains("Python"))
                {
                    MessageBox.Show("Yes, " + result + "Soon, add feature using it :)", "Feature: Check if python installed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //#todo something to help to install
                    MessageBox.Show("No", "Feature: Check if python installed", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            }
            catch (Exception ex)
            {
                // Log the exception
                MessageBox.Show(ex.Message, "checkPython", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveExceptionToFile(ex.Message + " from checkPython");
            }

        }
        //#todo later improve to CSV
        private void saveExceptionToFile(string ex)
        {
            using (var writer = File.AppendText("LogFile.txt"))
            {
                writer.WriteLine(DateTime.Now.ToString() + " | " + ex);
            }
        }
        private void about_button_Click(object sender, EventArgs e)
        {
            AboutBox_Form form = new AboutBox_Form();
            form.Show();
        }
        private void Start_simulation_button_Click(object sender, EventArgs e)
        {
            //At the beginning of the simulation we hide the shapes in order not to confuse the user
            class_label.Visible = false;
            interfaces_label.Visible = false;
            arrow_pictureBox.Visible = false;
   
            check_py_button.Visible = true;
        }

        private void class_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void interfaces_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void class_members_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(object_checkedListBox.CheckedItems[0].ToString(), "object_checkedListBox_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);//For debug

            access_modifier_checkedListBox.Items.Clear();

            // Determine if there are any items (objects) checked.  
            if (class_members_checkedListBox.CheckedItems.Count == 1)
            {
                if (class_members_checkedListBox.CheckedItems[0].ToString().Equals("Computer"))
                {
                    /*
                    PC
                    Laptop
                    */
                    access_modifier_checkedListBox.Items.Add("PC");
                    access_modifier_checkedListBox.Items.Add("Laptop");

                }
                else if (class_members_checkedListBox.CheckedItems[0].ToString().Equals("Car"))
                {
                    /*
                    Electric car
                    Gasoline cars
                    Hybrid cars
                    */
                    access_modifier_checkedListBox.Items.Add("Electric car");
                    access_modifier_checkedListBox.Items.Add("Gasoline car");
                    access_modifier_checkedListBox.Items.Add("Hybrid car");
                }
            }
            else
            {
                //#todo try to decrese codes of add
                //class_checkedListBox.Items.Clear();
                access_modifier_checkedListBox.Items.Add("PC");
                access_modifier_checkedListBox.Items.Add("Laptop");
                access_modifier_checkedListBox.Items.Add("Electric car");
                access_modifier_checkedListBox.Items.Add("Gasoline car");
                access_modifier_checkedListBox.Items.Add("Hybrid car");
            }
        }
    }
}