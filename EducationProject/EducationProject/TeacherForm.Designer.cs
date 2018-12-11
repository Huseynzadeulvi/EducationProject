namespace EducationProject
{
    partial class TeacherForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.educationProjectDataSet1 = new EducationProject.EducationProjectDataSet1();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new EducationProject.EducationProjectDataSet1TableAdapters.TeacherTableAdapter();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklarinSiyahisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTaskButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSpecifiedStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseGroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexsiMesajYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gonderilenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMesajYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGroupMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workMatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onClickToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteResourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qaynaqlarinLinkleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIdDataGridViewTextBoxColumn,
            this.programIdDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.teacherSurnameDataGridViewTextBoxColumn,
            this.teacherEmailDataGridViewTextBoxColumn,
            this.teacherPhoneDataGridViewTextBoxColumn,
            this.teacherBioDataGridViewTextBoxColumn,
            this.teacherPhotoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // educationProjectDataSet1
            // 
            this.educationProjectDataSet1.DataSetName = "EducationProjectDataSet1";
            this.educationProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.educationProjectDataSet1;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            // 
            // programIdDataGridViewTextBoxColumn
            // 
            this.programIdDataGridViewTextBoxColumn.DataPropertyName = "ProgramId";
            this.programIdDataGridViewTextBoxColumn.HeaderText = "ProgramId";
            this.programIdDataGridViewTextBoxColumn.Name = "programIdDataGridViewTextBoxColumn";
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            // 
            // teacherSurnameDataGridViewTextBoxColumn
            // 
            this.teacherSurnameDataGridViewTextBoxColumn.DataPropertyName = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.HeaderText = "TeacherSurname";
            this.teacherSurnameDataGridViewTextBoxColumn.Name = "teacherSurnameDataGridViewTextBoxColumn";
            // 
            // teacherEmailDataGridViewTextBoxColumn
            // 
            this.teacherEmailDataGridViewTextBoxColumn.DataPropertyName = "TeacherEmail";
            this.teacherEmailDataGridViewTextBoxColumn.HeaderText = "TeacherEmail";
            this.teacherEmailDataGridViewTextBoxColumn.Name = "teacherEmailDataGridViewTextBoxColumn";
            // 
            // teacherPhoneDataGridViewTextBoxColumn
            // 
            this.teacherPhoneDataGridViewTextBoxColumn.DataPropertyName = "TeacherPhone";
            this.teacherPhoneDataGridViewTextBoxColumn.HeaderText = "TeacherPhone";
            this.teacherPhoneDataGridViewTextBoxColumn.Name = "teacherPhoneDataGridViewTextBoxColumn";
            // 
            // teacherBioDataGridViewTextBoxColumn
            // 
            this.teacherBioDataGridViewTextBoxColumn.DataPropertyName = "TeacherBio";
            this.teacherBioDataGridViewTextBoxColumn.HeaderText = "TeacherBio";
            this.teacherBioDataGridViewTextBoxColumn.Name = "teacherBioDataGridViewTextBoxColumn";
            // 
            // teacherPhotoDataGridViewTextBoxColumn
            // 
            this.teacherPhotoDataGridViewTextBoxColumn.DataPropertyName = "TeacherPhoto";
            this.teacherPhotoDataGridViewTextBoxColumn.HeaderText = "TeacherPhoto";
            this.teacherPhotoDataGridViewTextBoxColumn.Name = "teacherPhotoDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.assignTaskToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.mentorInfoToolStripMenuItem,
            this.mesajlarimToolStripMenuItem,
            this.workMatesToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit ";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.showTasksToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            // 
            // showTasksToolStripMenuItem
            // 
            this.showTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasklarinSiyahisiToolStripMenuItem,
            this.deleteTaskButtonToolStripMenuItem,
            this.updateTaskButtonToolStripMenuItem});
            this.showTasksToolStripMenuItem.Name = "showTasksToolStripMenuItem";
            this.showTasksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTasksToolStripMenuItem.Text = "Show Tasks";
            // 
            // tasklarinSiyahisiToolStripMenuItem
            // 
            this.tasklarinSiyahisiToolStripMenuItem.Name = "tasklarinSiyahisiToolStripMenuItem";
            this.tasklarinSiyahisiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tasklarinSiyahisiToolStripMenuItem.Text = "Tasklarin siyahisi";
            // 
            // deleteTaskButtonToolStripMenuItem
            // 
            this.deleteTaskButtonToolStripMenuItem.Name = "deleteTaskButtonToolStripMenuItem";
            this.deleteTaskButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteTaskButtonToolStripMenuItem.Text = "Delete Task Button";
            // 
            // updateTaskButtonToolStripMenuItem
            // 
            this.updateTaskButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFormToolStripMenuItem});
            this.updateTaskButtonToolStripMenuItem.Name = "updateTaskButtonToolStripMenuItem";
            this.updateTaskButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateTaskButtonToolStripMenuItem.Text = "Update Task Button";
            // 
            // updateFormToolStripMenuItem
            // 
            this.updateFormToolStripMenuItem.Name = "updateFormToolStripMenuItem";
            this.updateFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateFormToolStripMenuItem.Text = "Update Form";
            // 
            // assignTaskToolStripMenuItem
            // 
            this.assignTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseGroupToolStripMenuItem,
            this.chooseTaskToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.checkSpecifiedStudentsToolStripMenuItem,
            this.assignTaskToolStripMenuItem1});
            this.assignTaskToolStripMenuItem.Name = "assignTaskToolStripMenuItem";
            this.assignTaskToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.assignTaskToolStripMenuItem.Text = "Assign Task";
            // 
            // chooseGroupToolStripMenuItem
            // 
            this.chooseGroupToolStripMenuItem.Name = "chooseGroupToolStripMenuItem";
            this.chooseGroupToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.chooseGroupToolStripMenuItem.Text = "Choose Group";
            // 
            // chooseTaskToolStripMenuItem
            // 
            this.chooseTaskToolStripMenuItem.Name = "chooseTaskToolStripMenuItem";
            this.chooseTaskToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.chooseTaskToolStripMenuItem.Text = "Choose Task";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            // 
            // checkSpecifiedStudentsToolStripMenuItem
            // 
            this.checkSpecifiedStudentsToolStripMenuItem.Name = "checkSpecifiedStudentsToolStripMenuItem";
            this.checkSpecifiedStudentsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.checkSpecifiedStudentsToolStripMenuItem.Text = "Check Specified Student(s)";
            // 
            // assignTaskToolStripMenuItem1
            // 
            this.assignTaskToolStripMenuItem1.Name = "assignTaskToolStripMenuItem1";
            this.assignTaskToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.assignTaskToolStripMenuItem1.Text = "Assign Task";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseGroupToolStripMenuItem1,
            this.studentListToolStripMenuItem1});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // chooseGroupToolStripMenuItem1
            // 
            this.chooseGroupToolStripMenuItem1.Name = "chooseGroupToolStripMenuItem1";
            this.chooseGroupToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chooseGroupToolStripMenuItem1.Text = "Choose Group";
            // 
            // studentListToolStripMenuItem1
            // 
            this.studentListToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onClickToolStripMenuItem});
            this.studentListToolStripMenuItem1.Name = "studentListToolStripMenuItem1";
            this.studentListToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.studentListToolStripMenuItem1.Text = "Student List";
            // 
            // onClickToolStripMenuItem
            // 
            this.onClickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInfoToolStripMenuItem,
            this.taskInfoToolStripMenuItem});
            this.onClickToolStripMenuItem.Name = "onClickToolStripMenuItem";
            this.onClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onClickToolStripMenuItem.Text = "OnClick";
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentInfoToolStripMenuItem.Text = "Student Info";
            // 
            // taskInfoToolStripMenuItem
            // 
            this.taskInfoToolStripMenuItem.Name = "taskInfoToolStripMenuItem";
            this.taskInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taskInfoToolStripMenuItem.Text = "Task info";
            // 
            // mentorInfoToolStripMenuItem
            // 
            this.mentorInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexsiMesajYazToolStripMenuItem});
            this.mentorInfoToolStripMenuItem.Name = "mentorInfoToolStripMenuItem";
            this.mentorInfoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mentorInfoToolStripMenuItem.Text = "Mentor Info";
            // 
            // sexsiMesajYazToolStripMenuItem
            // 
            this.sexsiMesajYazToolStripMenuItem.Name = "sexsiMesajYazToolStripMenuItem";
            this.sexsiMesajYazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sexsiMesajYazToolStripMenuItem.Text = "Sexsi mesaj yaz";
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
            this.gonderilenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gonderilenlerToolStripMenuItem.Text = "Gonderilenler";
            // 
            // gelenlerToolStripMenuItem
            // 
            this.gelenlerToolStripMenuItem.Name = "gelenlerToolStripMenuItem";
            this.gelenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gelenlerToolStripMenuItem.Text = "Gelenler";
            // 
            // yeniMesajYazToolStripMenuItem
            // 
            this.yeniMesajYazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTeacherToolStripMenuItem,
            this.toMentorToolStripMenuItem,
            this.toGroupMateToolStripMenuItem});
            this.yeniMesajYazToolStripMenuItem.Name = "yeniMesajYazToolStripMenuItem";
            this.yeniMesajYazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMesajYazToolStripMenuItem.Text = "Yeni mesaj yaz";
            // 
            // toTeacherToolStripMenuItem
            // 
            this.toTeacherToolStripMenuItem.Name = "toTeacherToolStripMenuItem";
            this.toTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toTeacherToolStripMenuItem.Text = "To Teacher";
            // 
            // toMentorToolStripMenuItem
            // 
            this.toMentorToolStripMenuItem.Name = "toMentorToolStripMenuItem";
            this.toMentorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toMentorToolStripMenuItem.Text = "To Mentor";
            // 
            // toGroupMateToolStripMenuItem
            // 
            this.toGroupMateToolStripMenuItem.Name = "toGroupMateToolStripMenuItem";
            this.toGroupMateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toGroupMateToolStripMenuItem.Text = "To GroupMate";
            // 
            // workMatesToolStripMenuItem
            // 
            this.workMatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onClickToolStripMenuItem1});
            this.workMatesToolStripMenuItem.Name = "workMatesToolStripMenuItem";
            this.workMatesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.workMatesToolStripMenuItem.Text = "Work Mates";
            // 
            // onClickToolStripMenuItem1
            // 
            this.onClickToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherInfoToolStripMenuItem});
            this.onClickToolStripMenuItem1.Name = "onClickToolStripMenuItem1";
            this.onClickToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.onClickToolStripMenuItem1.Text = "OnClick";
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Info";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addResourseToolStripMenuItem,
            this.deleteResourseToolStripMenuItem,
            this.showResourcesToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // addResourseToolStripMenuItem
            // 
            this.addResourseToolStripMenuItem.Name = "addResourseToolStripMenuItem";
            this.addResourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addResourseToolStripMenuItem.Text = "Add Resourse";
            // 
            // deleteResourseToolStripMenuItem
            // 
            this.deleteResourseToolStripMenuItem.Name = "deleteResourseToolStripMenuItem";
            this.deleteResourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteResourseToolStripMenuItem.Text = "Delete Resourse";
            // 
            // showResourcesToolStripMenuItem
            // 
            this.showResourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qaynaqlarinLinkleriToolStripMenuItem,
            this.downloadFileToolStripMenuItem});
            this.showResourcesToolStripMenuItem.Name = "showResourcesToolStripMenuItem";
            this.showResourcesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showResourcesToolStripMenuItem.Text = "Show Resources";
            // 
            // qaynaqlarinLinkleriToolStripMenuItem
            // 
            this.qaynaqlarinLinkleriToolStripMenuItem.Name = "qaynaqlarinLinkleriToolStripMenuItem";
            this.qaynaqlarinLinkleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qaynaqlarinLinkleriToolStripMenuItem.Text = "Qaynaqlarin linkleri";
            // 
            // downloadFileToolStripMenuItem
            // 
            this.downloadFileToolStripMenuItem.Name = "downloadFileToolStripMenuItem";
            this.downloadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadFileToolStripMenuItem.Text = "Download File";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EducationProjectDataSet1 educationProjectDataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private EducationProjectDataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherBioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasklarinSiyahisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTaskButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkSpecifiedStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseGroupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexsiMesajYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajlarimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gonderilenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMesajYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGroupMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workMatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onClickToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteResourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qaynaqlarinLinkleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFileToolStripMenuItem;
    }
}