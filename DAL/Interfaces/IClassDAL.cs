using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IClassDAL
    {
        List<ClassDTO> GetAllClasses();
        ClassDTO CreateClass(ClassDTO class);
        ClassDTO UpdateClass(ClassDTO class);
        ClassDTO DeleteClass(ClassDTO class);
    }
}