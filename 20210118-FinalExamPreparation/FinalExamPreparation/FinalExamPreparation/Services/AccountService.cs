using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamPreparation.Databases;
using FinalExamPreparation.Models.Entities;
using FinalExamPreparation.Services.Interfaces;

namespace FinalExamPreparation.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext dbContext;

        public AccountService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public UserAccount Create(string UserName)
        {
            var currentUserAccount = new UserAccount(UserName);
            dbContext.Add(currentUserAccount);
            dbContext.SaveChanges();

            return ReadById(currentUserAccount.Id);
        }

        public List<UserAccount> ReadAll()
        {
            throw new NotImplementedException();
        }

        public UserAccount ReadById(int userAccountId)
        {
            return dbContext.UsersAccounts.FirstOrDefault(x=>x.Id.Equals(userAccountId));
        }
    }
}
