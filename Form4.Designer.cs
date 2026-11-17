namespace NoteSpaceForm
{
    partial class Form4
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnNotes = new Button();
            btnDashboard = new Button();
            lblRole = new Label();
            lblUsername = new Label();
            picProfile = new PictureBox();
            lblNoteSubtitle = new Label();
            lblTasksTitle = new Label();
            pnlTotalTasks = new Panel();
            label1 = new Label();
            lblTotalTitle = new Label();
            pnlCompletedTask = new Panel();
            lblCompletedNumber = new Label();
            lblCompletedTitle = new Label();
            pnlPending = new Panel();
            lblPendingNumber = new Label();
            lblPendingTitle = new Label();
            pnlAddTask = new Panel();
            btnAddTask = new Button();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            dtpDeadline = new DateTimePicker();
            lblDeadline = new Label();
            txtTaskDescription = new TextBox();
            lblTaskDescription = new Label();
            txtTaskName = new TextBox();
            lblTaskName = new Label();
            lblAddTask = new Label();
            pnlTaskOverview = new Panel();
            lblTaskOverview = new Label();
            lblSearchTask = new Label();
            txtSearchTask = new TextBox();
            lstTask = new ListBox();
            grpTaskStatus = new GroupBox();
            lblLow = new Label();
            lblMedium = new Label();
            lblHigh = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            pnlTotalTasks.SuspendLayout();
            pnlCompletedTask.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlAddTask.SuspendLayout();
            pnlTaskOverview.SuspendLayout();
            grpTaskStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(30, 36, 55);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnCalendar);
            pnlSidebar.Controls.Add(btnTasks);
            pnlSidebar.Controls.Add(btnNotes);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(lblUsername);
            pnlSidebar.Controls.Add(picProfile);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 778);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(65, 73, 95);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(25, 450);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 45);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(65, 73, 95);
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.Location = new Point(25, 395);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(200, 45);
            btnCalendar.TabIndex = 14;
            btnCalendar.Text = "Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = false;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.LightGray;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTasks.ForeColor = Color.FromArgb(37, 44, 67);
            btnTasks.Location = new Point(25, 340);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(200, 45);
            btnTasks.TabIndex = 13;
            btnTasks.Text = "My Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.UseVisualStyleBackColor = false;
            // 
            // btnNotes
            // 
            btnNotes.BackColor = Color.FromArgb(65, 73, 95);
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNotes.ForeColor = Color.White;
            btnNotes.Location = new Point(25, 284);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(200, 45);
            btnNotes.TabIndex = 12;
            btnNotes.Text = "My Notes";
            btnNotes.TextAlign = ContentAlignment.MiddleLeft;
            btnNotes.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(65, 73, 95);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(25, 230);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 11;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.LightGray;
            lblRole.Location = new Point(45, 160);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(202, 34);
            lblRole.TabIndex = 10;
            lblRole.Text = "NoteSpace Member";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(45, 125);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(160, 35);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Admin User";
            lblUsername.UseMnemonic = false;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(65, 73, 95);
            picProfile.Location = new Point(85, 35);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(80, 80);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 8;
            picProfile.TabStop = false;
            // 
            // lblNoteSubtitle
            // 
            lblNoteSubtitle.ForeColor = Color.LightGray;
            lblNoteSubtitle.Location = new Point(290, 99);
            lblNoteSubtitle.Name = "lblNoteSubtitle";
            lblNoteSubtitle.Size = new Size(400, 30);
            lblNoteSubtitle.TabIndex = 18;
            lblNoteSubtitle.Text = "Manage your daily activities";
            lblNoteSubtitle.Click += lblNoteSubtitle_Click;
            // 
            // lblTasksTitle
            // 
            lblTasksTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTasksTitle.ForeColor = Color.White;
            lblTasksTitle.Location = new Point(285, 25);
            lblTasksTitle.Name = "lblTasksTitle";
            lblTasksTitle.Size = new Size(400, 80);
            lblTasksTitle.TabIndex = 17;
            lblTasksTitle.Text = "My Tasks";
            // 
            // pnlTotalTasks
            // 
            pnlTotalTasks.BackColor = Color.FromArgb(250, 225, 220);
            pnlTotalTasks.Controls.Add(label1);
            pnlTotalTasks.Controls.Add(lblTotalTitle);
            pnlTotalTasks.Location = new Point(280, 150);
            pnlTotalTasks.Name = "pnlTotalTasks";
            pnlTotalTasks.Size = new Size(265, 125);
            pnlTotalTasks.TabIndex = 19;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(37, 44, 67);
            label1.Location = new Point(82, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 66);
            label1.TabIndex = 1;
            label1.Text = "12";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(37, 44, 67);
            lblTotalTitle.Location = new Point(14, 7);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(220, 30);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Tasks";
            // 
            // pnlCompletedTask
            // 
            pnlCompletedTask.BackColor = Color.FromArgb(220, 175, 245);
            pnlCompletedTask.Controls.Add(lblCompletedNumber);
            pnlCompletedTask.Controls.Add(lblCompletedTitle);
            pnlCompletedTask.Location = new Point(584, 150);
            pnlCompletedTask.Name = "pnlCompletedTask";
            pnlCompletedTask.Size = new Size(265, 125);
            pnlCompletedTask.TabIndex = 20;
            // 
            // lblCompletedNumber
            // 
            lblCompletedNumber.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblCompletedNumber.ForeColor = Color.FromArgb(37, 44, 67);
            lblCompletedNumber.Location = new Point(91, 43);
            lblCompletedNumber.Name = "lblCompletedNumber";
            lblCompletedNumber.Size = new Size(96, 66);
            lblCompletedNumber.TabIndex = 2;
            lblCompletedNumber.Text = "8";
            lblCompletedNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletedTitle
            // 
            lblCompletedTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCompletedTitle.ForeColor = Color.FromArgb(37, 44, 67);
            lblCompletedTitle.Location = new Point(14, 7);
            lblCompletedTitle.Name = "lblCompletedTitle";
            lblCompletedTitle.Size = new Size(220, 40);
            lblCompletedTitle.TabIndex = 1;
            lblCompletedTitle.Text = "Completed";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.FromArgb(245, 202, 98);
            pnlPending.Controls.Add(lblPendingNumber);
            pnlPending.Controls.Add(lblPendingTitle);
            pnlPending.Location = new Point(894, 150);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(265, 125);
            pnlPending.TabIndex = 21;
            // 
            // lblPendingNumber
            // 
            lblPendingNumber.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblPendingNumber.ForeColor = Color.FromArgb(37, 44, 67);
            lblPendingNumber.Location = new Point(94, 43);
            lblPendingNumber.Name = "lblPendingNumber";
            lblPendingNumber.Size = new Size(96, 66);
            lblPendingNumber.TabIndex = 3;
            lblPendingNumber.Text = "4";
            lblPendingNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.FromArgb(37, 44, 67);
            lblPendingTitle.Location = new Point(12, 4);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(220, 40);
            lblPendingTitle.TabIndex = 2;
            lblPendingTitle.Text = "Pending";
            lblPendingTitle.Click += label2_Click;
            // 
            // pnlAddTask
            // 
            pnlAddTask.BackColor = Color.FromArgb(245, 241, 234);
            pnlAddTask.Controls.Add(btnAddTask);
            pnlAddTask.Controls.Add(lblPriority);
            pnlAddTask.Controls.Add(cmbPriority);
            pnlAddTask.Controls.Add(dtpDeadline);
            pnlAddTask.Controls.Add(lblDeadline);
            pnlAddTask.Controls.Add(txtTaskDescription);
            pnlAddTask.Controls.Add(lblTaskDescription);
            pnlAddTask.Controls.Add(txtTaskName);
            pnlAddTask.Controls.Add(lblTaskName);
            pnlAddTask.Controls.Add(lblAddTask);
            pnlAddTask.Location = new Point(280, 300);
            pnlAddTask.Name = "pnlAddTask";
            pnlAddTask.Size = new Size(390, 452);
            pnlAddTask.TabIndex = 22;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(99, 67, 190);
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(25, 403);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(336, 40);
            btnAddTask.TabIndex = 25;
            btnAddTask.Text = "ADD TASK";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // lblPriority
            // 
            lblPriority.BackColor = Color.White;
            lblPriority.Location = new Point(24, 349);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(104, 34);
            lblPriority.TabIndex = 24;
            lblPriority.Text = "Priority";
            lblPriority.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(130, 348);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(230, 36);
            cmbPriority.TabIndex = 23;
            // 
            // dtpDeadline
            // 
            dtpDeadline.Format = DateTimePickerFormat.Short;
            dtpDeadline.Location = new Point(25, 310);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(335, 34);
            dtpDeadline.TabIndex = 6;
            // 
            // lblDeadline
            // 
            lblDeadline.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeadline.Location = new Point(25, 280);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(200, 28);
            lblDeadline.TabIndex = 5;
            lblDeadline.Text = "Due Date";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(25, 193);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.ScrollBars = ScrollBars.Vertical;
            txtTaskDescription.Size = new Size(335, 75);
            txtTaskDescription.TabIndex = 4;
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaskDescription.Location = new Point(25, 160);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(200, 31);
            lblTaskDescription.TabIndex = 3;
            lblTaskDescription.Text = "Description";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(25, 110);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(335, 34);
            txtTaskName.TabIndex = 2;
            // 
            // lblTaskName
            // 
            lblTaskName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaskName.Location = new Point(25, 80);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(200, 31);
            lblTaskName.TabIndex = 1;
            lblTaskName.Text = "Task Name";
            // 
            // lblAddTask
            // 
            lblAddTask.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblAddTask.ForeColor = Color.FromArgb(37, 44, 67);
            lblAddTask.Location = new Point(25, 20);
            lblAddTask.Name = "lblAddTask";
            lblAddTask.Size = new Size(330, 49);
            lblAddTask.TabIndex = 0;
            lblAddTask.Text = "Add New Task";
            // 
            // pnlTaskOverview
            // 
            pnlTaskOverview.BackColor = Color.FromArgb(220, 175, 245);
            pnlTaskOverview.Controls.Add(grpTaskStatus);
            pnlTaskOverview.Controls.Add(lstTask);
            pnlTaskOverview.Controls.Add(txtSearchTask);
            pnlTaskOverview.Controls.Add(lblSearchTask);
            pnlTaskOverview.Controls.Add(lblTaskOverview);
            pnlTaskOverview.Location = new Point(689, 300);
            pnlTaskOverview.Name = "pnlTaskOverview";
            pnlTaskOverview.Size = new Size(470, 452);
            pnlTaskOverview.TabIndex = 23;
            // 
            // lblTaskOverview
            // 
            lblTaskOverview.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTaskOverview.ForeColor = Color.FromArgb(37, 44, 67);
            lblTaskOverview.Location = new Point(20, 20);
            lblTaskOverview.Name = "lblTaskOverview";
            lblTaskOverview.Size = new Size(420, 49);
            lblTaskOverview.TabIndex = 1;
            lblTaskOverview.Text = "Task Overview";
            // 
            // lblSearchTask
            // 
            lblSearchTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearchTask.Location = new Point(25, 77);
            lblSearchTask.Name = "lblSearchTask";
            lblSearchTask.Size = new Size(150, 27);
            lblSearchTask.TabIndex = 2;
            lblSearchTask.Text = "Search Task";
            // 
            // txtSearchTask
            // 
            txtSearchTask.Location = new Point(25, 108);
            txtSearchTask.Name = "txtSearchTask";
            txtSearchTask.Size = new Size(420, 34);
            txtSearchTask.TabIndex = 3;
            // 
            // lstTask
            // 
            lstTask.BackColor = Color.White;
            lstTask.BorderStyle = BorderStyle.FixedSingle;
            lstTask.ForeColor = Color.FromArgb(37, 44, 67);
            lstTask.FormattingEnabled = true;
            lstTask.Location = new Point(25, 158);
            lstTask.Name = "lstTask";
            lstTask.Size = new Size(420, 170);
            lstTask.TabIndex = 4;
            lstTask.SelectedIndexChanged += lstTask_SelectedIndexChanged;
            // 
            // grpTaskStatus
            // 
            grpTaskStatus.Controls.Add(lblHigh);
            grpTaskStatus.Controls.Add(lblMedium);
            grpTaskStatus.Controls.Add(lblLow);
            grpTaskStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpTaskStatus.Location = new Point(25, 345);
            grpTaskStatus.Name = "grpTaskStatus";
            grpTaskStatus.Size = new Size(420, 71);
            grpTaskStatus.TabIndex = 5;
            grpTaskStatus.TabStop = false;
            grpTaskStatus.Text = "Task Status";
            // 
            // lblLow
            // 
            lblLow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLow.ForeColor = Color.Green;
            lblLow.Location = new Point(35, 30);
            lblLow.Name = "lblLow";
            lblLow.Size = new Size(100, 35);
            lblLow.TabIndex = 0;
            lblLow.Text = "Low";
            lblLow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMedium
            // 
            lblMedium.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMedium.ForeColor = Color.Yellow;
            lblMedium.Location = new Point(160, 30);
            lblMedium.Name = "lblMedium";
            lblMedium.Size = new Size(100, 35);
            lblMedium.TabIndex = 1;
            lblMedium.Text = "Medium";
            lblMedium.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHigh
            // 
            lblHigh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHigh.ForeColor = Color.Red;
            lblHigh.Location = new Point(288, 29);
            lblHigh.Name = "lblHigh";
            lblHigh.Size = new Size(100, 35);
            lblHigh.TabIndex = 2;
            lblHigh.Text = "High";
            lblHigh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 44, 67);
            ClientSize = new Size(1296, 777);
            Controls.Add(pnlTaskOverview);
            Controls.Add(pnlAddTask);
            Controls.Add(pnlPending);
            Controls.Add(pnlCompletedTask);
            Controls.Add(pnlTotalTasks);
            Controls.Add(lblNoteSubtitle);
            Controls.Add(lblTasksTitle);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(37, 44, 67);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteSpace - My Tasks";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            pnlTotalTasks.ResumeLayout(false);
            pnlCompletedTask.ResumeLayout(false);
            pnlPending.ResumeLayout(false);
            pnlAddTask.ResumeLayout(false);
            pnlAddTask.PerformLayout();
            pnlTaskOverview.ResumeLayout(false);
            pnlTaskOverview.PerformLayout();
            grpTaskStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnCalendar;
        private Button btnTasks;
        private Button btnNotes;
        private Button btnDashboard;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox picProfile;
        private Label lblNoteSubtitle;
        private Label lblTasksTitle;
        private Panel pnlTotalTasks;
        private Label lblTotalTitle;
        private Panel pnlCompletedTask;
        private Label lblCompletedTitle;
        private Label label1;
        private Label lblCompletedNumber;
        private Panel pnlPending;
        private Label lblPendingNumber;
        private Label lblPendingTitle;
        private Panel pnlAddTask;
        private Label lblAddTask;
        private Label lblTaskName;
        private Label lblDeadline;
        private TextBox txtTaskDescription;
        private Label lblTaskDescription;
        private TextBox txtTaskName;
        private DateTimePicker dtpDeadline;
        private ComboBox cmbPriority;
        private Label lblPriority;
        private Button btnAddTask;
        private Panel pnlTaskOverview;
        private Label lblTaskOverview;
        private Label lblSearchTask;
        private ListBox lstTask;
        private TextBox txtSearchTask;
        private GroupBox grpTaskStatus;
        private Label lblLow;
        private Label lblHigh;
        private Label lblMedium;
    }
}