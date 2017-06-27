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
    public partial class EditSkills : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public EditSkills()
        {
            InitializeComponent();
        }

        public EditSkills(string s, string c)
        {
            InitializeComponent();
            label1.Text = s;
            label3.Text = c;
        }

        private void EditSkills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursesDataSet.Skills' table. You can move, or remove it, as needed.
            this.skillsTableAdapter.Fill(this.coursesDataSet.Skills);

            // TODO: This line of code loads data into the 'coursesDataSet.v_CourseSkills' table. You can move, or remove it, as needed.
            this.v_CourseSkillsTableAdapter.FillBy(this.coursesDataSet.v_CourseSkills, Convert.ToInt32(label3.Text));

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"insert into CourseSkill(SkillID, CourseID) 
                                    values('" + skillsCmb.SelectedValue + "', '" + label3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно добавени данни!");
                EditSkills srch = new EditSkills(label1.Text, label3.Text);
                srch.MdiParent = this.MdiParent;
                srch.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show($"{skillsCmb.Text} вече съществува!");
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
                    cmd.CommandText = @"DELETE from CourseSkill 
                    WHERE SkillID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND CourseID = '" + label3.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Успешно изтрити данни!");
                    EditSkills srch = new EditSkills(label1.Text, label3.Text);
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
