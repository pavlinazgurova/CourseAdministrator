using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseAdministrator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ProfesionalFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProfessionalField srch = new SearchProfessionalField();
            srch.MdiParent = this;
            srch.Show();
        }

        private void SkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSkills srch = new SearchSkills();
            srch.MdiParent = this;
            srch.Show();
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPositions srch = new SearchPositions();
            srch.MdiParent = this;
            srch.Show();
        }

        private void CoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCourse srch = new SearchCourse();
            srch.MdiParent = this;
            srch.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login srch = new Login();
            srch.Show();
            this.Hide();
        }
    }
}
