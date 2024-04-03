using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IGenericDal<Instructor>
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>()
            {
                new Instructor() {Id=1,Name="Engin",LastName="Demirog"}
            };
        }

        public void Add(Instructor entity)
        {
            instructors.Add(entity);
            Console.WriteLine("Instructor Added");
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            Instructor entity = instructors.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void Remove(Instructor entity)
        {
            var instructorRemove=instructors.FirstOrDefault(entity=>entity.Id==entity.Id);
            if (instructorRemove != null)
            {
                instructors.Remove(instructorRemove);
                Console.WriteLine("Instructor Remove");
            }

        }

        public void Update(Instructor entity)
        {
            var instructorUpdate=instructors.FirstOrDefault(i=>i.Id==entity.Id);
            if(instructorUpdate != null)
            {
               instructorUpdate.Name = entity.Name;
               instructorUpdate.LastName = entity.LastName;
               Console.WriteLine("Instructor Update");
            }
        }
    }
}
