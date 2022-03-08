using Core.DataAccess.Abstarct;
using Entities.Concrete;
using System.Collections.Generic;

namespace EntityFramework.DataAccess.Abstract
{
    public interface IParticipantDal : IEntityRepository<Participant>
    {
    }
}
