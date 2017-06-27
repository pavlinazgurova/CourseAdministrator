namespace CourseAdministrator
{
    partial class addCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noTxt = new System.Windows.Forms.TextBox();
            this.nameCTxt = new System.Windows.Forms.TextBox();
            this.levelOfCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formOfCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.durationTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.skillTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.positionTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.profesionalFieldTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.departmentsCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Образователна степен:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Код на специалност:";
            // 
            // noTxt
            // 
            this.noTxt.Location = new System.Drawing.Point(161, 23);
            this.noTxt.Name = "noTxt";
            this.noTxt.ReadOnly = true;
            this.noTxt.Size = new System.Drawing.Size(60, 20);
            this.noTxt.TabIndex = 11;
            // 
            // nameCTxt
            // 
            this.nameCTxt.Location = new System.Drawing.Point(161, 58);
            this.nameCTxt.Name = "nameCTxt";
            this.nameCTxt.Size = new System.Drawing.Size(416, 20);
            this.nameCTxt.TabIndex = 12;
            // 
            // levelOfCmb
            // 
            this.levelOfCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelOfCmb.FormattingEnabled = true;
            this.levelOfCmb.Items.AddRange(new object[] {
            "Бакалавър",
            "Магистър",
            "Доктор"});
            this.levelOfCmb.Location = new System.Drawing.Point(161, 93);
            this.levelOfCmb.Name = "levelOfCmb";
            this.levelOfCmb.Size = new System.Drawing.Size(147, 21);
            this.levelOfCmb.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Форма на обучение:";
            // 
            // formOfCmb
            // 
            this.formOfCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formOfCmb.FormattingEnabled = true;
            this.formOfCmb.Items.AddRange(new object[] {
            "Редовно",
            "Задочно"});
            this.formOfCmb.Location = new System.Drawing.Point(161, 129);
            this.formOfCmb.Name = "formOfCmb";
            this.formOfCmb.Size = new System.Drawing.Size(147, 21);
            this.formOfCmb.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Продължителност:";
            // 
            // durationTxt
            // 
            this.durationTxt.Location = new System.Drawing.Point(161, 166);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(60, 20);
            this.durationTxt.TabIndex = 22;
            this.durationTxt.TextChanged += new System.EventHandler(this.durationTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Направление:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Описание:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(161, 240);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTxt.Size = new System.Drawing.Size(416, 89);
            this.descriptionTxt.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Умения:";
            // 
            // skillTxt
            // 
            this.skillTxt.Location = new System.Drawing.Point(161, 345);
            this.skillTxt.Multiline = true;
            this.skillTxt.Name = "skillTxt";
            this.skillTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.skillTxt.Size = new System.Drawing.Size(416, 50);
            this.skillTxt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Длъжност:";
            // 
            // positionTxt
            // 
            this.positionTxt.Location = new System.Drawing.Point(161, 413);
            this.positionTxt.Multiline = true;
            this.positionTxt.Name = "positionTxt";
            this.positionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.positionTxt.Size = new System.Drawing.Size(416, 50);
            this.positionTxt.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Професионална област:";
            // 
            // profesionalFieldTxt
            // 
            this.profesionalFieldTxt.Location = new System.Drawing.Point(161, 480);
            this.profesionalFieldTxt.Multiline = true;
            this.profesionalFieldTxt.Name = "profesionalFieldTxt";
            this.profesionalFieldTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.profesionalFieldTxt.Size = new System.Drawing.Size(416, 50);
            this.profesionalFieldTxt.TabIndex = 32;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(502, 553);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Запази";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // departmentsCmb
            // 
            this.departmentsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsCmb.FormattingEnabled = true;
            this.departmentsCmb.Items.AddRange(new object[] {
            "Приложна информатика, комуникации и иконометрия",
            "Финанси, счетоводство и контрол",
            "Администрация и управление"});
            this.departmentsCmb.Location = new System.Drawing.Point(161, 202);
            this.departmentsCmb.Name = "departmentsCmb";
            this.departmentsCmb.Size = new System.Drawing.Size(416, 21);
            this.departmentsCmb.TabIndex = 35;
            // 
            // addCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 588);
            this.Controls.Add(this.departmentsCmb);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.profesionalFieldTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.positionTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.skillTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.durationTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.formOfCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.levelOfCmb);
            this.Controls.Add(this.nameCTxt);
            this.Controls.Add(this.noTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "addCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на нова специалност";
            this.Load += new System.EventHandler(this.addCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox noTxt;
        private System.Windows.Forms.TextBox nameCTxt;
        private System.Windows.Forms.ComboBox levelOfCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox formOfCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox durationTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox skillTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox positionTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox profesionalFieldTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox departmentsCmb;
    }
}