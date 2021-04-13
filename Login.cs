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
    public partial class Login : Form
    {
        MainForm _parent;

        public Login(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1)
                return;

            _parent.CurrentUser = (int)comboBox1.SelectedValue;
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A0A72F_TestDBDataSet.ChatUsers' table. You can move, or remove it, as needed.
            this.chatUsersTableAdapter.Fill(this.dB_A0A72F_TestDBDataSet.ChatUsers);

        }
    }
}
