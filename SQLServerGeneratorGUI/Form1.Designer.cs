namespace SQLServerGeneratorGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_server = new System.Windows.Forms.TextBox();
            this.input_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_sql = new System.Windows.Forms.DataGridView();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_databases = new System.Windows.Forms.ComboBox();
            this.button_savetofile = new System.Windows.Forms.Button();
            this.button_savetoclipboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sql)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // input_server
            // 
            this.input_server.Location = new System.Drawing.Point(82, 6);
            this.input_server.Name = "input_server";
            this.input_server.Size = new System.Drawing.Size(146, 20);
            this.input_server.TabIndex = 1;
            // 
            // input_username
            // 
            this.input_username.Location = new System.Drawing.Point(82, 32);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(146, 20);
            this.input_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(82, 58);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(146, 20);
            this.input_password.TabIndex = 5;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // dataGridView_sql
            // 
            this.dataGridView_sql.AllowUserToAddRows = false;
            this.dataGridView_sql.AllowUserToDeleteRows = false;
            this.dataGridView_sql.AllowUserToResizeRows = false;
            this.dataGridView_sql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sql.Location = new System.Drawing.Point(12, 85);
            this.dataGridView_sql.Name = "dataGridView_sql";
            this.dataGridView_sql.ShowEditingIcon = false;
            this.dataGridView_sql.Size = new System.Drawing.Size(798, 425);
            this.dataGridView_sql.TabIndex = 6;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(688, 11);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(122, 29);
            this.button_connect.TabIndex = 7;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // comboBox_databases
            // 
            this.comboBox_databases.FormattingEnabled = true;
            this.comboBox_databases.Location = new System.Drawing.Point(664, 57);
            this.comboBox_databases.Name = "comboBox_databases";
            this.comboBox_databases.Size = new System.Drawing.Size(146, 21);
            this.comboBox_databases.TabIndex = 8;
            this.comboBox_databases.SelectedIndexChanged += new System.EventHandler(this.ComboBox_databases_SelectedIndexChanged);
            // 
            // button_savetofile
            // 
            this.button_savetofile.Location = new System.Drawing.Point(706, 515);
            this.button_savetofile.Name = "button_savetofile";
            this.button_savetofile.Size = new System.Drawing.Size(104, 35);
            this.button_savetofile.TabIndex = 9;
            this.button_savetofile.Text = "Save to file";
            this.button_savetofile.UseVisualStyleBackColor = true;
            this.button_savetofile.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_savetoclipboard
            // 
            this.button_savetoclipboard.Location = new System.Drawing.Point(596, 515);
            this.button_savetoclipboard.Name = "button_savetoclipboard";
            this.button_savetoclipboard.Size = new System.Drawing.Size(104, 35);
            this.button_savetoclipboard.TabIndex = 10;
            this.button_savetoclipboard.Text = "Save to clipboard";
            this.button_savetoclipboard.UseVisualStyleBackColor = true;
            this.button_savetoclipboard.Click += new System.EventHandler(this.Button_savetoclipboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_savetoclipboard);
            this.Controls.Add(this.button_savetofile);
            this.Controls.Add(this.comboBox_databases);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.dataGridView_sql);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_server);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlScriptGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_server;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_sql;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ComboBox comboBox_databases;
        private System.Windows.Forms.Button button_savetofile;
        private System.Windows.Forms.Button button_savetoclipboard;
        private System.Windows.Forms.Label label4;
    }
}

