using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IParticipantService
    {
        IDataResult<List<Participant>> GetAll(Expression<Func<Participant, bool>> filter = null);
    }
}
