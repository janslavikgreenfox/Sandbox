using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamPreparation.Models.Entities
{
    public class UserAccount
    {

        [Key]
        public int Id { get; set; }
        public string AccountName { get; set; }

        public UserAccount()
        {  }
        public UserAccount(string accountName)
        {
            AccountName = accountName;
        }

    }
}
