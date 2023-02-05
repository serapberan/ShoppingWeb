using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment  //Yorum yapma 
    {
        [Key]
        public int CommentId { get; set; }
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string CommentText { get; set; }
        public bool Status { get; set; }
        public int RatingProduct { get; set; }
        public DateTime CommentDate { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
