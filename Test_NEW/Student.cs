using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace EducationForm
{
    public partial class Student : Form
    {
        private SqlConnection sql_connection = null;

        public Student()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private string GetAllQuestions()
        {
            StringBuilder string_builder = new StringBuilder();
            SqlConnectionStringBuilder sql_connection_builder = new SqlConnectionStringBuilder();
       
            try
            {
                using (SqlConnection sql_connection = new SqlConnection())
                {
                    sql_connection.ConnectionString = sql_connection_builder.ConnectionString;
                    sql_connection.Open();
                    using (SqlCommand cmd_practice = new SqlCommand($"SELECT question FROM questions", sql_connection))
                    {
                        using (SqlDataReader data_reader = cmd_practice.ExecuteReader())
                        {
                            while (data_reader.Read())
                            {
                                string_builder.AppendLine(data_reader.GetString(Convert.ToInt16(txt_question)));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return string_builder.ToString();
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {

            DataTable table_all = new DataTable();
            DataTable table_right_answer = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command_select = new SqlCommand("SELECT * FROM questions", sql_connection);

            String question_string = txt_question.Text.ToLower().Trim();
            String answer_string = txt_answer.Text.ToLower().Trim();
            SqlCommand command_right_answer = new SqlCommand("SELECT question, answer FROM questions WHERE question = @quest AND answer = @ans", sql_connection);

            command_right_answer.Parameters.Add("@quest", SqlDbType.VarChar).Value = question_string;
            command_right_answer.Parameters.Add("@ans", SqlDbType.VarChar).Value = answer_string;

            adapter.SelectCommand = command_right_answer;
            adapter.Fill(table_right_answer);

            adapter.SelectCommand = command_select;
            adapter.Fill(table_all);

            if (table_right_answer.Rows.Count > 0)
            {
                MessageBox.Show("Вы ответили верно!");
                txt_question.Text = null;
                txt_question.Text = GetAllQuestions();
            }

            else
                MessageBox.Show("Нужно подумать еще");
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

