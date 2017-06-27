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
    public partial class EditProfesionalField : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public EditProfesionalField()
        {
            InitializeComponent();
        }

        public EditProfesionalField(string s, String c)
        {
            InitializeComponent();
            label1.Text = s;
            label3.Text = c;
        }

        private void EditProfesionalField_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursesDataSet1.ProfessionalField' table. You can move, or remove it, as needed.
            this.professionalFieldTableAdapter.Fill(this.coursesDataSet1.ProfessionalField);

            // TODO: This line of code loads data into the 'coursesDataSet1.v_CourseProfessionalField' table. You can move, or remove it, as needed.
            this.v_CourseProfessionalFieldTableAdapter.FillByProfessionalField(this.coursesDataSet1.v_CourseProfessionalField, Convert.ToInt32(label3.Text));           
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"insert into CourseProfessionalField(ProfessinalFieldID, CourseID) 
                                    values('" + profFieldCmb.SelectedValue + "', '" + label3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно добавени данни!");
                EditProfesionalField srch = new EditProfesionalField(label1.Text, label3.Text);
                srch.MdiParent = this.MdiParent;
                srch.Show();
                this.Hide();

            }
            catch 
            {
                MessageBox.Show($"{profFieldCmb.Text} вече съществува!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?",
                                        "Потвърждение!!",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE from CourseProfessionalField WHERE ProfessinalFieldID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND CourseID = '" + label3.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно изтрити данни!");
                    EditProfesionalField srch = new EditProfesionalField(label1.Text, label3.Text);
                    srch.MdiParent = this.MdiParent;
                    srch.Show();
                    this.Hide();
                }
            }
            catch 
            {
                MessageBox.Show("Невалидна команда!");
            }
        }
    }
}
