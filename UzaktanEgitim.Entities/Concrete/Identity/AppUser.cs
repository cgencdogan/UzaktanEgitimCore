using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace Core.Entities.Identity
{
    public class AppUser : IdentityUser, IEntity
    {
        public string ProfilePicPath { get; set; }
        public DateTime PicUploadedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
