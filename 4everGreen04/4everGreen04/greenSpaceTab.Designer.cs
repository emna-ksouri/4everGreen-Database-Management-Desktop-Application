namespace _4everGreen04
{
    partial class greenSpaceTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(greenSpaceTab));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.sideBare = new System.Windows.Forms.Panel();
            this.AdminsTab = new System.Windows.Forms.Button();
            this.PostsTab = new System.Windows.Forms.Button();
            this.interactionPostTab = new System.Windows.Forms.Button();
            this.PlantsTasksTab = new System.Windows.Forms.Button();
            this.plantTab = new System.Windows.Forms.Button();
            this.GreenSpaceMembersTab = new System.Windows.Forms.Button();
            this.UsersTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelGreenSpaceID = new System.Windows.Forms.Label();
            this.labelRDescription = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.boxDescription = new System.Windows.Forms.TextBox();
            this.boxGreenSpaceID = new System.Windows.Forms.TextBox();
            this.boxUserId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
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
            this.panelTop.TabIndex = 5;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseForm.Image")));
            this.buttonCloseForm.Location = new System.Drawing.Point(685, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(24, 20);
            this.buttonCloseForm.TabIndex = 79;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.BackColor = System.Drawing.Color.Transparent;
            this.formName.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.Color.DarkGreen;
            this.formName.Location = new System.Drawing.Point(19, 18);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(236, 46);
            this.formName.TabIndex = 76;
            this.formName.Text = "Green Space ";
            // 
            // sideBare
            // 
            this.sideBare.BackColor = System.Drawing.Color.Transparent;
            this.sideBare.Controls.Add(this.AdminsTab);
            this.sideBare.Controls.Add(this.PostsTab);
            this.sideBare.Controls.Add(this.interactionPostTab);
            this.sideBare.Controls.Add(this.PlantsTasksTab);
            this.sideBare.Controls.Add(this.plantTab);
            this.sideBare.Controls.Add(this.GreenSpaceMembersTab);
            this.sideBare.Controls.Add(this.UsersTab);
            this.sideBare.Controls.Add(this.panel1);
            this.sideBare.Location = new System.Drawing.Point(-2, 0);
            this.sideBare.Name = "sideBare";
            this.sideBare.Size = new System.Drawing.Size(219, 543);
            this.sideBare.TabIndex = 7;
            // 
            // AdminsTab
            // 
            this.AdminsTab.BackColor = System.Drawing.Color.Transparent;
            this.AdminsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminsTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.AdminsTab.Image = ((System.Drawing.Image)(resources.GetObject("AdminsTab.Image")));
            this.AdminsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminsTab.Location = new System.Drawing.Point(2, 130);
            this.AdminsTab.Name = "AdminsTab";
            this.AdminsTab.Size = new System.Drawing.Size(218, 38);
            this.AdminsTab.TabIndex = 37;
            this.AdminsTab.Text = "Admins";
            this.AdminsTab.UseVisualStyleBackColor = false;
            this.AdminsTab.Click += new System.EventHandler(this.AdminsTab_Click);
            // 
            // PostsTab
            // 
            this.PostsTab.BackColor = System.Drawing.Color.Transparent;
            this.PostsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostsTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostsTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.PostsTab.Image = ((System.Drawing.Image)(resources.GetObject("PostsTab.Image")));
            this.PostsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PostsTab.Location = new System.Drawing.Point(3, 264);
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
            this.interactionPostTab.Location = new System.Drawing.Point(2, 308);
            this.interactionPostTab.Name = "interactionPostTab";
            this.interactionPostTab.Size = new System.Drawing.Size(218, 38);
            this.interactionPostTab.TabIndex = 34;
            this.interactionPostTab.Text = "Interactions";
            this.interactionPostTab.UseVisualStyleBackColor = false;
            this.interactionPostTab.Click += new System.EventHandler(this.interactionPostTab_Click);
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
            this.PlantsTasksTab.Click += new System.EventHandler(this.PlantsTasksTab_Click);
            // 
            // plantTab
            // 
            this.plantTab.BackColor = System.Drawing.Color.Transparent;
            this.plantTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plantTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.plantTab.Image = ((System.Drawing.Image)(resources.GetObject("plantTab.Image")));
            this.plantTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plantTab.Location = new System.Drawing.Point(3, 220);
            this.plantTab.Name = "plantTab";
            this.plantTab.Size = new System.Drawing.Size(218, 38);
            this.plantTab.TabIndex = 31;
            this.plantTab.Text = "Plants";
            this.plantTab.UseVisualStyleBackColor = false;
            this.plantTab.Click += new System.EventHandler(this.plantTab_Click);
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
            this.GreenSpaceMembersTab.Click += new System.EventHandler(this.GreenSpaceMembersTab_Click);
            // 
            // UsersTab
            // 
            this.UsersTab.BackColor = System.Drawing.Color.Transparent;
            this.UsersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersTab.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.UsersTab.Image = ((System.Drawing.Image)(resources.GetObject("UsersTab.Image")));
            this.UsersTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersTab.Location = new System.Drawing.Point(2, 176);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Size = new System.Drawing.Size(218, 38);
            this.UsersTab.TabIndex = 29;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = false;
            this.UsersTab.Click += new System.EventHandler(this.UsersTab_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(573, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 262);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDelete.Location = new System.Drawing.Point(692, 461);
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
            this.buttonSelect.Location = new System.Drawing.Point(295, 461);
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
            this.buttonUpdate.Location = new System.Drawing.Point(562, 461);
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
            this.buttonInsert.Location = new System.Drawing.Point(420, 461);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 29);
            this.buttonInsert.TabIndex = 38;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelGreenSpaceID
            // 
            this.labelGreenSpaceID.AutoSize = true;
            this.labelGreenSpaceID.BackColor = System.Drawing.Color.Transparent;
            this.labelGreenSpaceID.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreenSpaceID.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGreenSpaceID.Location = new System.Drawing.Point(242, 173);
            this.labelGreenSpaceID.Name = "labelGreenSpaceID";
            this.labelGreenSpaceID.Size = new System.Drawing.Size(114, 17);
            this.labelGreenSpaceID.TabIndex = 75;
            this.labelGreenSpaceID.Text = "Green Space ID";
            // 
            // labelRDescription
            // 
            this.labelRDescription.AutoSize = true;
            this.labelRDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelRDescription.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRDescription.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelRDescription.Location = new System.Drawing.Point(240, 348);
            this.labelRDescription.Name = "labelRDescription";
            this.labelRDescription.Size = new System.Drawing.Size(85, 17);
            this.labelRDescription.TabIndex = 74;
            this.labelRDescription.Text = "Description";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.BackColor = System.Drawing.Color.Transparent;
            this.labelUserID.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelUserID.Location = new System.Drawing.Point(242, 220);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(60, 17);
            this.labelUserID.TabIndex = 73;
            this.labelUserID.Text = "User ID";
            // 
            // boxDescription
            // 
            this.boxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boxDescription.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDescription.ForeColor = System.Drawing.Color.DarkGreen;
            this.boxDescription.Location = new System.Drawing.Point(359, 342);
            this.boxDescription.Multiline = true;
            this.boxDescription.Name = "boxDescription";
            this.boxDescription.Size = new System.Drawing.Size(194, 32);
            this.boxDescription.TabIndex = 72;
            // 
            // boxGreenSpaceID
            // 
            this.boxGreenSpaceID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boxGreenSpaceID.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxGreenSpaceID.ForeColor = System.Drawing.Color.DarkGreen;
            this.boxGreenSpaceID.Location = new System.Drawing.Point(360, 170);
            this.boxGreenSpaceID.Multiline = true;
            this.boxGreenSpaceID.Name = "boxGreenSpaceID";
            this.boxGreenSpaceID.Size = new System.Drawing.Size(194, 32);
            this.boxGreenSpaceID.TabIndex = 71;
            // 
            // boxUserId
            // 
            this.boxUserId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boxUserId.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUserId.ForeColor = System.Drawing.Color.DarkGreen;
            this.boxUserId.Location = new System.Drawing.Point(360, 220);
            this.boxUserId.Multiline = true;
            this.boxUserId.Name = "boxUserId";
            this.boxUserId.Size = new System.Drawing.Size(194, 32);
            this.boxUserId.TabIndex = 70;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelName.Location = new System.Drawing.Point(242, 285);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 69;
            this.labelName.Text = "Name";
            // 
            // boxName
            // 
            this.boxName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boxName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxName.ForeColor = System.Drawing.Color.DarkGreen;
            this.boxName.Location = new System.Drawing.Point(359, 283);
            this.boxName.Multiline = true;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(194, 32);
            this.boxName.TabIndex = 68;
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Transparent;
            this.labelLogOut.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLogOut.Location = new System.Drawing.Point(825, 93);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(86, 25);
            this.labelLogOut.TabIndex = 76;
            this.labelLogOut.Text = "Log Out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // greenSpaceTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 542);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelGreenSpaceID);
            this.Controls.Add(this.labelRDescription);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.boxDescription);
            this.Controls.Add(this.boxGreenSpaceID);
            this.Controls.Add(this.boxUserId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sideBare);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "greenSpaceTab";
            this.Text = "greenSpaceTab";
            this.Load += new System.EventHandler(this.greenSpaceTab_Load);
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
        private System.Windows.Forms.Button plantTab;
        private System.Windows.Forms.Button GreenSpaceMembersTab;
        private System.Windows.Forms.Button UsersTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AdminsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelGreenSpaceID;
        private System.Windows.Forms.Label labelRDescription;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox boxDescription;
        private System.Windows.Forms.TextBox boxGreenSpaceID;
        private System.Windows.Forms.TextBox boxUserId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}