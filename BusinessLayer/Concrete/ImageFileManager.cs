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
    public class ImageFileManager:IImageFile
    {
        GenericRepository<ImageFile> _genericRepository;

        public ImageFileManager(GenericRepository<ImageFile> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public ImageFile GetByID(int id)
        {
            return _genericRepository.Get(x => x.ImageID == id);
        }

        public List<ImageFile> GetList()
        {
            return _genericRepository.List();
        }

        public void ImageFileAdd(ImageFile imageFile)
        {
            _genericRepository.Insert(imageFile);
        }

        public void ImageFileDelete(ImageFile imageFile)
        {
            _genericRepository.Delete(imageFile);
        }

        public void ImageFileUpdate(ImageFile imageFile)
        {
            _genericRepository.Update(imageFile);
        }
    }
}
