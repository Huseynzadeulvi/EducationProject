namespace EducationProject
{
    partial class TaskForm
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
            this.educationProjectDataSet = new EducationProject.EducationProjectDataSet();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new EducationProject.EducationProjectDataSetTableAdapters.TaskTableAdapter();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAddTask = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tbxTaskStudentId = new System.Windows.Forms.TextBox();
            this.tbxTaskCategoryId = new System.Windows.Forms.TextBox();
            this.tbxTaskDetails = new System.Windows.Forms.TextBox();
            this.tbxTaskPoint = new System.Windows.Forms.TextBox();
            this.tbxTaskStartDate = new System.Windows.Forms.TextBox();
            this.tbxTaskDuration = new System.Windows.Forms.TextBox();
            this.tbxTaskUrl = new System.Windows.Forms.TextBox();
            this.tbxTaskName = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblTaskCategoryId = new System.Windows.Forms.Label();
            this.lblTaskDetails = new System.Windows.Forms.Label();
            this.lblTaskPoint = new System.Windows.Forms.Label();
            this.lblTaskDuration = new System.Windows.Forms.Label();
            this.lblTaskStartDate = new System.Windows.Forms.Label();
            this.lblTaskUrl = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.gbxAddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.taskUrlDataGridViewTextBoxColumn,
            this.taskStartDateDataGridViewTextBoxColumn,
            this.taskDurationDataGridViewTextBoxColumn,
            this.taskPointDataGridViewTextBoxColumn,
            this.taskDetailsDataGridViewTextBoxColumn,
            this.taskCategoryIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // educationProjectDataSet
            // 
            this.educationProjectDataSet.DataSetName = "EducationProjectDataSet";
            this.educationProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.educationProjectDataSet;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            // 
            // taskUrlDataGridViewTextBoxColumn
            // 
            this.taskUrlDataGridViewTextBoxColumn.DataPropertyName = "TaskUrl";
            this.taskUrlDataGridViewTextBoxColumn.HeaderText = "TaskUrl";
            this.taskUrlDataGridViewTextBoxColumn.Name = "taskUrlDataGridViewTextBoxColumn";
            // 
            // taskStartDateDataGridViewTextBoxColumn
            // 
            this.taskStartDateDataGridViewTextBoxColumn.DataPropertyName = "TaskStartDate";
            this.taskStartDateDataGridViewTextBoxColumn.HeaderText = "TaskStartDate";
            this.taskStartDateDataGridViewTextBoxColumn.Name = "taskStartDateDataGridViewTextBoxColumn";
            // 
            // taskDurationDataGridViewTextBoxColumn
            // 
            this.taskDurationDataGridViewTextBoxColumn.DataPropertyName = "TaskDuration";
            this.taskDurationDataGridViewTextBoxColumn.HeaderText = "TaskDuration";
            this.taskDurationDataGridViewTextBoxColumn.Name = "taskDurationDataGridViewTextBoxColumn";
            // 
            // taskPointDataGridViewTextBoxColumn
            // 
            this.taskPointDataGridViewTextBoxColumn.DataPropertyName = "TaskPoint";
            this.taskPointDataGridViewTextBoxColumn.HeaderText = "TaskPoint";
            this.taskPointDataGridViewTextBoxColumn.Name = "taskPointDataGridViewTextBoxColumn";
            // 
            // taskDetailsDataGridViewTextBoxColumn
            // 
            this.taskDetailsDataGridViewTextBoxColumn.DataPropertyName = "TaskDetails";
            this.taskDetailsDataGridViewTextBoxColumn.HeaderText = "TaskDetails";
            this.taskDetailsDataGridViewTextBoxColumn.Name = "taskDetailsDataGridViewTextBoxColumn";
            // 
            // taskCategoryIdDataGridViewTextBoxColumn
            // 
            this.taskCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "TaskCategoryId";
            this.taskCategoryIdDataGridViewTextBoxColumn.HeaderText = "TaskCategoryId";
            this.taskCategoryIdDataGridViewTextBoxColumn.Name = "taskCategoryIdDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // gbxAddTask
            // 
            this.gbxAddTask.Controls.Add(this.btnAddTask);
            this.gbxAddTask.Controls.Add(this.tbxTaskStudentId);
            this.gbxAddTask.Controls.Add(this.tbxTaskCategoryId);
            this.gbxAddTask.Controls.Add(this.tbxTaskDetails);
            this.gbxAddTask.Controls.Add(this.tbxTaskPoint);
            this.gbxAddTask.Controls.Add(this.tbxTaskStartDate);
            this.gbxAddTask.Controls.Add(this.tbxTaskDuration);
            this.gbxAddTask.Controls.Add(this.tbxTaskUrl);
            this.gbxAddTask.Controls.Add(this.tbxTaskName);
            this.gbxAddTask.Controls.Add(this.lblStudentId);
            this.gbxAddTask.Controls.Add(this.lblTaskCategoryId);
            this.gbxAddTask.Controls.Add(this.lblTaskDetails);
            this.gbxAddTask.Controls.Add(this.lblTaskPoint);
            this.gbxAddTask.Controls.Add(this.lblTaskDuration);
            this.gbxAddTask.Controls.Add(this.lblTaskStartDate);
            this.gbxAddTask.Controls.Add(this.lblTaskUrl);
            this.gbxAddTask.Controls.Add(this.lblTaskName);
            this.gbxAddTask.Location = new System.Drawing.Point(74, 168);
            this.gbxAddTask.Name = "gbxAddTask";
            this.gbxAddTask.Size = new System.Drawing.Size(240, 326);
            this.gbxAddTask.TabIndex = 11;
            this.gbxAddTask.TabStop = false;
            this.gbxAddTask.Text = "Add Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(110, 301);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 23);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // tbxTaskStudentId
            // 
            this.tbxTaskStudentId.Location = new System.Drawing.Point(110, 260);
            this.tbxTaskStudentId.Name = "tbxTaskStudentId";
            this.tbxTaskStudentId.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskStudentId.TabIndex = 23;
            // 
            // tbxTaskCategoryId
            // 
            this.tbxTaskCategoryId.Location = new System.Drawing.Point(110, 224);
            this.tbxTaskCategoryId.Name = "tbxTaskCategoryId";
            this.tbxTaskCategoryId.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskCategoryId.TabIndex = 22;
            // 
            // tbxTaskDetails
            // 
            this.tbxTaskDetails.Location = new System.Drawing.Point(110, 188);
            this.tbxTaskDetails.Name = "tbxTaskDetails";
            this.tbxTaskDetails.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskDetails.TabIndex = 21;
            // 
            // tbxTaskPoint
            // 
            this.tbxTaskPoint.Location = new System.Drawing.Point(110, 152);
            this.tbxTaskPoint.Name = "tbxTaskPoint";
            this.tbxTaskPoint.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskPoint.TabIndex = 20;
            // 
            // tbxTaskStartDate
            // 
            this.tbxTaskStartDate.Location = new System.Drawing.Point(110, 77);
            this.tbxTaskStartDate.Name = "tbxTaskStartDate";
            this.tbxTaskStartDate.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskStartDate.TabIndex = 19;
            // 
            // tbxTaskDuration
            // 
            this.tbxTaskDuration.Location = new System.Drawing.Point(110, 115);
            this.tbxTaskDuration.Name = "tbxTaskDuration";
            this.tbxTaskDuration.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskDuration.TabIndex = 18;
            // 
            // tbxTaskUrl
            // 
            this.tbxTaskUrl.Location = new System.Drawing.Point(110, 45);
            this.tbxTaskUrl.Name = "tbxTaskUrl";
            this.tbxTaskUrl.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskUrl.TabIndex = 17;
            // 
            // tbxTaskName
            // 
            this.tbxTaskName.Location = new System.Drawing.Point(110, 13);
            this.tbxTaskName.Name = "tbxTaskName";
            this.tbxTaskName.Size = new System.Drawing.Size(100, 20);
            this.tbxTaskName.TabIndex = 10;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(6, 264);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(56, 13);
            this.lblStudentId.TabIndex = 16;
            this.lblStudentId.Text = "Student Id";
            // 
            // lblTaskCategoryId
            // 
            this.lblTaskCategoryId.AutoSize = true;
            this.lblTaskCategoryId.Location = new System.Drawing.Point(6, 228);
            this.lblTaskCategoryId.Name = "lblTaskCategoryId";
            this.lblTaskCategoryId.Size = new System.Drawing.Size(88, 13);
            this.lblTaskCategoryId.TabIndex = 15;
            this.lblTaskCategoryId.Text = "Task Category Id";
            // 
            // lblTaskDetails
            // 
            this.lblTaskDetails.AutoSize = true;
            this.lblTaskDetails.Location = new System.Drawing.Point(6, 192);
            this.lblTaskDetails.Name = "lblTaskDetails";
            this.lblTaskDetails.Size = new System.Drawing.Size(66, 13);
            this.lblTaskDetails.TabIndex = 14;
            this.lblTaskDetails.Text = "Task Details";
            // 
            // lblTaskPoint
            // 
            this.lblTaskPoint.AutoSize = true;
            this.lblTaskPoint.Location = new System.Drawing.Point(6, 159);
            this.lblTaskPoint.Name = "lblTaskPoint";
            this.lblTaskPoint.Size = new System.Drawing.Size(58, 13);
            this.lblTaskPoint.TabIndex = 13;
            this.lblTaskPoint.Text = "Task Point";
            // 
            // lblTaskDuration
            // 
            this.lblTaskDuration.AutoSize = true;
            this.lblTaskDuration.Location = new System.Drawing.Point(6, 119);
            this.lblTaskDuration.Name = "lblTaskDuration";
            this.lblTaskDuration.Size = new System.Drawing.Size(74, 13);
            this.lblTaskDuration.TabIndex = 12;
            this.lblTaskDuration.Text = "Task Duration";
            // 
            // lblTaskStartDate
            // 
            this.lblTaskStartDate.AutoSize = true;
            this.lblTaskStartDate.Location = new System.Drawing.Point(6, 81);
            this.lblTaskStartDate.Name = "lblTaskStartDate";
            this.lblTaskStartDate.Size = new System.Drawing.Size(82, 13);
            this.lblTaskStartDate.TabIndex = 11;
            this.lblTaskStartDate.Text = "Task Start Date";
            // 
            // lblTaskUrl
            // 
            this.lblTaskUrl.AutoSize = true;
            this.lblTaskUrl.Location = new System.Drawing.Point(8, 45);
            this.lblTaskUrl.Name = "lblTaskUrl";
            this.lblTaskUrl.Size = new System.Drawing.Size(47, 13);
            this.lblTaskUrl.TabIndex = 10;
            this.lblTaskUrl.Text = "Task Url";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(8, 17);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(35, 13);
            this.lblTaskName.TabIndex = 9;
            this.lblTaskName.Text = "Name";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 504);
            this.Controls.Add(this.gbxAddTask);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.gbxAddTask.ResumeLayout(false);
            this.gbxAddTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EducationProjectDataSet educationProjectDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private EducationProjectDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbxAddTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox tbxTaskStudentId;
        private System.Windows.Forms.TextBox tbxTaskCategoryId;
        private System.Windows.Forms.TextBox tbxTaskDetails;
        private System.Windows.Forms.TextBox tbxTaskPoint;
        private System.Windows.Forms.TextBox tbxTaskStartDate;
        private System.Windows.Forms.TextBox tbxTaskDuration;
        private System.Windows.Forms.TextBox tbxTaskUrl;
        private System.Windows.Forms.TextBox tbxTaskName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblTaskCategoryId;
        private System.Windows.Forms.Label lblTaskDetails;
        private System.Windows.Forms.Label lblTaskPoint;
        private System.Windows.Forms.Label lblTaskDuration;
        private System.Windows.Forms.Label lblTaskStartDate;
        private System.Windows.Forms.Label lblTaskUrl;
        private System.Windows.Forms.Label lblTaskName;
    }
}