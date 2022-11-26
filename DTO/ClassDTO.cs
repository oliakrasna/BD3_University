using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassDTO
    {
        public int ClassID { get; set; }
        public int ProfessorID { get; set; }
        public int SubjectID { get; set; }
        public override string ToString()
        {
            return $"{ClassID,-3}*{ProfessorID,-3}*{ SubjectID,-3} *";
        }
    }
}
