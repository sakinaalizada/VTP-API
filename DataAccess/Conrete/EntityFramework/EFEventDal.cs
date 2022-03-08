
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEventDal : EFEntityRepositoryBase<Event, VTPContext>, IEventDal
    {
    }
}
