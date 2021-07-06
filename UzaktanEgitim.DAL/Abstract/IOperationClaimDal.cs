using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.Entities.Concrete;

namespace UzaktanEgitim.DAL.Abstract
{
    public interface IOperationClaimDal : IEntityRepository<OperationClaim>
    {
    }
}
