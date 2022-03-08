using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Business.Abstract
{
    public interface IEventService
    {
        IDataResult<List<Event>> GetAll(Expression<Func<Event, bool>> filter = null);
        IResult Add(Event _event);
        IResult Update(Event _event);
        IResult Delete(Event _event);
    }
}
