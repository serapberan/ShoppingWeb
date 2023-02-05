using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        void ContactChangeToFalse(int id);
        List<Contact> GetListContactByTrue();
        List<Contact> GetListContactByFalse();
    }
}
