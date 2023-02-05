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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentDelete(int id)
        {
            var result = _commentDal.GetById(id);
            _commentDal.Delete(result);
        }

        public void TAdd(Comment t)
        {
            t.CommentDate = DateTime.Now;
            t.Status = true;
            _commentDal.Add(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetList(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.List(filter);
        }

        public List<Comment> TList()
        {
            return _commentDal.List();
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
