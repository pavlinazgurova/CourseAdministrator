using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseAdministrator
{
    public partial class SearchSkills : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public SearchSkills()
        {
            InitializeComponent();
        }

        private void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Skills order by SkillID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            con.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Skill2.Visible == false)
            {
                Skill2.Visible = true;
                editBtn.Visible = true;
                Skill2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

            if (Skill1.Text == "")
            {
                Skill1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private bool searchBtnWasClicked = false;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtnWasClicked = true;
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            search.CommandText = "SELECT * from Skills where Name like '%" + Skill1.Text + "%' order by SkillID";
            search.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(search);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            con.Close();
            Skill1.Clear();
        }



        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long n = 1;
                double m = 1.0;
                if (long.TryParse(Skill2.Text, out n) && double.TryParse(Skill2.Text, out m))
                {
                    MessageBox.Show("Не може да се добавят числови данни!");
                    return;
                }
                if (Skill1.Text == "" && Skill2.Visible == true)
                {
                    MessageBox.Show("Невалидни данни!");
                    Skill2.Visible = false;
                    editBtn.Visible = false;
                    return;
                }
                else
                {
                    con.Open();
                    SqlCommand search = con.CreateCommand();
                    search.CommandType = CommandType.Text;
                    search.CommandText = "UPDATE Skills set Name = '" + Skill2.Text + "' where Name = '" + Skill1.Text + "'";
                    search.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно обновяване!");
                    Skill2.Visible = false;
                    editBtn.Visible = false;
                    Skill1.Clear();
                    Display();
                }
            }
            catch
            {
                MessageBox.Show("Не може едно умение да се повтаря повече от веднъж!");
            }
        }

        private bool addBtnWasClicked = false;

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Skill1.Text == "")
                {
                    MessageBox.Show("Невалидни данни!");
                    return;
                }

                long n = 1;
                double m = 1.0;

                if (!long.TryParse(Skill1.Text, out n) && !double.TryParse(Skill1.Text, out m))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into Skills values('" + Skill1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно добавени данни!");
                    Skill2.Visible = false;
                    Skill1.Clear();
                    Display();
                    addBtnWasClicked = true;
                }
                else
                {
                    MessageBox.Show("Не може да се добавят числови данни!");
                }
            }
            catch
            {
                MessageBox.Show($"{Skill1.Text} вече съществува!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (searchBtnWasClicked == true || addBtnWasClicked == true)
            {
                var confirmResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?",
                                     "Потвърждение!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE from Skills where SkillID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно изтрити данни!");
                    Skill2.Visible = false;
                    Skill1.Clear();
                    Display();
                }
            }
            else
            {
                MessageBox.Show("Невалидна команда!");
                return;
            }
        }
    }
}
