using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public void ContactChangeToFalse(int id)
        {
            using (var context = new Context())
            {
                var values = context.Contacts.Find(id);
                values.Status = false;
                context.Update(values);
                context.SaveChanges();
            }
          
        }

        public List<Contact> GetListContactByFalse()
        {
            using (var context = new Context())
            {
                var values = context.Contacts.Where(x => x.Status == false).ToList();
                return values;
            }
        }

        public List<Contact> GetListContactByTrue()
        {
            using (var context = new Context())
            {
                var values = context.Contacts.Where(x => x.Status == true).ToList();
                return values;
            }
        }
    }
}
