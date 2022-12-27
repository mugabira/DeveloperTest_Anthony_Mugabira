
namespace DeveloperTest_Anthony_Mugabira
{
    partial class FrmUsers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTopSectionHeader = new System.Windows.Forms.Label();
            this.dgUsersList = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAssignClientGroupsPage = new System.Windows.Forms.TabPage();
            this.btnUnassignUserGroup = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lbFiltter = new System.Windows.Forms.Label();
            this.txtBoxFiltter = new System.Windows.Forms.TextBox();
            this.LBoxAssignedUserGroups = new System.Windows.Forms.ListBox();
            this.lboxUnassignedUserGroups = new System.Windows.Forms.ListBox();
            this.lbAssignUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAssignClientGroupsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTopSectionHeader
            // 
            this.lbTopSectionHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.lbTopSectionHeader.ForeColor = System.Drawing.Color.White;
            this.lbTopSectionHeader.Location = new System.Drawing.Point(13, 13);
            this.lbTopSectionHeader.Name = "lbTopSectionHeader";
            this.lbTopSectionHeader.Size = new System.Drawing.Size(800, 20);
            this.lbTopSectionHeader.TabIndex = 0;
            this.lbTopSectionHeader.Text = "Users";
            // 
            // dgUsersList
            // 
            this.dgUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUsersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsersList.Location = new System.Drawing.Point(13, 37);
            this.dgUsersList.Name = "dgUsersList";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgUsersList.RowTemplate.Height = 29;
            this.dgUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsersList.Size = new System.Drawing.Size(800, 188);
            this.dgUsersList.TabIndex = 1;
            this.dgUsersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsersList_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAssignClientGroupsPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 232);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 2;
            // 
            // tabAssignClientGroupsPage
            // 
            this.tabAssignClientGroupsPage.Controls.Add(this.label2);
            this.tabAssignClientGroupsPage.Controls.Add(this.label1);
            this.tabAssignClientGroupsPage.Controls.Add(this.btnUnassignUserGroup);
            this.tabAssignClientGroupsPage.Controls.Add(this.btnAssign);
            this.tabAssignClientGroupsPage.Controls.Add(this.lbFiltter);
            this.tabAssignClientGroupsPage.Controls.Add(this.txtBoxFiltter);
            this.tabAssignClientGroupsPage.Controls.Add(this.LBoxAssignedUserGroups);
            this.tabAssignClientGroupsPage.Controls.Add(this.lboxUnassignedUserGroups);
            this.tabAssignClientGroupsPage.Controls.Add(this.lbAssignUsers);
            this.tabAssignClientGroupsPage.Location = new System.Drawing.Point(4, 29);
            this.tabAssignClientGroupsPage.Name = "tabAssignClientGroupsPage";
            this.tabAssignClientGroupsPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignClientGroupsPage.Size = new System.Drawing.Size(792, 392);
            this.tabAssignClientGroupsPage.TabIndex = 0;
            this.tabAssignClientGroupsPage.Text = "Assign Client Groups";
            this.tabAssignClientGroupsPage.UseVisualStyleBackColor = true;
            // 
            // btnUnassignUserGroup
            // 
            this.btnUnassignUserGroup.Location = new System.Drawing.Point(354, 245);
            this.btnUnassignUserGroup.Name = "btnUnassignUserGroup";
            this.btnUnassignUserGroup.Size = new System.Drawing.Size(54, 47);
            this.btnUnassignUserGroup.TabIndex = 10;
            this.btnUnassignUserGroup.Text = "<<";
            this.btnUnassignUserGroup.UseVisualStyleBackColor = true;
            this.btnUnassignUserGroup.Click += new System.EventHandler(this.btnUnassignUserGroup_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(354, 176);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(54, 47);
            this.btnAssign.TabIndex = 9;
            this.btnAssign.Text = ">>";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lbFiltter
            // 
            this.lbFiltter.AutoSize = true;
            this.lbFiltter.Location = new System.Drawing.Point(136, 38);
            this.lbFiltter.Name = "lbFiltter";
            this.lbFiltter.Size = new System.Drawing.Size(42, 20);
            this.lbFiltter.TabIndex = 7;
            this.lbFiltter.Text = "Filter";
            // 
            // txtBoxFiltter
            // 
            this.txtBoxFiltter.Location = new System.Drawing.Point(217, 37);
            this.txtBoxFiltter.Name = "txtBoxFiltter";
            this.txtBoxFiltter.Size = new System.Drawing.Size(357, 27);
            this.txtBoxFiltter.TabIndex = 6;
            this.txtBoxFiltter.TextChanged += new System.EventHandler(this.txtBoxFiltter_TextChanged);
            // 
            // LBoxAssignedUserGroups
            // 
            this.LBoxAssignedUserGroups.FormattingEnabled = true;
            this.LBoxAssignedUserGroups.ItemHeight = 20;
            this.LBoxAssignedUserGroups.Location = new System.Drawing.Point(443, 138);
            this.LBoxAssignedUserGroups.Name = "LBoxAssignedUserGroups";
            this.LBoxAssignedUserGroups.Size = new System.Drawing.Size(343, 244);
            this.LBoxAssignedUserGroups.TabIndex = 5;
            // 
            // lboxUnassignedUserGroups
            // 
            this.lboxUnassignedUserGroups.FormattingEnabled = true;
            this.lboxUnassignedUserGroups.ItemHeight = 20;
            this.lboxUnassignedUserGroups.Location = new System.Drawing.Point(7, 138);
            this.lboxUnassignedUserGroups.Name = "lboxUnassignedUserGroups";
            this.lboxUnassignedUserGroups.Size = new System.Drawing.Size(320, 244);
            this.lboxUnassignedUserGroups.TabIndex = 4;
            // 
            // lbAssignUsers
            // 
            this.lbAssignUsers.BackColor = System.Drawing.Color.DarkBlue;
            this.lbAssignUsers.ForeColor = System.Drawing.Color.White;
            this.lbAssignUsers.Location = new System.Drawing.Point(6, 8);
            this.lbAssignUsers.Name = "lbAssignUsers";
            this.lbAssignUsers.Size = new System.Drawing.Size(783, 20);
            this.lbAssignUsers.TabIndex = 3;
            this.lbAssignUsers.Text = "Assign users to client group - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Unassigned Client Groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Assigned Client Groups";
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 653);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgUsersList);
            this.Controls.Add(this.lbTopSectionHeader);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAssignClientGroupsPage.ResumeLayout(false);
            this.tabAssignClientGroupsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTopSectionHeader;
        private System.Windows.Forms.DataGridView dgUsersList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAssignClientGroupsPage;
        private System.Windows.Forms.Button btnUnassignUserGroup;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lbFiltter;
        private System.Windows.Forms.TextBox txtBoxFiltter;
        private System.Windows.Forms.ListBox LBoxAssignedUserGroups;
        private System.Windows.Forms.ListBox lboxUnassignedUserGroups;
        private System.Windows.Forms.Label lbAssignUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

