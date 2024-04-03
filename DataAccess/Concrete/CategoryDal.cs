using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : IGenericDal<Category>
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category() {Id=1,Name="FrontEnd"},
                new Category() {Id=2,Name="BackEnd"},
                new Category() {Id=3,Name="Data"}
            };
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
            Console.WriteLine("New Category Added");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            var categoryInfo=_categories.FirstOrDefault(c => c.Id == id);
            return categoryInfo;
        }

        public void Remove(Category entity)
        {
            var categoryRemove=_categories.Where(c=>c.Id == entity.Id).SingleOrDefault();
            if(categoryRemove != null)
            {
                _categories.Remove(categoryRemove);
                Console.WriteLine("Category Removed");
            }
            Console.WriteLine("Check ıd try again");
        }

        public void Update(Category entity)
        {
            var categoryUpdate=_categories.Where(u=>u.Id == entity.Id).SingleOrDefault();
            if(categoryUpdate != null)
            {
                categoryUpdate.Name = entity.Name;
            }
        }
    }
}
