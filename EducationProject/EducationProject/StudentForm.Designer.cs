namespace EducationProject
{
    partial class StudentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskinAdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexsiMesajYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexsiMesajYazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gonderilenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMesajYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGroupMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFilepdfFormatdadirsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwStudentList = new System.Windows.Forms.DataGridView();
            this.educationProjectDataSet2 = new EducationProject.EducationProjectDataSet2();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new EducationProject.EducationProjectDataSet2TableAdapters.StudentTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.showTasksToolStripMenuItem,
            this.teacherInfoToolStripMenuItem,
            this.mentorInfoToolStripMenuItem,
            this.mesajlarimToolStripMenuItem,
            this.groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.photoToolStripMenuItem,
            this.bioToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.photoToolStripMenuItem.Text = "Photo";
            // 
            // bioToolStripMenuItem
            // 
            this.bioToolStripMenuItem.Name = "bioToolStripMenuItem";
            this.bioToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.bioToolStripMenuItem.Text = "Bio";
            // 
            // showTasksToolStripMenuItem
            // 
            this.showTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskinAdiToolStripMenuItem,
            this.newForToolStripMenuItem});
            this.showTasksToolStripMenuItem.Name = "showTasksToolStripMenuItem";
            this.showTasksToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.showTasksToolStripMenuItem.Text = "Show Tasks";
            // 
            // taskinAdiToolStripMenuItem
            // 
            this.taskinAdiToolStripMenuItem.Name = "taskinAdiToolStripMenuItem";
            this.taskinAdiToolStripMenuItem.Size = new System.Drawing.Size(594, 22);
            this.taskinAdiToolStripMenuItem.Text = "Export  Transcipt";
            // 
            // newForToolStripMenuItem
            // 
            this.newForToolStripMenuItem.Name = "newForToolStripMenuItem";
            this.newForToolStripMenuItem.Size = new System.Drawing.Size(594, 22);
            this.newForToolStripMenuItem.Text = "Her taska click olunanda yeni window acilmalidir.Taskin butun detallari bu window" +
    "da gorunmelidir";
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexsiMesajYazToolStripMenuItem});
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Info ";
            // 
            // sexsiMesajYazToolStripMenuItem
            // 
            this.sexsiMesajYazToolStripMenuItem.Name = "sexsiMesajYazToolStripMenuItem";
            this.sexsiMesajYazToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sexsiMesajYazToolStripMenuItem.Text = "Sexsi mesaj yaz";
            // 
            // mentorInfoToolStripMenuItem
            // 
            this.mentorInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexsiMesajYazToolStripMenuItem1});
            this.mentorInfoToolStripMenuItem.Name = "mentorInfoToolStripMenuItem";
            this.mentorInfoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mentorInfoToolStripMenuItem.Text = "Mentor Info";
            // 
            // sexsiMesajYazToolStripMenuItem1
            // 
            this.sexsiMesajYazToolStripMenuItem1.Name = "sexsiMesajYazToolStripMenuItem1";
            this.sexsiMesajYazToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.sexsiMesajYazToolStripMenuItem1.Text = "Sexsi mesaj yaz";
            // 
            // mesajlarimToolStripMenuItem
            // 
            this.mesajlarimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gonderilenlerToolStripMenuItem,
            this.gelenlerToolStripMenuItem,
            this.yeniMesajYazToolStripMenuItem});
            this.mesajlarimToolStripMenuItem.Name = "mesajlarimToolStripMenuItem";
            this.mesajlarimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mesajlarimToolStripMenuItem.Text = "Mesajlarim";
            // 
            // gonderilenlerToolStripMenuItem
            // 
            this.gonderilenlerToolStripMenuItem.Name = "gonderilenlerToolStripMenuItem";
            this.gonderilenlerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gonderilenlerToolStripMenuItem.Text = "Gonderilenler";
            // 
            // gelenlerToolStripMenuItem
            // 
            this.gelenlerToolStripMenuItem.Name = "gelenlerToolStripMenuItem";
            this.gelenlerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gelenlerToolStripMenuItem.Text = "Gelenler";
            // 
            // yeniMesajYazToolStripMenuItem
            // 
            this.yeniMesajYazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTeacherToolStripMenuItem,
            this.toMentorToolStripMenuItem,
            this.toGroupMateToolStripMenuItem});
            this.yeniMesajYazToolStripMenuItem.Name = "yeniMesajYazToolStripMenuItem";
            this.yeniMesajYazToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yeniMesajYazToolStripMenuItem.Text = "Yeni mesaj yaz";
            // 
            // toTeacherToolStripMenuItem
            // 
            this.toTeacherToolStripMenuItem.Name = "toTeacherToolStripMenuItem";
            this.toTeacherToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toTeacherToolStripMenuItem.Text = "To Teacher";
            // 
            // toMentorToolStripMenuItem
            // 
            this.toMentorToolStripMenuItem.Name = "toMentorToolStripMenuItem";
            this.toMentorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toMentorToolStripMenuItem.Text = "To Mentor";
            // 
            // toGroupMateToolStripMenuItem
            // 
            this.toGroupMateToolStripMenuItem.Name = "toGroupMateToolStripMenuItem";
            this.toGroupMateToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toGroupMateToolStripMenuItem.Text = "To GroupMate";
            // 
            // groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem
            // 
            this.groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem});
            this.groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem.Name = "groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem";
            this.groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem.Text = "Group Mates";
            // 
            // herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem
            // 
            this.herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem.Name = "herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem";
            this.herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem.Size = new System.Drawing.Size(422, 22);
            this.herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem.Text = "Her telebeye click olunanda sadece info melumatlari gorunmelidir";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem,
            this.downloadFilepdfFormatdadirsaToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem
            // 
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem.Name = "qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem";
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem.Text = "Qaynaqlarin linkleri (online qaynaqlardirsa)";
            // 
            // downloadFilepdfFormatdadirsaToolStripMenuItem
            // 
            this.downloadFilepdfFormatdadirsaToolStripMenuItem.Name = "downloadFilepdfFormatdadirsaToolStripMenuItem";
            this.downloadFilepdfFormatdadirsaToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.downloadFilepdfFormatdadirsaToolStripMenuItem.Text = "Download File  (pdf formatdadirsa)";
            // 
            // dgwStudentList
            // 
            this.dgwStudentList.AutoGenerateColumns = false;
            this.dgwStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentBirthDateDataGridViewTextBoxColumn,
            this.studentEmailDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentRegistrationDateDataGridViewTextBoxColumn,
            this.studentPhotoDataGridViewTextBoxColumn});
            this.dgwStudentList.DataSource = this.studentBindingSource;
            this.dgwStudentList.Location = new System.Drawing.Point(30, 70);
            this.dgwStudentList.Name = "dgwStudentList";
            this.dgwStudentList.Size = new System.Drawing.Size(728, 150);
            this.dgwStudentList.TabIndex = 3;
            // 
            // educationProjectDataSet2
            // 
            this.educationProjectDataSet2.DataSetName = "EducationProjectDataSet2";
            this.educationProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.educationProjectDataSet2;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentBirthDateDataGridViewTextBoxColumn
            // 
            this.studentBirthDateDataGridViewTextBoxColumn.DataPropertyName = "StudentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.HeaderText = "StudentBirthDate";
            this.studentBirthDateDataGridViewTextBoxColumn.Name = "studentBirthDateDataGridViewTextBoxColumn";
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            // 
            // studentRegistrationDateDataGridViewTextBoxColumn
            // 
            this.studentRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "StudentRegistrationDate";
            this.studentRegistrationDateDataGridViewTextBoxColumn.HeaderText = "StudentRegistrationDate";
            this.studentRegistrationDateDataGridViewTextBoxColumn.Name = "studentRegistrationDateDataGridViewTextBoxColumn";
            // 
            // studentPhotoDataGridViewTextBoxColumn
            // 
            this.studentPhotoDataGridViewTextBoxColumn.DataPropertyName = "StudentPhoto";
            this.studentPhotoDataGridViewTextBoxColumn.HeaderText = "StudentPhoto";
            this.studentPhotoDataGridViewTextBoxColumn.Name = "studentPhotoDataGridViewTextBoxColumn";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwStudentList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskinAdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexsiMesajYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexsiMesajYazToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mesajlarimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gonderilenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMesajYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGroupMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMatesGrupdakiTelebelerinSiyahisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herTelebeyeClickOlunandaSadeceInfoMelumatlariGorunmelidirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFilepdfFormatdadirsaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwStudentList;
        private EducationProjectDataSet2 educationProjectDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private EducationProjectDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhotoDataGridViewTextBoxColumn;
    }
}