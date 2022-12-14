using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void Add(Category category);
        Category GetById(int id);
        void Delete(Category category);
        void Update(Category category);
    }

    public interface IContentService
    {
    }
    public interface IContactService
    {
    }
    public interface IAboutService
    {
    }
    public interface IHeadingService
    {
    }
    public interface IWriterService
    {
    }
}
