using Core.DataAccess.Concrete;
using Entities.Concrete;
using EntityFramework.DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFParticipantDal : EFEntityRepositoryBase<Participant, VTPContext>, IParticipantDal
    {

    }
}