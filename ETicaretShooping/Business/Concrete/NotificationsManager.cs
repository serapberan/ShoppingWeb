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
    public class NotificationsManager : INotificationsService
    {
        INotificationsDal _notifications;

        public NotificationsManager(INotificationsDal notifications)
        {
            _notifications = notifications;
        }

        public void TAdd(Notifications t)
        {
            _notifications.Add(t);
        }

        public void TDelete(Notifications t)
        {
            _notifications.Delete(t);
        }

        public Notifications TGetById(int id)
        {
            return _notifications.GetById(id);
        }

        public List<Notifications> TGetList(Expression<Func<Notifications, bool>> filter)
        {
            return _notifications.List(filter);
        }

        public List<Notifications> TList()
        {
            return _notifications.List();
        }

        public void TUpdate(Notifications t)
        {
             _notifications.Update(t);
        }
    }
}
