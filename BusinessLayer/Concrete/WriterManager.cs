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
    public class WriterManager : IWriterService
    {
        GenericRepository<Writer> _genericRepository;

        public WriterManager(GenericRepository<Writer> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Writer GetByID(int id)
        {
            return _genericRepository.Get(x=>x.WriterID==id);
        }

        public List<Writer> GetList()
        {
            return _genericRepository.List();
        }

        public void WriterAdd(Writer writer)
        {
            _genericRepository.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _genericRepository.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _genericRepository.Update(writer);
        }
    }
}
