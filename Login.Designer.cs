namespace ChatApplication
{
    partial class Login
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dB_A0A72F_TestDBDataSet = new ChatApplication.DB_A0A72F_TestDBDataSet();
            this.dBA0A72FTestDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatUsersTableAdapter = new ChatApplication.DB_A0A72F_TestDBDataSetTableAdapters.ChatUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A0A72F_TestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA0A72FTestDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chatUsersBindingSource;
            this.comboBox1.DisplayMember = "UserName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dB_A0A72F_TestDBDataSet
            // 
            this.dB_A0A72F_TestDBDataSet.DataSetName = "DB_A0A72F_TestDBDataSet";
            this.dB_A0A72F_TestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBA0A72FTestDBDataSetBindingSource
            // 
            this.dBA0A72FTestDBDataSetBindingSource.DataSource = this.dB_A0A72F_TestDBDataSet;
            this.dBA0A72FTestDBDataSetBindingSource.Position = 0;
            // 
            // chatUsersBindingSource
            // 
            this.chatUsersBindingSource.DataMember = "ChatUsers";
            this.chatUsersBindingSource.DataSource = this.dBA0A72FTestDBDataSetBindingSource;
            // 
            // chatUsersTableAdapter
            // 
            this.chatUsersTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_A0A72F_TestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA0A72FTestDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dBA0A72FTestDBDataSetBindingSource;
        private DB_A0A72F_TestDBDataSet dB_A0A72F_TestDBDataSet;
        private System.Windows.Forms.BindingSource chatUsersBindingSource;
        private DB_A0A72F_TestDBDataSetTableAdapters.ChatUsersTableAdapter chatUsersTableAdapter;
    }
}