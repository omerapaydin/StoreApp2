using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp2.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool RememberMe { get; set; } = true;
    }
}