
using Core.DataAccess.Abstarct;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IEventDal : IEntityRepository<Event>
    {
    }
}
