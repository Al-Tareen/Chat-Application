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
    public partial class NewChat : Form
    {
        MainForm _parent;

        public NewChat(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1)
                return;

            string CurrentTime = DateTime.Now.ToString();
            int MessageFrom = _parent.CurrentUser;

            //TODO: Finish this section
            //You need to send the data to the database






            this.Close();
        }
    }
}
