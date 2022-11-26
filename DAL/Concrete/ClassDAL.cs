using AutoMapper;
using DAL.Interfaces;
using BD3_University;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Concrete
{
    public class ClassDAL : IClassDAL
    {
        private readonly IMapper _mapper;
        public ClassDAL(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ClassDTO CreateClass(ClassDTO class)
        {

            using (var entites = new universityContext())
            {
                var classInDB = _mapper.Map<Class>(class);
                classInDB.ClassId = class.ClassID;
                entites.Classes.Add(classInDB);
                entites.SaveChanges();
                return _mapper.Map<ClassDTO>(classInDB);
            }
        }

        public List<ClassDTO> GetAllClasses()
        {
            using (var entities = new universityContext())
            {
                var classes = entities.Classes.Where(x => x.ClassId != 0).ToList();
                return _mapper.Map<List<ClassDTO>>(classes);
            }
        }
        public ClassDTO UpdateClass(ClassDTO class)
        {
            using (var entites = new universityContext())
            {
                var classInDB = _mapper.Map<Class>(class);
                classInDB = entites.CLasses.SingleOrDefault(x => x.ClassId == class.ClassID);
                if (classInDB != null)
                {
                   classInDB.ClassID = class.ClassID;
                    classInDB.ProfessorID = class.ProfessorID;
                    classInDB.SubjectID = class.SubjectID;
                    
                    entites.SaveChanges();
                    return _mapper.Map<ClassDTO>(classInDB);
                }
                return null;
            }
        }

        public ClassDTO DeleteClass(ClassDTO class)
        {
            using (var entites = new universityContext())
            {
                var classInDB = _mapper.Map<Class>(class);
                classInDB = entites.Classes.SingleOrDefault(x => x.ClassId == class.ClassID);
                if (classInDB != null)
                {
                    entites.Classes.Remove(classInDB);
                    entites.SaveChanges();
                    return _mapper.Map<ClassDTO>(classInDB);
                }
                return null;
            }
        }
    }
}