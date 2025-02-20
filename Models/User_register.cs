using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using MySql.Data;

namespace Sistema_de_Agendamento.Models
{
    public class User_register
    {   
        public int User_registration { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool TermsAndCondition { get; set; }
    }
}