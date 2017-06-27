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
    public partial class Edit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT c.Name, l.NameLevelOfEducation, f.NameFormOfEducation, c.Duration, 
                                            d.NameDepartments, c.Characterization, c.OtherSkills, c.OtherPosition, 
                                            c.OtherProfessionalField
                                            from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
                                            inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
                                            inner join Departments d on c.DepartmentID=d.DepartmentID
                                            where c.CourseID = '" + noTxt.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                nameCTxt.Text = (read["Name"].ToString());
                levelOfCmb.Text = (read["NameLevelOfEducation"].ToString());
                formOfCmb.Text = (read["NameFormOfEducation"].ToString());
                durationTxt.Text = (read["Duration"].ToString());
                departmentsCmb.Text = (read["NameDepartments"].ToString());
                descriptionTxt.Text = (read["Characterization"].ToString());
                skillTxt.Text = (read["OtherSkills"].ToString());
                positionTxt.Text = (read["OtherPosition"].ToString());
                profesionalFieldTxt.Text = (read["OtherProfessionalField"].ToString());
            }
            read.Close();
            con.Close();
        }

        private void LevelOfEducation()
        {
            if (levelOfCmb.Text == "Бакалавър")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set LevelOfEducationID = '" + 1 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (levelOfCmb.Text == "Магистър")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set LevelOfEducationID = '" + 2 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (levelOfCmb.Text == "Доктор")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set LevelOfEducationID = '" + 3 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
        }

        private void FormOfEducation()
        {
            if (formOfCmb.Text == "Редовно")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set FormOfEducationID = '" + 1 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (formOfCmb.Text == "Задочно")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set FormOfEducationID = '" + 2 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
        }

        private void Departments()
        {
            if (departmentsCmb.Text == "Приложна информатика, комуникации и иконометрия")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set DepartmentID = '" + 1 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (departmentsCmb.Text == "Финанси, счетоводство и контрол")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set DepartmentID = '" + 2 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (departmentsCmb.Text == "Администрация и управление")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set DepartmentID = '" + 3 + "' where CourseID = '" + noTxt.Text + "'";
                cmd.ExecuteNonQuery();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            long n = 1;
            if (nameCTxt.Text == "" || levelOfCmb.Text == "" || formOfCmb.Text == "" || durationTxt.Text == "" 
                || departmentsCmb.Text == "" || descriptionTxt.Text == "" || skillTxt.Text == "" || positionTxt.Text == "" 
                || profesionalFieldTxt.Text == "")
            {
                MessageBox.Show("Не може да има празни полета!");
                return;
            }
            else if (long.TryParse(nameCTxt.Text, out n) || long.TryParse(descriptionTxt.Text, out n) || long.TryParse(skillTxt.Text, out n) 
                || long.TryParse(profesionalFieldTxt.Text, out n) || long.TryParse(positionTxt.Text, out n))
            {
                MessageBox.Show("Не може да се добавят числови данни!");
                return;
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Course set Name = '" + nameCTxt.Text + "', Duration = '" + durationTxt.Text + "', Characterization = '" + descriptionTxt.Text + "', OtherSkills = '" + skillTxt.Text + "', OtherPosition = '" + positionTxt.Text + "', OtherProfessionalField = '" + profesionalFieldTxt.Text + "' where CourseID = '" + noTxt.Text + "'";
                LevelOfEducation();
                FormOfEducation();
                Departments();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно обновяване!");
                
            }
            
        }

        private void editSkillsBtn_Click(object sender, EventArgs e)
        {
            EditSkills srch = new EditSkills(nameCTxt.Text, noTxt.Text);
            srch.MdiParent = this.MdiParent;
            srch.Show();
        }

        private void editPositionsBtn_Click(object sender, EventArgs e)
        {
            EditPositions srch = new EditPositions(nameCTxt.Text, noTxt.Text);
            srch.MdiParent = this.MdiParent;
            srch.Show();
        }

        private void editProfFieldBtn_Click(object sender, EventArgs e)
        {
            EditProfesionalField srch = new EditProfesionalField(nameCTxt.Text, noTxt.Text);
            srch.MdiParent = this.MdiParent;
            srch.Show();
        }

        private void durationTxt_TextChanged(object sender, EventArgs e)
        {
            int n = 1;

            if (!int.TryParse(durationTxt.Text, out n) && durationTxt.Text != "")
            {
                MessageBox.Show("Продължителснотта трябва да бъде положително цяло число!");
                durationTxt.Text = "";
                return;
            }
        }
    }
}
