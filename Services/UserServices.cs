using DeveloperTest_Anthony_Mugabira.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperTest_Anthony_Mugabira.Services
{
    class UserServices
    {
        private List<int?> GetUserAssignedClientGroupIds(int userId)
        {
            List<int?> userClientGroupIds = new List<int?>();
            using (var dbContext = new TestDBAnthonyContext())
            {
                userClientGroupIds = (from b in dbContext.ClientGroupUsers where b.UserId != userId select b.ClientGroupId).ToList();
            }
            return userClientGroupIds;
        }
        public List<ClientGroupDTO> GetUnAssignedClientGroupsByUserId(int userId)
        {
            List<ClientGroupDTO> clientGroupDTOList = new List<ClientGroupDTO>();
            try
            {
                using (var dbContext = new TestDBAnthonyContext())
                {
                    List<ClientGroup> clientGroups = (from b in dbContext.ClientGroup where(b.IsHidden == true && !GetUserAssignedClientGroupIds(userId).Contains(b.Id))  select b).ToList();
                    foreach (ClientGroup clientGroup in clientGroups)
                    {
                        ClientGroupDTO clientGroupDTO = new ClientGroupDTO();
                        clientGroupDTO.Id = clientGroup.Id;
                        clientGroupDTO.Name = clientGroup.Name;
                        clientGroupDTO.IsHidden = clientGroup.IsHidden;

                        clientGroupDTOList.Add(clientGroupDTO);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return clientGroupDTOList;
        }

        public List<ClientGroupDTO> GetAssignedClientGroupsByUserId(int userId)
        {
            List<ClientGroupDTO> clientGroupDTOList = new List<ClientGroupDTO>();
            try
            {
                using (var dbContext = new TestDBAnthonyContext())
                {
                    List<ClientGroup> clientGroups = (from b in dbContext.ClientGroup where GetUserAssignedClientGroupIds(userId).Contains(b.Id) select b).ToList();
                    foreach (ClientGroup clientGroup in clientGroups)
                    {
                        ClientGroupDTO clientGroupDTO = new ClientGroupDTO();
                        clientGroupDTO.Id = clientGroup.Id;
                        clientGroupDTO.Name = clientGroup.Name;
                        clientGroupDTO.IsHidden = clientGroup.IsHidden;

                        clientGroupDTOList.Add(clientGroupDTO);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return clientGroupDTOList;
        }
        public UserDTO GetUserById(int id)
        {
            UserDTO userDTO = new UserDTO();
            try
            {
                using (var dbContext = new TestDBAnthonyContext())
                {
                    Users user = dbContext.Users.Find(id);

                    userDTO.UserId = user.Id;
                    userDTO.UserName = user.Name;
                    userDTO.UserType = (bool)user.IsGlobalUser ? "Global User" : "Client User";

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return userDTO;
        }

        public ClientGroupDTO GetClientGroupByName(string name)
        {
            ClientGroupDTO clientGroupDTO = new ClientGroupDTO();
            try
            {
                using (var dbContext = new TestDBAnthonyContext())
                {
                    ClientGroup clientGroup = dbContext.ClientGroup.Where(b => b.Name == name).FirstOrDefault();

                    clientGroupDTO.Id = clientGroup.Id;
                    clientGroupDTO.Name = clientGroup.Name;
                    clientGroupDTO.IsHidden = (bool)clientGroup.IsHidden;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return clientGroupDTO;
        }

        public void AddClientGroupUser(int userId, int clientGroupId)
        {
            ClientGroupUsers clientGroupUsers = new ClientGroupUsers();
            clientGroupUsers.ClientGroupId = clientGroupId;
            clientGroupUsers.UserId = userId;
            using (var dbContext  = new TestDBAnthonyContext())
            {

                dbContext.ClientGroupUsers.Add(clientGroupUsers);
                dbContext.SaveChanges();
            }
        }

        public void RemoveClientGroupUser(int userId, int clientGroupId)
        {
            using (var dbContext = new TestDBAnthonyContext())
            {
                var clientGroupUser = (from y in dbContext.ClientGroupUsers.Where(b=>b.UserId == userId && b.ClientGroupId == clientGroupId)
                         select y).FirstOrDefault();

                dbContext.ClientGroupUsers.Remove(clientGroupUser);
                dbContext.SaveChanges();
            }
        }

        public List<UserDTO> GetUsersList()
        {
            List<UserDTO> UserDTOList = new List<UserDTO>();
            try
            {
                using (var dbContext = new TestDBAnthonyContext())
                {
                    List<Users> users = (List<Users>)dbContext.Users.ToList();
                    foreach (Users user in users)
                    {
                        UserDTO userDTO = new UserDTO();
                        userDTO.UserId = user.Id;
                        userDTO.UserName = user.Name;
                        userDTO.UserType = (bool)user.IsGlobalUser ? "Global User" : "Client User";

                        UserDTOList.Add(userDTO);
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return UserDTOList;
        }
    }
}
