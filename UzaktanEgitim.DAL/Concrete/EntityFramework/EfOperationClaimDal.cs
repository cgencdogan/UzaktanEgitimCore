using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.DAL.Abstract;
using UzaktanEgitim.DAL.Concrete.EntityFramework.Contexts;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Concrete.EntityFramework
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, UzEmContext> , IOperationClaimDal
    {
    }
}
