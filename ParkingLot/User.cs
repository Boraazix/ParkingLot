using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    [Table("tb_user")]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public const String SALT = "!@#$%¨&*()_+";
        public int UserId { get; set; }

        [MaxLength(250)]
        public String Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Birth { get; set; }

        [MaxLength(64)]
        [Required]
        private string _password;
        public string Password { 
            get 
            {
                return _password;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 12)
                {
                    _password = ComputeSHA256(value, SALT);
                }
                else if (value.Length == 64)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("The password must be between 8 and 12 characters!");
                }
            } 
        }
        public bool Active { get; set; }

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // 
            // https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netframework-4.8
            // https://www.techiedelight.com/generate-sha-256-hash-of-string-csharp/
            // 

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion

        public User() { }

        public User(string name, string email, DateTime birth, string password, bool active)
        {
            Name = name;
            Email = email;
            Birth = birth;
            Password = password;
            Active = active;
        }

        public override string ToString()
        {
            return $"{UserId} : {Name}";
        }
    }
}
