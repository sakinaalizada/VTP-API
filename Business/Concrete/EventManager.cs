using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class EventManager : IEventService
    {
        private IEventDal _eventDal;
        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }
        public IResult Add(Event _event)
        {
            _eventDal.Add(_event);
            return new SuccessResult();
        }

        public IResult Delete(Event _event)
        {
            _eventDal.Delete(_event);
            return new SuccessResult();
        }

        public IDataResult<List<Event>> GetAll(Expression<Func<Event, bool>> filter = null)
        {
            return new SuccessDataResult<List<Event>>(_eventDal.GetAll(filter));
        }
        public IResult Update(Event _event)
        {
            _eventDal.Update(_event);
            return new SuccessResult();
        }
    }
}
