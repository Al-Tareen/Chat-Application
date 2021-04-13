namespace ChatApplication
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chatUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A0A72F_TestDBDataSet = new ChatApplication.DB_A0A72F_TestDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chatUsersTableAdapter = new ChatApplication.DB_A0A72F_TestDBDataSetTableAdapters.ChatUsersTableAdapter();
            this.tableAdapterManager1 = new ChatApplication.DB_A0A72F_TestDBDataSetTableAdapters.TableAdapterManager();
            this.chatApplicationTableAdapter1 = new ChatApplication.DB_A0A72F_TestDBDataSetTableAdapters.ChatApplicationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chatUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A0A72F_TestDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(729, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chatUsersBindingSource;
            this.comboBox1.DisplayMember = "UserName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "UserID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chatUsersBindingSource
            // 
            this.chatUsersBindingSource.DataMember = "ChatUsers";
            this.chatUsersBindingSource.DataSource = this.dB_A0A72F_TestDBDataSet;
            // 
            // dB_A0A72F_TestDBDataSet
            // 
            this.dB_A0A72F_TestDBDataSet.DataSetName = "DB_A0A72F_TestDBDataSet";
            this.dB_A0A72F_TestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "See messages from...";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(17, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(724, 377);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chatUsersTableAdapter
            // 
            this.chatUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlPersonTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BeverlyPersonTableAdapter = null;
            this.tableAdapterManager1.ChatApplicationTableAdapter = null;
            this.tableAdapterManager1.ChatUsersTableAdapter = this.chatUsersTableAdapter;
            this.tableAdapterManager1.CourseInstructorTableAdapter = null;
            this.tableAdapterManager1.CourseTableAdapter = null;
            this.tableAdapterManager1.DepartmentTableAdapter = null;
            this.tableAdapterManager1.DoggiesTableAdapter = null;
            this.tableAdapterManager1.JunaidTableAdapter = null;
            this.tableAdapterManager1.KenMc__Social_MediaTableAdapter = null;
            this.tableAdapterManager1.LissettePersonTableAdapter = null;
            this.tableAdapterManager1.MonicaLeeTableAdapter = null;
            this.tableAdapterManager1.New_SoMedTableAdapter = null;
            this.tableAdapterManager1.OfficeAssignmentTableAdapter = null;
            this.tableAdapterManager1.OnlineCourseTableAdapter = null;
            this.tableAdapterManager1.OnsiteCourseTableAdapter = null;
            this.tableAdapterManager1.PetOwnerTableAdapter = null;
            this.tableAdapterManager1.PetsTableAdapter = null;
            this.tableAdapterManager1.StudentGradeTableAdapter = null;
            this.tableAdapterManager1.StudentPeopleTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ChatApplication.DB_A0A72F_TestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chatApplicationTableAdapter1
            // 
            this.chatApplicationTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 526);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chatUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A0A72F_TestDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DB_A0A72F_TestDBDataSet dB_A0A72F_TestDBDataSet;
        private System.Windows.Forms.BindingSource chatUsersBindingSource;
        private DB_A0A72F_TestDBDataSetTableAdapters.ChatUsersTableAdapter chatUsersTableAdapter;
        private DB_A0A72F_TestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DB_A0A72F_TestDBDataSetTableAdapters.ChatApplicationTableAdapter chatApplicationTableAdapter1;
    }
}

