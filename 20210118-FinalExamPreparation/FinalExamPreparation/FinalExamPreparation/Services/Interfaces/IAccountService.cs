using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamPreparation.Models.Entities;

namespace FinalExamPreparation.Services.Interfaces
{
    public interface IAccountService
    {
        public UserAccount Create(string UserName);
        public UserAccount ReadById(int userAccountId);
        public List<UserAccount> ReadAll();
    }
}
