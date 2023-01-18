using Delivery_Kursowa.DataAccess.Repository.IRepository;
using Delivery_Kursowa.Models;
using Delivery_Kursowa.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Kursowa.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository( ApplicationDbContext db) :base(db)
        {
            _db= db;
        }
        

        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

        
    }
}
