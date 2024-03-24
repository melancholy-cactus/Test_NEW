using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Test_NEW
{
    public partial class Admin : Form
    {
        private SqlConnection sql_connection = null;

        private List<string[]> rows = null;
        private List<string[]> filtered_list = null;

        public Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_DB"].ConnectionString);
            sql_connection.Open();

            SqlDataReader data_reader = null;

            rows = new List<string[]>();

            string[] row = null;

            try
            {

                SqlCommand cmd_select = new SqlCommand(
                    "SELECT question, answer, prompt, version, id  FROM questions", 
                    sql_connection);

                data_reader = cmd_select.ExecuteReader();

                while (data_reader.Read())
                {
                    row = new string[] 
                    {   
                        Convert.ToString(data_reader["question"]),
                        Convert.ToString(data_reader["answer"]),
                        Convert.ToString(data_reader["prompt"]),
                        Convert.ToString(data_reader["version"]),
                        Convert.ToString(data_reader["id"])
                    };

                    rows.Add(row);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (data_reader != null && !data_reader.IsClosed)
                {
                    data_reader.Close();
                }

            }

            refresh_list(rows);

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_insert = new SqlCommand(
                $"INSERT INTO questions (question, answer, prompt, version) VALUES (@question, @answer, @prompt, @version)",
                sql_connection);
            cmd_insert.Parameters.AddWithValue("question", txt_question.Text);
            cmd_insert.Parameters.AddWithValue("answer", txt_answer.Text);
            cmd_insert.Parameters.AddWithValue("prompt", txt_prompt.Text);
            cmd_insert.Parameters.AddWithValue("version", txt_version.Text);

            MessageBox.Show("Добавлено " + cmd_insert.ExecuteNonQuery().ToString() + " строк");
        }

        private void refresh_list(List<string[]> list)
        {
            list_view.Items.Clear();

            foreach (string[] s in list) 
            {
                list_view.Items.Add(new ListViewItem(s));
            }
        }

        private void box_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (box_filter.SelectedIndex)
            {
                case 0:

                    filtered_list = rows.Where((x) =>
                    Int16.Parse(x[3]) == 1).ToList();

                    refresh_list(filtered_list);

                    break; 

                case 1:
                    filtered_list = rows.Where((x) =>
                    Int16.Parse(x[3]) == 2).ToList();

                    refresh_list(filtered_list);

                    break;

                case 2:
                    refresh_list(rows);
                    break; 
            }
        }
    }
}
