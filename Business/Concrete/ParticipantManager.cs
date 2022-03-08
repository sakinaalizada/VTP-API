
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using Entities.Concrete;
using EntityFramework.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ParticipantManager : IParticipantService
    {
        private IParticipantDal _participantDal;
        public ParticipantManager(IParticipantDal participantDal)
        {
            _participantDal = participantDal;

        }
        public IDataResult<List<Participant>> GetAll(Expression<Func<Participant, bool>> filter = null)
        {
            return new SuccessDataResult<List<Participant>>(_participantDal.GetAll(filter));
        }

    }
}
