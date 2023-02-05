using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        void ContactChangeToFalse(int id);
        List<Contact> GetListContactByTrue();
        List<Contact> GetListContactByFalse();
      
    }
}
