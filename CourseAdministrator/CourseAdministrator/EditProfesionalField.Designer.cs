namespace CourseAdministrator
{
    partial class EditProfesionalField
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profFieldCmb = new System.Windows.Forms.ComboBox();
            this.professionalFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet1 = new CourseAdministrator.CoursesDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.professionalFieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCourseProfessionalFieldBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vCourseProfessionalFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_CourseProfessionalFieldTableAdapter = new CourseAdministrator.CoursesDataSetTableAdapters.v_CourseProfessionalFieldTableAdapter();
            this.coursesDataSet = new CourseAdministrator.CoursesDataSet();
            this.professionalFieldTableAdapter = new CourseAdministrator.CoursesDataSetTableAdapters.ProfessionalFieldTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.professionalFieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCourseProfessionalFieldBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCourseProfessionalFieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Специалност:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Списък с професионални области:";
            // 
            // profFieldCmb
            // 
            this.profFieldCmb.DataSource = this.professionalFieldBindingSource;
            this.profFieldCmb.DisplayMember = "Name";
            this.profFieldCmb.DropDownHeight = 100;
            this.profFieldCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profFieldCmb.FormattingEnabled = true;
            this.profFieldCmb.IntegralHeight = false;
            this.profFieldCmb.Location = new System.Drawing.Point(30, 76);
            this.profFieldCmb.Name = "profFieldCmb";
            this.profFieldCmb.Size = new System.Drawing.Size(374, 21);
            this.profFieldCmb.TabIndex = 11;
            this.profFieldCmb.ValueMember = "ProfessionalFieldID";
            // 
            // professionalFieldBindingSource
            // 
            this.professionalFieldBindingSource.DataMember = "ProfessionalField";
            this.professionalFieldBindingSource.DataSource = this.coursesDataSet1;
            // 
            // coursesDataSet1
            // 
            this.coursesDataSet1.DataSetName = "CoursesDataSet";
            this.coursesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(329, 112);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добави";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionalFieldIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vCourseProfessionalFieldBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(30, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 193);
            this.dataGridView1.TabIndex = 16;
            // 
            // professionalFieldIDDataGridViewTextBoxColumn
            // 
            this.professionalFieldIDDataGridViewTextBoxColumn.DataPropertyName = "ProfessionalFieldID";
            this.professionalFieldIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.professionalFieldIDDataGridViewTextBoxColumn.Name = "professionalFieldIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 230;
            // 
            // vCourseProfessionalFieldBindingSource1
            // 
            this.vCourseProfessionalFieldBindingSource1.DataMember = "v_CourseProfessionalField";
            this.vCourseProfessionalFieldBindingSource1.DataSource = this.coursesDataSet1;
            // 
            // vCourseProfessionalFieldBindingSource
            // 
            this.vCourseProfessionalFieldBindingSource.DataMember = "v_CourseProfessionalField";
            // 
            // v_CourseProfessionalFieldTableAdapter
            // 
            this.v_CourseProfessionalFieldTableAdapter.ClearBeforeFill = true;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professionalFieldTableAdapter
            // 
            this.professionalFieldTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(329, 358);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Изтриване";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditProfesionalField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 393);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profFieldCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "EditProfesionalField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактиране на професионални области";
            this.Load += new System.EventHandler(this.EditProfesionalField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professionalFieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCourseProfessionalFieldBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCourseProfessionalFieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox profFieldCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vCourseProfessionalFieldBindingSource;
        private CoursesDataSetTableAdapters.v_CourseProfessionalFieldTableAdapter v_CourseProfessionalFieldTableAdapter;
        private CoursesDataSet coursesDataSet1;
        private System.Windows.Forms.BindingSource vCourseProfessionalFieldBindingSource1;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionalFieldIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource professionalFieldBindingSource;
        private CoursesDataSetTableAdapters.ProfessionalFieldTableAdapter professionalFieldTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
    }
}