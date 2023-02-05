using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactChangeToFalse(int id)
        {
            _contactDal.ContactChangeToFalse(id);
        }

        public List<Contact> GetListContactByFalse()
        {
            return _contactDal.GetListContactByFalse();
        }

        public List<Contact> GetListContactByTrue()
        {
            return _contactDal.GetListContactByTrue();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Add(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetList(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.List(filter);
        }

        public List<Contact> TList()
        {
            return _contactDal.List();
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
