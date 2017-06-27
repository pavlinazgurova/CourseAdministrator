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
    public partial class SearchCourse : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PAVI-PC\SQLEXPRESS;Initial Catalog=Courses;Integrated Security=True");
        public SearchCourse()
        {
            InitializeComponent();
     
        }

        private bool searchBtnWasClicked = false;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtnWasClicked = true;

            if ((levelOfCmb.SelectedIndex == -1) && (formOfCmb.SelectedIndex == -1) && (departmentsCmb.SelectedIndex == -1))
            {
                con.Open();
                SqlCommand search = con.CreateCommand();
                search.CommandType = CommandType.Text;
                search.CommandText = @"SELECT c.CourseID as Номер, c.Name  as Специалност, l.NameLevelOfEducation as ОбразователнаСтепен, 
                f.NameFormOfEducation as ФормаНаОбучение, c.Duration as Продължителност, d.NameDepartments as Направление
                from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
                inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
                inner join Departments d on c.DepartmentID=d.DepartmentID
                where c.Name like '%" + nameTxt.Text + "%' AND c.Duration like '%" + durationTxt.Text + "%' order by CourseID ";

                search.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(search);
                da.Fill(dt);
                dataGridViewOne.DataSource = dt;
                con.Close();
                return;
            }

            if (levelOfCmb.SelectedIndex == -1)
            {
                con.Open();
                SqlCommand search = con.CreateCommand();
                search.CommandType = CommandType.Text;
                search.CommandText = @"SELECT c.CourseID as Номер, c.Name  as Специалност, l.NameLevelOfEducation as ОбразователнаСтепен, 
                f.NameFormOfEducation as ФормаНаОбучение, c.Duration as Продължителност, d.NameDepartments as Направление
                from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
                inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
                inner join Departments d on c.DepartmentID=d.DepartmentID
                where c.Name like '%" + nameTxt.Text + "%' AND f.NameFormOfEducation = '" + formOfCmb.Text + "' AND c.Duration like '%" + durationTxt.Text + "%' AND d.NameDepartments like '%" + departmentsCmb.Text + "%' order by CourseID ";

                search.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(search);
                da.Fill(dt);
                dataGridViewOne.DataSource = dt;
                con.Close();
            }
            else if (formOfCmb.SelectedIndex == -1)
            {
                con.Open();
                SqlCommand search = con.CreateCommand();
                search.CommandType = CommandType.Text;
                search.CommandText = @"SELECT c.CourseID as Номер, c.Name  as Специалност, l.NameLevelOfEducation as ОбразователнаСтепен, 
                f.NameFormOfEducation as ФормаНаОбучение, c.Duration as Продължителност, d.NameDepartments as Направление
                from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
                inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
                inner join Departments d on c.DepartmentID=d.DepartmentID
                where c.Name like '%" + nameTxt.Text + "%' AND l.NameLevelOfEducation = '" + levelOfCmb.Text + "' AND c.Duration like '%" + durationTxt.Text + "%' AND d.NameDepartments like '%" + departmentsCmb.Text + "%' order by CourseID ";

                search.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(search);
                da.Fill(dt);
                dataGridViewOne.DataSource = dt;
                con.Close();
            }
            else if (departmentsCmb.SelectedIndex == -1)
            {
                con.Open();
                SqlCommand search = con.CreateCommand();
                search.CommandType = CommandType.Text;
                search.CommandText = @"SELECT c.CourseID as Номер, c.Name  as Специалност, l.NameLevelOfEducation as ОбразователнаСтепен, 
                f.NameFormOfEducation as ФормаНаОбучение, c.Duration as Продължителност, d.NameDepartments as Направление
                from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
                inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
                inner join Departments d on c.DepartmentID=d.DepartmentID
                where c.Name like '%" + nameTxt.Text + "%' AND l.NameLevelOfEducation = '" + levelOfCmb.Text + "' AND f.NameFormOfEducation = '" + formOfCmb.Text + "' AND c.Duration like '%" + durationTxt.Text + "%' order by CourseID ";

                search.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(search);
                da.Fill(dt);
                dataGridViewOne.DataSource = dt;
                con.Close();
            }
            
            else
            {
                con.Open();
                SqlCommand search = con.CreateCommand();
                search.CommandType = CommandType.Text;
                search.CommandText = @"SELECT c.CourseID as Номер, c.Name  as Специалност, l.NameLevelOfEducation as ОбразователнаСтепен, 
                f.NameFormOfEducation as ФормаНаОбучение, c.Duration as Продължителност, d.NameDepartments as Направление
                from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
                inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
                inner join Departments d on c.DepartmentID=d.DepartmentID
                where c.Name like '%" + nameTxt.Text + "%' AND l.NameLevelOfEducation = '" + levelOfCmb.Text + "' AND f.NameFormOfEducation = '" + formOfCmb.Text + "' AND c.Duration like '%" + durationTxt.Text + "%' AND d.NameDepartments like '%" + departmentsCmb.Text + "%' order by CourseID";

                search.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(search);
                da.Fill(dt);
                dataGridViewOne.DataSource = dt;
                con.Close();
            }
            
        }

        private void SearchCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursesDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.coursesDataSet.Departments);
            // TODO: This line of code loads data into the 'coursesDataSet.FormOfEducation' table. You can move, or remove it, as needed.
            this.formOfEducationTableAdapter.Fill(this.coursesDataSet.FormOfEducation);
            // TODO: This line of code loads data into the 'coursesDataSet.LevelOfEducation' table. You can move, or remove it, as needed.
            this.levelOfEducationTableAdapter.Fill(this.coursesDataSet.LevelOfEducation);

            levelOfCmb.ResetText();
            levelOfCmb.SelectedIndex = -1;
            formOfCmb.ResetText();
            formOfCmb.SelectedIndex = -1;
            departmentsCmb.ResetText();
            departmentsCmb.SelectedIndex = -1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit newEdit = new Edit();
                newEdit.noTxt.Text = dataGridViewOne.CurrentRow.Cells[0].Value.ToString();
                newEdit.MdiParent = this.MdiParent;
                newEdit.Show();
            }
            catch 
            {
                MessageBox.Show("Трябва да изберете специалност!");
            }
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addCourse srch = new addCourse();
            srch.MdiParent = this.MdiParent;
            srch.Show();            
        }

        public void DisplayData()
        {
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            search.CommandText = @"SELECT c.CourseID as Номер, c.Name  as Специалност, l.NameLevelOfEducation as ОбразователнаСтепен, 
            f.NameFormOfEducation as ФормаНаОбучение, c.Duration as Продължителност, d.NameDepartments as Направление
            from Course c inner join LevelOfEducation l on c.LevelOfEducationID=l.LevelOfEducationID 
            inner join FormOfEducation f on c.FormOfEducationID=f.FormOfEducationID
            inner join Departments d on c.DepartmentID=d.DepartmentID order by CourseID";
            search.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(search);
            da.Fill(dt);
            dataGridViewOne.DataSource = dt;
            con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchBtnWasClicked == false)
                {
                    MessageBox.Show("Трябва да изберете специалност!");
                    return;
                }
                else
                {
                    var confirmResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?",
                                        "Потвърждение!!",
                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from Course where CourseID = '" + dataGridViewOne.CurrentRow.Cells[0].Value.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Успешно изтрити данни!");
                        DisplayData();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Трябва да изберете специалност!");
            }           
        }

        private void levelOfEducationBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            durationTxt.Clear();
            levelOfCmb.SelectedIndex = -1;
            formOfCmb.SelectedIndex = -1;
            departmentsCmb.SelectedIndex = -1;
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
