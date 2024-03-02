using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBl()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBl(Category p)
        //{
        //    if (p.CategoryName.Trim()=="" || p.CategoryName.Length <=3 || p.CategoryDescription.Trim()=="" || p.CategoryName.Length>=51)
        //    {
        //        //Hata Mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

        GenericRepository<Category> _categoryDal;

        public CategoryManager(GenericRepository<Category> category)
        {
            _categoryDal = category;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }




    }
}
