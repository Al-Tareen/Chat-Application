using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class MainForm : Form
    {

        public int CurrentUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A0A72F_TestDBDataSet.ChatUsers' table. You can move, or remove it, as needed.
            this.chatUsersTableAdapter.Fill(this.dB_A0A72F_TestDBDataSet.ChatUsers);
            Login login = new Login(this);
            login.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewChat newChat = new NewChat(this);
            newChat.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshChat();


        }

        private void RefreshChat()
        {

            //TODO: Update the textbox to only see messages from a certain user

            chatApplicationTableAdapter1.FillByTwoUsers(dB_A0A72F_TestDBDataSet.ChatApplication, CurrentUser, (int)comboBox1.SelectedValue);



            //Gets the name of the person based on their ID

            string MyName = chatUsersTableAdapter.GetUserName(CurrentUser);

            string ChattingWith = chatUsersTableAdapter.GetUserName((int)comboBox1.SelectedValue);


            //Output to be saved to textbox

            string output = string.Empty;


            foreach (var row in dB_A0A72F_TestDBDataSet.ChatApplication)
            {


                //Get the values from the dataset

                string Message = row[3].ToString();

                string Date = row[4].ToString();

                int To = (int)row[1];

                int From = (int)row[2];



                //Only add a newline if it's not the first entry

                if (output != string.Empty)
                {
                    output += "\r\n\r\n";
                }



                //Start with the date

                output += Date + "-";



                //Output who the message is from - we can ignore the "TO" person as it's obviously to the other person in the chat
                if (From == CurrentUser)
                {
                    output += MyName;
                }
                else
                {
                    output += ChattingWith;
                }

                //Output the message
                output += "\t" + Message;
            }

            //Make sure to save our output to the multiline textbox!
            textBox1.Text = output;

            //Add a label to show when our data was last updated

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




