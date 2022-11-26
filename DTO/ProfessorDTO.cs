using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ProfessorDTO
    {
        public int ProfessorID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{ProfessorID,-3}*\t{Name,-25}*\t{LastName,-20}* {PhoneNumber,-15}*\t{Email,-20} *";
        }
    }
}
