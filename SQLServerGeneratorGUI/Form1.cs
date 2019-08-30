using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerGeneratorGUI
{
    public partial class Form1 : Form
    {
        public static string USERNAME;
        public static string PASSWORD;
        public static string SERVER;
        public static string SELECTED_DATABASE;

        public Form1()
        {
            InitializeComponent();

            comboBox_databases.Enabled = false;
            dataGridView_sql.Enabled = false;
            button_savetoclipboard.Enabled = false;
            button_savetofile.Enabled = false;

            dataGridView_sql.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            comboBox_databases.Enabled = false;
            dataGridView_sql.Enabled = false;
            button_savetoclipboard.Enabled = false;
            button_savetofile.Enabled = false;

            SERVER = input_server.Text;
            USERNAME = input_username.Text;
            PASSWORD = input_password.Text;

            var databases = Utils.GetDatabaseList(SERVER, USERNAME, PASSWORD);
            dataGridView_sql.Rows.Clear();

            if (databases == null)
            {
                MessageBox.Show("Couldn't get databases", "SqlScriptGenerator");
            }
            else
            {
                MessageBox.Show("Databases loaded successfully", "SqlScriptGenerator");

                dataGridView_sql.Rows.Clear();
                comboBox_databases.Items.Clear();
                comboBox_databases.Items.Add("Select database");
                comboBox_databases.Items.AddRange(databases.ToArray());
                comboBox_databases.SelectedIndex = 0;

                comboBox_databases.Enabled = true;
            }
        }

        private void ComboBox_databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_databases.SelectedItem.ToString() == "Select database")
            {
                return;
            }

            try
            {
                SELECTED_DATABASE = comboBox_databases.SelectedItem.ToString();
                var spfuncs = Utils.GetSPandFunctions(SERVER, USERNAME, PASSWORD, SELECTED_DATABASE);

                dataGridView_sql.DataSource = spfuncs;
                dataGridView_sql.Enabled = true;
                button_savetoclipboard.Enabled = true;
                button_savetofile.Enabled = true;

                dataGridView_sql.Columns[0].Width = 50;
                dataGridView_sql.Columns[0].ReadOnly = true;

                dataGridView_sql.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView_sql.Columns[1].ReadOnly = true;

                dataGridView_sql.Columns[2].Width = 100;
                dataGridView_sql.Columns[2].ReadOnly = true;

                dataGridView_sql.Columns[3].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message, "SqlScriptGenerator");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var list = GetData();
            var finalList = new List<string>();
            list.ForEach(x => finalList.AddRange(x));

            if (list.Count == 0)
            {
                MessageBox.Show("No items selected", "SqlScriptGenerator");
            }
            else
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Select where you want to save the generated SQL script";

                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        try
                        {
                            var filename = $"{SELECTED_DATABASE}-queries-{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}.sql";
                            Utils.SaveToFile(Path.Combine(fbd.SelectedPath, filename), finalList);
                            MessageBox.Show("Saved successfully", "SqlScriptGenerator");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was an error: " + ex.Message, "SqlScriptGenerator");
                        }
                    }
                }
            }


        }


        private void Button_savetoclipboard_Click(object sender, EventArgs e)
        {
            var list = GetData();
            var finalString = "";

            foreach (var item in list)
            {
                finalString += string.Join("", item.ToArray());
            }

            if (!String.IsNullOrEmpty(finalString))
            {
                Clipboard.SetText(finalString);
                MessageBox.Show("Copied to clipboard successfully", "SqlScriptGenerator");
            }
            else
            {
                MessageBox.Show("No items selected", "SqlScriptGenerator");
            }
        }

        private List<List<string>> GetData()
        {
            var connectionstring = $"Data Source={SERVER};Initial Catalog={SELECTED_DATABASE};Persist Security Info=True;User ID={USERNAME};Password={PASSWORD};Connect Timeout=60";
            var itemCount = dataGridView_sql.Rows.Count;
            var dataToGenerate = new Dictionary<string, List<string>>();
            var finalList = new List<List<string>>();

            for (int i = 0; i < itemCount; i++)
            {
                var needGeneration = Boolean.Parse(dataGridView_sql.Rows[i].Cells[3].Value.ToString());

                if (needGeneration)
                {
                    var item = $"{dataGridView_sql.Rows[i].Cells[0].Value.ToString()}.{dataGridView_sql.Rows[i].Cells[1].Value.ToString()}";
                    dataToGenerate.Add(item, Utils.GetResultOfFunction(item, connectionstring));
                }
            }

            foreach (var item in dataToGenerate)
            {
                finalList.Add(Utils.GetListToSave(item.Value, item.Key, SELECTED_DATABASE, USERNAME));
            }

            return finalList;
        }
    }
}
