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
    public partial class SearchProfessionalField : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public SearchProfessionalField()
        {
            InitializeComponent();
        }

        private bool searchBtnWasClicked = false;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtnWasClicked = true;
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            search.CommandText = "SELECT * from ProfessionalField where Name like '%" + ProfesionalField1.Text + "%' order by ProfessionalFieldID";
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
            ProfesionalField1.Clear();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ProfesionalField2.Visible == false)
            {
                ProfesionalField2.Visible = true;
                editBtn.Visible = true;
                ProfesionalField2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

            if (ProfesionalField1.Text == "")
            {
                ProfesionalField1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from ProfessionalField order by ProfessionalFieldID";
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long n = 1;
                double m = 1.0;
                if (long.TryParse(ProfesionalField2.Text, out n) && double.TryParse(ProfesionalField2.Text, out m))
                {
                    MessageBox.Show("Не може да се добавят числови данни!");
                    return;
                }
                if (ProfesionalField1.Text == "" && ProfesionalField2.Visible == true)
                {
                    MessageBox.Show("Невалидни данни!");
                    ProfesionalField2.Visible = false;
                    editBtn.Visible = false;
                    return;
                }
                if (ProfesionalField2.Visible == true)
                {
                    con.Open();
                    SqlCommand search = con.CreateCommand();
                    search.CommandType = CommandType.Text;
                    search.CommandText = "UPDATE ProfessionalField set Name = '" + ProfesionalField2.Text + "' where Name = '" + ProfesionalField1.Text + "'";
                    search.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно обновяване!");
                    ProfesionalField2.Visible = false;
                    editBtn.Visible = false;
                    ProfesionalField1.Clear();
                    Display();
                }
            }
            catch
            {
                MessageBox.Show("Не може еднa професионална област\r\n да се повтаря повече от веднъж!");
            }
        }

        private bool addBtnWasClicked = false;

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ProfesionalField1.Text == "")
                {
                    MessageBox.Show("Невалидни данни!");
                    return;
                }

                long n = 1;
                double m = 1.0;
                if (!long.TryParse(ProfesionalField1.Text, out n) && !double.TryParse(ProfesionalField1.Text, out m))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into ProfessionalField values('" + ProfesionalField1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно добавени данни!");
                    ProfesionalField2.Visible = false;
                    ProfesionalField1.Clear();
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
                MessageBox.Show($"{ProfesionalField1.Text} вече съществува!");
                con.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
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
                        cmd.CommandText = "DELETE from ProfessionalField where ProfessionalFieldID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Успешно изтрити данни!");
                        ProfesionalField2.Visible = false;
                        ProfesionalField1.Clear();
                        Display();
                    }
                }
                else
                {
                    MessageBox.Show("Невалидна команда!");
                    return;
                }                    
            }
            catch
            {
                MessageBox.Show("Невалидни данни!");
            }
        }

    }
}


