using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager:IContentService
    {
        GenericRepository<Content> _genericRepository;

        public ContentManager(GenericRepository<Content> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Content GetByID(int id)
        {
            return _genericRepository.Get(x => x.ContentID == id);
        }

        public List<Content> GetList()
        {
            return _genericRepository.List();
        }

        public void ContentAdd(Content content)
        {
            _genericRepository.Insert(content);
        }

        public void ContentDelete(Content content)
        {
            _genericRepository.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _genericRepository.Update(content);
        }
    }
}
