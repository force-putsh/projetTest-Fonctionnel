using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Entity
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        [Required]
        public  string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public Users(int subjectId, string username, string password)
        {
            SubjectId = subjectId;
            Username = username;
            Password = password;
        }
    }
}
