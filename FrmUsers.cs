using DeveloperTest_Anthony_Mugabira.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperTest_Anthony_Mugabira
{
    public partial class FrmUsers : Form
    {
        UserServices userServices = new UserServices();

        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            LoadOnStart();
        }

        private void LoadOnStart()
        {
            PopulateUserGridView();
        }

        private void PopulateUserGridView()
        {
            dgUsersList.DataSource = userServices.GetUsersList();
        }

        private void FillTheSecondHeaderWithName(int id)
        {
            lbAssignUsers.Text = $"Assign users to client group - {userServices.GetUserById(id).UserName}";
        }
        private void PopulateUnAssignedClientGroupListBox(int userid)
        {
            //lboxUnassignedUserGroups.Items.Clear();
            lboxUnassignedUserGroups.DataSource = (from b in userServices.GetUnAssignedClientGroupsByUserId(userid) select b.Name).ToList();
        }

        private void PopulateAssignedClientGroupListBox(int userid)
        {
            //LBoxAssignedUserGroups.Items.Clear();
            LBoxAssignedUserGroups.DataSource = (from b in userServices.GetAssignedClientGroupsByUserId(userid) select b.Name).ToList();
        }
        private void SearchAssignedCliendGroupListBox(int userid, string searchTerm)
        {
            LBoxAssignedUserGroups.DataSource = (from b in userServices.GetAssignedClientGroupsByUserId(userid).Where(a=>a.Name.Contains(searchTerm)) select b.Name).ToList();
        }

        private void SearchUnAssignedClientGroupListBox(int userid, string searchTerm)
        {
            lboxUnassignedUserGroups.DataSource = (from b in userServices.GetUnAssignedClientGroupsByUserId(userid).Where(a => a.Name.Contains(searchTerm)) select b.Name).ToList();
        }
        private void dgUsersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowCount = dgUsersList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    int selectedUserId = Convert.ToInt32(dgUsersList.CurrentRow.Cells[0].Value.ToString());
                    this.FillTheSecondHeaderWithName(selectedUserId);
                    this.PopulateAssignedClientGroupListBox(selectedUserId);
                    this.PopulateUnAssignedClientGroupListBox(selectedUserId);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(dgUsersList.CurrentRow.Cells[0].Value.ToString());
            var selectedClientGroup = userServices.GetClientGroupByName(lboxUnassignedUserGroups.SelectedItem.ToString());
            userServices.AddClientGroupUser(selectedUserId, selectedClientGroup.Id);
            this.PopulateAssignedClientGroupListBox(selectedUserId);
            this.PopulateUnAssignedClientGroupListBox(selectedUserId);

        }

        private void btnUnassignUserGroup_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(dgUsersList.CurrentRow.Cells[0].Value.ToString());
            var selectedClientGroup = userServices.GetClientGroupByName(LBoxAssignedUserGroups.SelectedItem.ToString());
            userServices.RemoveClientGroupUser(selectedUserId, selectedClientGroup.Id);
            this.PopulateAssignedClientGroupListBox(selectedUserId);
            this.PopulateUnAssignedClientGroupListBox(selectedUserId);
        }

        private void txtBoxFiltter_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBoxFiltter.Text;
            int selectedUserId = Convert.ToInt32(dgUsersList.CurrentRow.Cells[0].Value.ToString());
            SearchAssignedCliendGroupListBox(selectedUserId, searchTerm);
            SearchUnAssignedClientGroupListBox(selectedUserId, searchTerm);
        }
    }
}
