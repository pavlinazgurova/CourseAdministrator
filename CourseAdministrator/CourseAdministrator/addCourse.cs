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
    public partial class addCourse : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public addCourse()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameCTxt.Text == "" || levelOfCmb.Text == "" || formOfCmb.Text == "" || durationTxt.Text == "" 
                    || departmentsCmb.Text == "" || descriptionTxt.Text == "" || skillTxt.Text == "" || positionTxt.Text == "" 
                    || profesionalFieldTxt.Text == "")
                {
                    MessageBox.Show("Всички полета трябва да бъдат попълнени!");
                    return;
                }

                //levelOfEducation
                var levelOfEducation = 1;
                if (levelOfCmb.Text == "Магистър")
                {
                    levelOfEducation = 2;
                }
                else if (levelOfCmb.Text == "Доктор")
                {
                    levelOfEducation = 3;
                }

                //formOfEducation
                var formOfEducation = 1;
                if (formOfCmb.Text == "Задочно")
                {
                    formOfEducation = 2;
                }

                //departments
                var departments = 1;
                if (departmentsCmb.Text == "Финанси, счетоводство и контрол")
                {
                    departments = 2;
                }
                else if (departmentsCmb.Text == "Администрация и управление")
                {
                    departments = 3;
                }

                long n = 1;
                if (long.TryParse(nameCTxt.Text, out n) || long.TryParse(descriptionTxt.Text, out n) 
                    || long.TryParse(skillTxt.Text, out n) || long.TryParse(profesionalFieldTxt.Text, out n) || long.TryParse(positionTxt.Text, out n))
                {
                    MessageBox.Show("Не може да се добавят числови данни!");
                    return;
                }

                //InsertStatement
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT into Course(Name, LevelOfEducationID, FormOfEducationID, Duration, 
                DepartmentID, Characterization, OtherSkills, OtherPosition, OtherProfessionalField) 
                values('" + nameCTxt.Text + "', '" + levelOfEducation + "', '" + formOfEducation + "', '" + durationTxt.Text + "', '" + departments + "', '" + descriptionTxt.Text + "', '" + skillTxt.Text + "' ,'" + positionTxt.Text + "' ,'" + profesionalFieldTxt.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно добавени данни!");


                //Show the code of the course
                con.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT CourseID 
                                               FROM Course
                                               WHERE Name = '" + nameCTxt.Text + "'", con);
                SqlDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                    noTxt.Text = (read["CourseID"].ToString());
                }
                read.Close();
                con.Close();

                Edit newEdit = new Edit();
                newEdit.noTxt.Text = noTxt.Text;
                newEdit.MdiParent = this.MdiParent;
                newEdit.Show();
                this.Hide();
            }
            catch 
            {
                MessageBox.Show($"{nameCTxt.Text} вече съществува!");
                addCourse srch = new addCourse();
                srch.MdiParent = this.MdiParent;
                srch.Show();
                this.Hide();
            }
                        
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

        private void addCourse_Load(object sender, EventArgs e)
        {
            this.ActiveControl = nameCTxt;
        }
    }
}
