namespace NoteSpaceForm
{
    partial class frmNotes
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
            lblNotesTitle = new Label();
            lblNoteSubtitle = new Label();
            pnlNoteEditor = new Panel();
            btnClear = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            chkFavorite = new CheckBox();
            grpNoteType = new GroupBox();
            rdoImportant = new RadioButton();
            rdoPersonal = new RadioButton();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtContent = new TextBox();
            lblContent = new Label();
            txtNoteTitle = new TextBox();
            lblNoteTitle = new Label();
            lblEditorTitle = new Label();
            pnlNotesList = new Panel();
            btnDelete = new Button();
            lstNotes = new ListBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblMyNotes = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            pnlNoteEditor.SuspendLayout();
            grpNoteType.SuspendLayout();
            pnlNotesList.SuspendLayout();
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
            pnlSidebar.TabIndex = 0;
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
            btnTasks.BackColor = Color.FromArgb(65, 73, 95);
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTasks.ForeColor = Color.White;
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
            btnNotes.BackColor = Color.DarkGray;
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNotes.ForeColor = Color.FromArgb(37, 44, 67);
            btnNotes.Location = new Point(25, 285);
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
            // lblNotesTitle
            // 
            lblNotesTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNotesTitle.ForeColor = Color.White;
            lblNotesTitle.Location = new Point(285, 25);
            lblNotesTitle.Name = "lblNotesTitle";
            lblNotesTitle.Size = new Size(400, 79);
            lblNotesTitle.TabIndex = 1;
            lblNotesTitle.Text = "My Notes";
            // 
            // lblNoteSubtitle
            // 
            lblNoteSubtitle.ForeColor = Color.LightGray;
            lblNoteSubtitle.Location = new Point(290, 98);
            lblNoteSubtitle.Name = "lblNoteSubtitle";
            lblNoteSubtitle.Size = new Size(400, 30);
            lblNoteSubtitle.TabIndex = 16;
            lblNoteSubtitle.Text = "Organize your thoughts and ideas";
            // 
            // pnlNoteEditor
            // 
            pnlNoteEditor.BackColor = Color.FromArgb(245, 241, 234);
            pnlNoteEditor.Controls.Add(btnClear);
            pnlNoteEditor.Controls.Add(btnEdit);
            pnlNoteEditor.Controls.Add(btnSave);
            pnlNoteEditor.Controls.Add(chkFavorite);
            pnlNoteEditor.Controls.Add(grpNoteType);
            pnlNoteEditor.Controls.Add(cmbCategory);
            pnlNoteEditor.Controls.Add(lblCategory);
            pnlNoteEditor.Controls.Add(txtContent);
            pnlNoteEditor.Controls.Add(lblContent);
            pnlNoteEditor.Controls.Add(txtNoteTitle);
            pnlNoteEditor.Controls.Add(lblNoteTitle);
            pnlNoteEditor.Controls.Add(lblEditorTitle);
            pnlNoteEditor.ForeColor = Color.FromArgb(37, 44, 67);
            pnlNoteEditor.Location = new Point(280, 135);
            pnlNoteEditor.Name = "pnlNoteEditor";
            pnlNoteEditor.Size = new Size(530, 555);
            pnlNoteEditor.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(210, 210, 210);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(365, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 40);
            btnClear.TabIndex = 11;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(245, 202, 98);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(195, 500);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 40);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "EDIT NOTE";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(99, 67, 190);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(25, 500);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE NOTE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(25, 465);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(182, 32);
            chkFavorite.TabIndex = 8;
            chkFavorite.Text = "Add to Favorites";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // grpNoteType
            // 
            grpNoteType.AutoSize = true;
            grpNoteType.Controls.Add(rdoImportant);
            grpNoteType.Controls.Add(rdoPersonal);
            grpNoteType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpNoteType.Location = new Point(265, 355);
            grpNoteType.Name = "grpNoteType";
            grpNoteType.Size = new Size(235, 125);
            grpNoteType.TabIndex = 7;
            grpNoteType.TabStop = false;
            grpNoteType.Text = "Note Type";
            // 
            // rdoImportant
            // 
            rdoImportant.AutoSize = true;
            rdoImportant.Location = new Point(15, 60);
            rdoImportant.Name = "rdoImportant";
            rdoImportant.Size = new Size(133, 32);
            rdoImportant.TabIndex = 1;
            rdoImportant.TabStop = true;
            rdoImportant.Text = "Important";
            rdoImportant.UseVisualStyleBackColor = true;
            // 
            // rdoPersonal
            // 
            rdoPersonal.AutoSize = true;
            rdoPersonal.Location = new Point(15, 30);
            rdoPersonal.Name = "rdoPersonal";
            rdoPersonal.Size = new Size(117, 32);
            rdoPersonal.TabIndex = 0;
            rdoPersonal.TabStop = true;
            rdoPersonal.Text = "Personal";
            rdoPersonal.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Personal", "Study", "Work", "Ideas" });
            cmbCategory.Location = new Point(25, 386);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 36);
            cmbCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.Location = new Point(25, 355);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(200, 33);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(25, 190);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(475, 150);
            txtContent.TabIndex = 4;
            // 
            // lblContent
            // 
            lblContent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContent.Location = new Point(25, 160);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(200, 35);
            lblContent.TabIndex = 3;
            lblContent.Text = "Description";
            // 
            // txtNoteTitle
            // 
            txtNoteTitle.Font = new Font("Segoe UI", 11F);
            txtNoteTitle.Location = new Point(25, 110);
            txtNoteTitle.Name = "txtNoteTitle";
            txtNoteTitle.Size = new Size(475, 37);
            txtNoteTitle.TabIndex = 2;
            // 
            // lblNoteTitle
            // 
            lblNoteTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoteTitle.Location = new Point(25, 80);
            lblNoteTitle.Name = "lblNoteTitle";
            lblNoteTitle.Size = new Size(200, 28);
            lblNoteTitle.TabIndex = 1;
            lblNoteTitle.Text = "Note Title";
            // 
            // lblEditorTitle
            // 
            lblEditorTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblEditorTitle.ForeColor = Color.FromArgb(37, 44, 67);
            lblEditorTitle.Location = new Point(25, 20);
            lblEditorTitle.Name = "lblEditorTitle";
            lblEditorTitle.Size = new Size(450, 50);
            lblEditorTitle.TabIndex = 0;
            lblEditorTitle.Text = "Create New Note";
            // 
            // pnlNotesList
            // 
            pnlNotesList.BackColor = Color.FromArgb(220, 175, 245);
            pnlNotesList.Controls.Add(btnDelete);
            pnlNotesList.Controls.Add(lstNotes);
            pnlNotesList.Controls.Add(lblSearch);
            pnlNotesList.Controls.Add(txtSearch);
            pnlNotesList.Controls.Add(lblMyNotes);
            pnlNotesList.Location = new Point(830, 135);
            pnlNotesList.Name = "pnlNotesList";
            pnlNotesList.Size = new Size(330, 555);
            pnlNotesList.TabIndex = 18;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(190, 65, 75);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(20, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(285, 45);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE NOTE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lstNotes
            // 
            lstNotes.BackColor = Color.White;
            lstNotes.BorderStyle = BorderStyle.FixedSingle;
            lstNotes.ForeColor = Color.FromArgb(37, 44, 67);
            lstNotes.FormattingEnabled = true;
            lstNotes.Location = new Point(20, 156);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(285, 310);
            lstNotes.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.Location = new Point(20, 87);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(124, 25);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Notes";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 112);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(285, 34);
            txtSearch.TabIndex = 1;
            // 
            // lblMyNotes
            // 
            lblMyNotes.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblMyNotes.ForeColor = Color.FromArgb(37, 44, 67);
            lblMyNotes.Location = new Point(20, 20);
            lblMyNotes.Name = "lblMyNotes";
            lblMyNotes.Size = new Size(285, 50);
            lblMyNotes.TabIndex = 0;
            lblMyNotes.Text = "My Collections";
            // 
            // frmNotes
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 44, 67);
            ClientSize = new Size(1296, 777);
            Controls.Add(pnlNotesList);
            Controls.Add(pnlNoteEditor);
            Controls.Add(lblNoteSubtitle);
            Controls.Add(lblNotesTitle);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " NoteSpace - My Notes";
            Load += frmNotes_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            pnlNoteEditor.ResumeLayout(false);
            pnlNoteEditor.PerformLayout();
            grpNoteType.ResumeLayout(false);
            grpNoteType.PerformLayout();
            pnlNotesList.ResumeLayout(false);
            pnlNotesList.PerformLayout();
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
        private Label lblNotesTitle;
        private Label lblNoteSubtitle;
        private Panel pnlNoteEditor;
        private Label lblEditorTitle;
        private TextBox txtNoteTitle;
        private Label lblNoteTitle;
        private TextBox txtContent;
        private Label lblContent;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private GroupBox grpNoteType;
        private RadioButton rdoImportant;
        private RadioButton rdoPersonal;
        private Button btnClear;
        private Button btnEdit;
        private Button btnSave;
        private CheckBox chkFavorite;
        private Panel pnlNotesList;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblMyNotes;
        private Button btnDelete;
        private ListBox lstNotes;
    }
}