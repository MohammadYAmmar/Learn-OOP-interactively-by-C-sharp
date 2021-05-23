using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learn_OOP_interactively_by_C_sharp.Enum;

/*
The start of work on the project on the date of 13/5/2021, on the first day of Eid al-Fitr
The work by eng. Muhammad Yaser Ammar | https://github.com/MohammadYAmmar/

It took 15.20 hours to work, depending on the app Forest - (Stay focused, be present) 🌲 #todo update time

Versions:
V1 beta @ 16-5-2021
V2 beta @ ??-5-2021 #todo

Tasks:
V1 beta: 
- Complementing the infrastructure work of the project ✔
- Linking checked list box ✔
- Complete linking codes ✔
- Link interface ✔
- check todo in the comment ✔
- Using an Enum with OOP ✔ [ New learn and implement ]
- A way to find out where the code has arrived ⏳ accessLevel?
- A way to generate a new class with specs by user ⏳
- Folder for pictures ✔⏳
- Linking pictures and by default, they are all hidden ✔
- Logfile records catch exceptions ✔ [ New learn and implement ] 
- Link with python if in the device ✔ [ New learn and implement ]
- A way to Run python program ⏳ [ New learn and implement ]
- Merge with python program, I think need to be .exe file ⏳ [ New learn and implement ]
- Some conditions to select in a checked list box ✔
- Button of check python if available ✔
- Program information interface ✔
- Check todo in the comment ✔
- Create new repo to publish ✔
V2 beta: 
- Implementing the idea of assigning values to the variable based on the authorities ⏳
- New Form of idea ✔
- Push to repo for publish ✔
V3 beta: 
- Create an idea to link and check if public, private, and protected ⏳
- Button to move to another form ✔
- Solve Property_checkedListBox_SelectedIndexChanged
- Push to repo for publish 🧩
- Quiz 
- Button to close program then window to my account to follow :) 
- Interface to open the learning program
- Check todo in the comment
- Logfile records catch exceptions [ New learn and implement ]| improve to CSV
- Sound if enable or not
- Design UX for the program [ After reading book 📕 ]

*/

namespace Learn_OOP_interactively_by_C_sharp
{
    public partial class Form_OOP : Form
    {
        //#todo wirte
        //#todo complete work
        Object lastObj;
        public Form_OOP()
        {
            InitializeComponent();
        }

        private void Form_OOP_Load(object sender, EventArgs e)
        {
        }

        private void Start_simulation_button_Click(object sender, EventArgs e)
        {
            //At the beginning of the simulation we hide the shapes in order not to confuse the user
            class_label.Visible = false;
            interfaces_label.Visible = false;
            arrow_pictureBox.Visible = false;


            // get_info_from_checkedListBox();
            string[] info_checkedListBox = get_info_from_checkedListBox();

            // accessing array elements
            Console.WriteLine("Start_simulation_button_Click " + info_checkedListBox[0] + " " + info_checkedListBox[1] + " " + info_checkedListBox[2]); // For debug
            //MessageBox.Show(info_checkedListBox[0] + " " + info_checkedListBox[1] + " " + info_checkedListBox[2]);// For debug


            Writing_on_shapes(info_checkedListBox);


            check_py_button.Visible = true;


            //Test , #todo review
            //class_listView.Items.AsParallel //#todo what that?
            //class_listView.Items.Add("Test");

            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.checkedlistbox?view=net-5.0
            //string[] myFruit = { "Apples", "Oranges", "Tomato" };
            //checkedListBox1.Items.Clear();
            //checkedListBox1.Items.AddRange(myFruit);


            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-determine-checked-items-in-the-windows-forms-checkedlistbox-control?view=netframeworkdesktop-4.8
            // Determine if there are any items checked.  
            //if (object_checkedListBox.CheckedItems.Count != 0)
            //{
            //    // If so, loop through all checked items and print results.  
            //    string s = "";
            //    for (int x = 0; x < object_checkedListBox.CheckedItems.Count; x++)
            //    {
            //        s = s + "Checked Item " + (x + 1).ToString() + " = " + object_checkedListBox.CheckedItems[x].ToString() + "\n";
            //    }
            //    MessageBox.Show(s);
            //}
        }

        private string[] get_info_from_checkedListBox()
        {
            string[] info_checkedListBox = new string[3] { string.Empty, string.Empty, string.Empty };


            // Determine if there are any items (objects) checked.  
            if (object_checkedListBox.CheckedItems.Count == 0 || class_checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please choose a type for object and class ", "get_info_from_checkedListBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveExceptionToFile("Please choose a type for object and class" + " from get_info_from_checkedListBox");
                return info_checkedListBox;
            }
            else if (object_checkedListBox.CheckedItems.Count == 1 && class_checkedListBox.CheckedItems.Count == 1)
            {
                //MessageBox.Show(class_checkedListBox.CheckedItems[0].ToString());

                //Check if the user chooses interface 
                string temp_interface = "";
                if (interface_checkedListBox.CheckedItems.Count >= 1)
                {
                    for (int x = 0; x < interface_checkedListBox.CheckedItems.Count; x++)
                    {
                        temp_interface = temp_interface + interface_checkedListBox.CheckedItems[x].ToString() + " ";
                    }
                }


                info_checkedListBox = new string[3] { object_checkedListBox.CheckedItems[0].ToString(),
                    class_checkedListBox.CheckedItems[0].ToString(),
                    temp_interface };

                return info_checkedListBox;
            }
            else if (object_checkedListBox.CheckedItems.Count > 1 || class_checkedListBox.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please choose one type for type of object and class", "get_info_from_checkedListBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveExceptionToFile("Please choose a type for object and class" + " from get_info_from_checkedListBox");
                return info_checkedListBox;

            }
            else
            {
                return info_checkedListBox;
            }

        }

        //Not need ; DRY: Don't repeat yourself  
        //private string get_type_class()
        //{

        //    // Determine if there are any items (objects) checked.  
        //    if (object_checkedListBox.CheckedItems.Count == 0)
        //    {
        //        MessageBox.Show("Please choose a type for the class", "type_class", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return "";
        //    }
        //    else if (object_checkedListBox.CheckedItems.Count == 1)
        //    {
        //        MessageBox.Show(object_checkedListBox.CheckedItems[0].ToString());

        //        return object_checkedListBox.CheckedItems[0].ToString();
        //    }
        //    else if (object_checkedListBox.CheckedItems.Count > 1)
        //    {
        //        MessageBox.Show("Please choose one type for the class", "type_class", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return "";

        //    }
        //    else
        //    {
        //        return "";
        //    }

        //}


        private void Writing_on_shapes(string[] info_checkedListBox)
        {
            try
            {
                if ((info_checkedListBox[0].Equals(string.Empty) && info_checkedListBox[1].Equals(string.Empty)) == false)
                {
                    objects_listView.Items.Add(info_checkedListBox[0] + ": (" + name_obj_textBox.Text + ")");
                    class_listView.Items.Add(info_checkedListBox[1]);
                    //if (info_checkedListBox[2].Equals(string.Empty) == false)
                    //{
                    interfaces_listView.Items.Add(info_checkedListBox[2]);
                    //}
                    //#Method to created object from a class.
                    createObject(name_obj_textBox.Text, info_checkedListBox[0], info_checkedListBox[1], info_checkedListBox[2]);


                    //Enable the label in picture
                    class_label.Visible = true;
                    interfaces_label.Visible = true;
                    //Set label with specfic value
                    class_label.Text = info_checkedListBox[0];
                    interfaces_label.Text = info_checkedListBox[2].Replace(" ", "\n");

                    //Enable the arrow if have interface
                    if (info_checkedListBox[2].Contains("Sale") || info_checkedListBox[2].Contains("Maintenance"))
                    {
                        arrow_pictureBox.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Writing_on_shapes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message + "from Writing_on_shapes");//for debug
                saveExceptionToFile(ex.Message + " from Writing_on_shapes");
            }


        }
        public void createObject(string Obj, string Type, string Class, string Interfaces)
        {

            if (Type.Equals("Computer"))
            {
                if (Class.Equals("PC"))
                {
                    //MessageBox.Show(Obj + " " + Type + " " + Class + " " + Interfaces);

                    if (Interfaces.Equals("Maintenance") && Interfaces.Equals("Sale"))
                    {
                        PC obj = new PC();
                        obj.accessLevel = Range_sequence_OOP.Interface;
                        MessageBox.Show(obj.accessLevel.ToString());//to debug
                    }
                    else if (Interfaces.Equals("Maintenance"))
                    {
                        //#TODO make with smart wat
                        PC_IMaintenance obj = new PC_IMaintenance();
                        obj.accessLevel = Range_sequence_OOP.Interface;
                        MessageBox.Show(obj.accessLevel.ToString());//to debug
                    }

                    //PC obj = new PC();
                    ////https://stackoverflow.com/questions/410227/test-if-object-implements-interface
                    //if (obj is Maintenance)
                    //{
                    //    //MessageBox.Show("I");
                    //    obj.accessLevel = Range_sequence_OOP.Interface;
                    //}

                }
                else if (Class.Equals("Laptop"))
                {
                    //MessageBox.Show(Obj + " " + Type + " " + Class + " " + Interfaces);
                    Laptop obj = new Laptop();

                    //#todo complete work to all
                    lastObj = obj;
                }
                //MessageBox.Show(Obj + " " + Type + " " + Class + " " + Interfaces);
            }
            else if (Type.Equals("Car"))
            {
                //#todo complete
                //MessageBox.Show(Obj + " " + Type + " " + Class + " " + Interfaces);

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


//#todo complete
        private void object_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_checkedListBox.Items.Clear();
            //MessageBox.Show(object_checkedListBox.CheckedItems[0].ToString(), "object_checkedListBox_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);//For debug

            // Determine if there are any items (objects) checked.  
            if (object_checkedListBox.CheckedItems.Count == 1)
            {
                //object_checkedListBox.CheckedItems[0]
            }
            if (object_checkedListBox.CheckedItems[0].ToString().Equals("Computer"))
            {
                /*
                PC
                Laptop
                */
                class_checkedListBox.Items.Add("PC");
                class_checkedListBox.Items.Add("Laptop");

            }
            else if (object_checkedListBox.CheckedItems[0].ToString().Equals("Car"))
            {
                /*
                Electric car
                Gasoline cars
                Hybrid cars
                */
                class_checkedListBox.Items.Add("Electric car");
                class_checkedListBox.Items.Add("Gasoline car");
                class_checkedListBox.Items.Add("Hybrid car");
            }
        
            else
            {
                //#todo try to decrese codes of add
                //class_checkedListBox.Items.Clear();
                class_checkedListBox.Items.Add("PC");
                class_checkedListBox.Items.Add("Laptop");
                class_checkedListBox.Items.Add("Electric car");
                class_checkedListBox.Items.Add("Gasoline car");
                class_checkedListBox.Items.Add("Hybrid car");
            }

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
                    MessageBox.Show("Yes, " + result +"Soon, add feature using it :)", "Feature: Check if python installed", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void about_button_Click(object sender, EventArgs e)
        {
            AboutBox_Form form = new AboutBox_Form();
            form.Show();
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

        private void Access_Modifiers_button_Click(object sender, EventArgs e)
        {
            //string name_obj, string type_obj, string type_class, string support_interfaces
            Form_Access_Modifiers window = new Form_Access_Modifiers(lastObj , name_obj_textBox.Text);
            window.Show();
        }
    }
}
