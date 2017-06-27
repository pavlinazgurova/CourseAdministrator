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
    public partial class SearchPositions : Form
    {
        SqlConnection con = new SqlConnection
            (@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");

        public SearchPositions()
        {
            InitializeComponent();
        }

        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Positions order by PositionID";
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
            if (position2.Visible == false)
            {
                position2.Visible = true;
                editBtn.Visible = true;
                position2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

            if (position1.Text == "")
            {
                position1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private bool searchBtnWasClicked = false;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtnWasClicked = true;
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            search.CommandText = "SELECT * from Positions where Name like '%" + position1.Text + "%' order by PositionID";
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
            position1.Clear();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long n = 1;
                double m = 1.0;
                if (long.TryParse(position2.Text, out n) && double.TryParse(position2.Text, out m))
                {
                    MessageBox.Show("Не може да се добавят числови данни!");
                    return;
                }

                if (position2.Visible == true)
                {
                    con.Open();
                    SqlCommand search = con.CreateCommand();
                    search.CommandType = CommandType.Text;
                    search.CommandText = "UPDATE Positions set Name = '" + position2.Text + "' where Name = '" + position1.Text + "'";
                    search.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно обновяване!");
                    position2.Visible = false;
                    editBtn.Visible = false;
                    position1.Clear();
                    display();
                }
                else
                {
                    MessageBox.Show("Невалидни данни!");
                }
            }
            catch
            {
                MessageBox.Show("Невалидни данни!");
            }

        }

        private bool addBtnWasClicked = false;

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                addBtnWasClicked = true;

                if (position1.Text == "")
                {
                    MessageBox.Show("Невалидни данни!");
                    return;
                }

                long n = 1;
                double m = 1.0;

                if (!long.TryParse(position1.Text, out n) && !double.TryParse(position1.Text, out m))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into Positions values('" + position1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно добавени данни!");
                    position2.Visible = false;
                    position1.Clear();
                    display();
                }
                else
                {
                    MessageBox.Show("Не може да се добавят числови данни!");
                }
            }
            catch
            {
                MessageBox.Show($"{position1.Text} вече съществува!");
                con.Close();
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
                    cmd.CommandText = "DELETE from Positions where PositionID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно изтрити данни!");
                    position2.Visible = false;
                    position1.Clear();
                    display();
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

