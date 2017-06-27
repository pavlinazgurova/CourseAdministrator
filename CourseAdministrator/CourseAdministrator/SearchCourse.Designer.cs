namespace CourseAdministrator
{
    partial class SearchCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentsCmb = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new CourseAdministrator.CoursesDataSet();
            this.durationTxt = new System.Windows.Forms.TextBox();
            this.formOfCmb = new System.Windows.Forms.ComboBox();
            this.formOfEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelOfCmb = new System.Windows.Forms.ComboBox();
            this.levelOfEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOne = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.levelOfEducationTableAdapter = new CourseAdministrator.CoursesDataSetTableAdapters.LevelOfEducationTableAdapter();
            this.formOfEducationTableAdapter = new CourseAdministrator.CoursesDataSetTableAdapters.FormOfEducationTableAdapter();
            this.addBtn = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new CourseAdministrator.CoursesDataSetTableAdapters.DepartmentsTableAdapter();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formOfEducationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfEducationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOne)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.departmentsCmb);
            this.groupBox1.Controls.Add(this.durationTxt);
            this.groupBox1.Controls.Add(this.formOfCmb);
            this.groupBox1.Controls.Add(this.levelOfCmb);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Критерии за търсене";
            // 
            // departmentsCmb
            // 
            this.departmentsCmb.DataSource = this.departmentsBindingSource;
            this.departmentsCmb.DisplayMember = "NameDepartments";
            this.departmentsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsCmb.FormattingEnabled = true;
            this.departmentsCmb.Location = new System.Drawing.Point(169, 153);
            this.departmentsCmb.Name = "departmentsCmb";
            this.departmentsCmb.Size = new System.Drawing.Size(340, 21);
            this.departmentsCmb.TabIndex = 5;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.coursesDataSet;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // durationTxt
            // 
            this.durationTxt.Location = new System.Drawing.Point(169, 123);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(56, 20);
            this.durationTxt.TabIndex = 7;
            this.durationTxt.TextChanged += new System.EventHandler(this.durationTxt_TextChanged);
            // 
            // formOfCmb
            // 
            this.formOfCmb.DataSource = this.formOfEducationBindingSource;
            this.formOfCmb.DisplayMember = "NameFormOfEducation";
            this.formOfCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formOfCmb.FormattingEnabled = true;
            this.formOfCmb.Location = new System.Drawing.Point(169, 90);
            this.formOfCmb.Name = "formOfCmb";
            this.formOfCmb.Size = new System.Drawing.Size(194, 21);
            this.formOfCmb.TabIndex = 9;
            // 
            // formOfEducationBindingSource
            // 
            this.formOfEducationBindingSource.DataMember = "FormOfEducation";
            this.formOfEducationBindingSource.DataSource = this.coursesDataSet;
            // 
            // levelOfCmb
            // 
            this.levelOfCmb.DataSource = this.levelOfEducationBindingSource;
            this.levelOfCmb.DisplayMember = "NameLevelOfEducation";
            this.levelOfCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelOfCmb.FormattingEnabled = true;
            this.levelOfCmb.Location = new System.Drawing.Point(169, 56);
            this.levelOfCmb.Name = "levelOfCmb";
            this.levelOfCmb.Size = new System.Drawing.Size(194, 21);
            this.levelOfCmb.TabIndex = 10;
            // 
            // levelOfEducationBindingSource
            // 
            this.levelOfEducationBindingSource.DataMember = "LevelOfEducation";
            this.levelOfEducationBindingSource.DataSource = this.coursesDataSet;
            this.levelOfEducationBindingSource.CurrentChanged += new System.EventHandler(this.levelOfEducationBindingSource_CurrentChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(434, 191);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Търсене";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Направление:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(169, 27);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(340, 20);
            this.nameTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Продължителност:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Форма на обучение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Образователна степен:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование:";
            // 
            // dataGridViewOne
            // 
            this.dataGridViewOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOne.Location = new System.Drawing.Point(22, 267);
            this.dataGridViewOne.Name = "dataGridViewOne";
            this.dataGridViewOne.ReadOnly = true;
            this.dataGridViewOne.Size = new System.Drawing.Size(649, 250);
            this.dataGridViewOne.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(694, 305);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(91, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Редактиране";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(694, 346);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(91, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Изтриване";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // levelOfEducationTableAdapter
            // 
            this.levelOfEducationTableAdapter.ClearBeforeFill = true;
            // 
            // formOfEducationTableAdapter
            // 
            this.formOfEducationTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(694, 267);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Добаване";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(330, 191);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Изчисти";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // SearchCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 529);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dataGridViewOne);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Търсене на специалност";
            this.Load += new System.EventHandler(this.SearchCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formOfEducationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfEducationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox durationTxt;
        private System.Windows.Forms.ComboBox formOfCmb;
        private System.Windows.Forms.ComboBox levelOfCmb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource levelOfEducationBindingSource;
        private CoursesDataSetTableAdapters.LevelOfEducationTableAdapter levelOfEducationTableAdapter;
        private System.Windows.Forms.BindingSource formOfEducationBindingSource;
        private CoursesDataSetTableAdapters.FormOfEducationTableAdapter formOfEducationTableAdapter;
        public System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox departmentsCmb;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private CoursesDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewOne;
        private System.Windows.Forms.Button clearBtn;
    }
}