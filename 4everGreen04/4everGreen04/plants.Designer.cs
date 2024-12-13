namespace _4everGreen04
{
    partial class plants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plants));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.sideBare = new System.Windows.Forms.Panel();
            this.AdminsTab = new System.Windows.Forms.Button();
            this.PostsTab = new System.Windows.Forms.Button();
            this.interactionPostTab = new System.Windows.Forms.Button();
            this.PlantsTasksTab = new System.Windows.Forms.Button();
            this.greenSpaceTab = new System.Windows.Forms.Button();
            this.GreenSpaceMembersTab = new System.Windows.Forms.Button();
            this.UsersTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelPlantID = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.greenSpaceId = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.labelCommunityID = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.sideBare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.buttonCloseForm);
            this.panelTop.Controls.Add(this.formName);
            this.panelTop.Location = new System.Drawing.Point(216, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(709, 80);
            this.panelTop.TabIndex = 6;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseForm.Image")));
            this.buttonCloseForm.Location = new System.Drawing.Point(685, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(24, 20);
            this.buttonCloseForm.TabIndex = 97;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.BackColor = System.Drawing.Color.Transparent;
            this.formName.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.Color.DarkGreen;
            this.formName.Location = new System.Drawing.Point(21, 9);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(120, 46);
            this.formName.TabIndex = 77;
            this.formName.Text = "Plants";
            // 
            // sideBare
            // 
            this.sideBare.BackColor = System.Drawing.Color.Transparent;
            this.sideBare.Controls.Add(this.AdminsTab);
            this.sideBare.Controls.Add(this.PostsTab);
            this.sideBare.Controls.Add(this.interactionPostTab);
            this.sideBare.Controls.Add(this.PlantsTasksTab);
            this.sideBare.Controls.Add(this.greenSpaceTab);
            this.sideBare.Controls.Add(this.GreenSpaceMembersTab);
            this.sideBare.Controls.Add(this.UsersTab);
            this.sideBare.Controls.Add(this.panel1);
            this.sideBare.Location = new System.Drawing.Point(-3, 0);
            this.sideBare.Name = "sideBare";
            this.sideBare.Size = new System.Drawing.Size(219, 543);
            this.sideBare.TabIndex = 8;
            // 
            // AdminsTab
            // 
            this.AdminsTab.BackColor = System.Drawing.Color.Transparent;
            this.AdminsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminsTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.AdminsTab.Image = ((System.Drawing.Image)(resources.GetObject("AdminsTab.Image")));
            this.AdminsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminsTab.Location = new System.Drawing.Point(2, 118);
            this.AdminsTab.Name = "AdminsTab";
            this.AdminsTab.Size = new System.Drawing.Size(218, 38);
            this.AdminsTab.TabIndex = 37;
            this.AdminsTab.Text = "Admins";
            this.AdminsTab.UseVisualStyleBackColor = false;
            this.AdminsTab.Click += new System.EventHandler(this.AdminsTab_Click_1);
            // 
            // PostsTab
            // 
            this.PostsTab.BackColor = System.Drawing.Color.Transparent;
            this.PostsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostsTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostsTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.PostsTab.Image = ((System.Drawing.Image)(resources.GetObject("PostsTab.Image")));
            this.PostsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PostsTab.Location = new System.Drawing.Point(2, 212);
            this.PostsTab.Name = "PostsTab";
            this.PostsTab.Size = new System.Drawing.Size(218, 38);
            this.PostsTab.TabIndex = 35;
            this.PostsTab.Text = "Posts";
            this.PostsTab.UseVisualStyleBackColor = false;
            this.PostsTab.Click += new System.EventHandler(this.PostsTab_Click);
            // 
            // interactionPostTab
            // 
            this.interactionPostTab.BackColor = System.Drawing.Color.Transparent;
            this.interactionPostTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interactionPostTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactionPostTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.interactionPostTab.Image = ((System.Drawing.Image)(resources.GetObject("interactionPostTab.Image")));
            this.interactionPostTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.interactionPostTab.Location = new System.Drawing.Point(2, 262);
            this.interactionPostTab.Name = "interactionPostTab";
            this.interactionPostTab.Size = new System.Drawing.Size(218, 38);
            this.interactionPostTab.TabIndex = 34;
            this.interactionPostTab.Text = "Interactions";
            this.interactionPostTab.UseVisualStyleBackColor = false;
            this.interactionPostTab.Click += new System.EventHandler(this.interactionPostTab_Click_1);
            // 
            // PlantsTasksTab
            // 
            this.PlantsTasksTab.BackColor = System.Drawing.Color.Transparent;
            this.PlantsTasksTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlantsTasksTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantsTasksTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.PlantsTasksTab.Image = ((System.Drawing.Image)(resources.GetObject("PlantsTasksTab.Image")));
            this.PlantsTasksTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlantsTasksTab.Location = new System.Drawing.Point(2, 413);
            this.PlantsTasksTab.Name = "PlantsTasksTab";
            this.PlantsTasksTab.Size = new System.Drawing.Size(218, 38);
            this.PlantsTasksTab.TabIndex = 33;
            this.PlantsTasksTab.Text = "Tasks";
            this.PlantsTasksTab.UseVisualStyleBackColor = false;
            this.PlantsTasksTab.Click += new System.EventHandler(this.PlantsTasksTab_Click_1);
            // 
            // greenSpaceTab
            // 
            this.greenSpaceTab.BackColor = System.Drawing.Color.Transparent;
            this.greenSpaceTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenSpaceTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenSpaceTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.greenSpaceTab.Image = ((System.Drawing.Image)(resources.GetObject("greenSpaceTab.Image")));
            this.greenSpaceTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenSpaceTab.Location = new System.Drawing.Point(2, 311);
            this.greenSpaceTab.Name = "greenSpaceTab";
            this.greenSpaceTab.Size = new System.Drawing.Size(218, 38);
            this.greenSpaceTab.TabIndex = 32;
            this.greenSpaceTab.Text = "Green Space";
            this.greenSpaceTab.UseVisualStyleBackColor = false;
            this.greenSpaceTab.Click += new System.EventHandler(this.greenSpaceTab_Click_1);
            // 
            // GreenSpaceMembersTab
            // 
            this.GreenSpaceMembersTab.BackColor = System.Drawing.Color.Transparent;
            this.GreenSpaceMembersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenSpaceMembersTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenSpaceMembersTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.GreenSpaceMembersTab.Image = ((System.Drawing.Image)(resources.GetObject("GreenSpaceMembersTab.Image")));
            this.GreenSpaceMembersTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GreenSpaceMembersTab.Location = new System.Drawing.Point(2, 361);
            this.GreenSpaceMembersTab.Name = "GreenSpaceMembersTab";
            this.GreenSpaceMembersTab.Size = new System.Drawing.Size(218, 38);
            this.GreenSpaceMembersTab.TabIndex = 30;
            this.GreenSpaceMembersTab.Text = "Members";
            this.GreenSpaceMembersTab.UseVisualStyleBackColor = false;
            this.GreenSpaceMembersTab.Click += new System.EventHandler(this.GreenSpaceMembersTab_Click_1);
            // 
            // UsersTab
            // 
            this.UsersTab.BackColor = System.Drawing.Color.Transparent;
            this.UsersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.UsersTab.Image = ((System.Drawing.Image)(resources.GetObject("UsersTab.Image")));
            this.UsersTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersTab.Location = new System.Drawing.Point(3, 168);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Size = new System.Drawing.Size(218, 38);
            this.UsersTab.TabIndex = 29;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = false;
            this.UsersTab.Click += new System.EventHandler(this.UsersTab_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 80);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(575, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 262);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDelete.Location = new System.Drawing.Point(690, 458);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 29);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSelect.Location = new System.Drawing.Point(293, 458);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 29);
            this.buttonSelect.TabIndex = 40;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonUpdate.Location = new System.Drawing.Point(560, 458);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 29);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Transparent;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonInsert.Location = new System.Drawing.Point(418, 458);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 29);
            this.buttonInsert.TabIndex = 38;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDueDate.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelDueDate.Location = new System.Drawing.Point(242, 376);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(0, 17);
            this.labelDueDate.TabIndex = 93;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.BackColor = System.Drawing.Color.Transparent;
            this.labelUserID.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelUserID.Location = new System.Drawing.Point(245, 225);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(107, 17);
            this.labelUserID.TabIndex = 89;
            this.labelUserID.Text = "GreenSpace ID";
            // 
            // labelPlantID
            // 
            this.labelPlantID.AutoSize = true;
            this.labelPlantID.BackColor = System.Drawing.Color.Transparent;
            this.labelPlantID.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlantID.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPlantID.Location = new System.Drawing.Point(245, 345);
            this.labelPlantID.Name = "labelPlantID";
            this.labelPlantID.Size = new System.Drawing.Size(40, 17);
            this.labelPlantID.TabIndex = 88;
            this.labelPlantID.Text = "Type";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.BackColor = System.Drawing.Color.Transparent;
            this.labelTaskName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskName.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTaskName.Location = new System.Drawing.Point(246, 292);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(45, 17);
            this.labelTaskName.TabIndex = 87;
            this.labelTaskName.Text = "Name";
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeBox.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.typeBox.Location = new System.Drawing.Point(361, 339);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(194, 32);
            this.typeBox.TabIndex = 86;
            // 
            // greenSpaceId
            // 
            this.greenSpaceId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.greenSpaceId.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenSpaceId.ForeColor = System.Drawing.Color.DarkGreen;
            this.greenSpaceId.Location = new System.Drawing.Point(363, 223);
            this.greenSpaceId.Multiline = true;
            this.greenSpaceId.Name = "greenSpaceId";
            this.greenSpaceId.Size = new System.Drawing.Size(194, 32);
            this.greenSpaceId.TabIndex = 85;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBox.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.nameBox.Location = new System.Drawing.Point(363, 282);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(194, 32);
            this.nameBox.TabIndex = 84;
            // 
            // labelCommunityID
            // 
            this.labelCommunityID.AutoSize = true;
            this.labelCommunityID.BackColor = System.Drawing.Color.Transparent;
            this.labelCommunityID.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommunityID.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelCommunityID.Location = new System.Drawing.Point(246, 161);
            this.labelCommunityID.Name = "labelCommunityID";
            this.labelCommunityID.Size = new System.Drawing.Size(67, 17);
            this.labelCommunityID.TabIndex = 83;
            this.labelCommunityID.Text = "Plant ID";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idBox.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.idBox.Location = new System.Drawing.Point(361, 158);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(194, 32);
            this.idBox.TabIndex = 82;
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Transparent;
            this.labelLogOut.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLogOut.Location = new System.Drawing.Point(827, 96);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(86, 25);
            this.labelLogOut.TabIndex = 96;
            this.labelLogOut.Text = "Log Out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // plants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 542);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelPlantID);
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.greenSpaceId);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelCommunityID);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sideBare);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "plants";
            this.Text = "communities";
            this.Load += new System.EventHandler(this.communities_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.sideBare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel sideBare;
        private System.Windows.Forms.Button PostsTab;
        private System.Windows.Forms.Button interactionPostTab;
        private System.Windows.Forms.Button PlantsTasksTab;
        private System.Windows.Forms.Button greenSpaceTab;
        private System.Windows.Forms.Button GreenSpaceMembersTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AdminsTab;
        private System.Windows.Forms.Button UsersTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelPlantID;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox greenSpaceId;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label labelCommunityID;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}