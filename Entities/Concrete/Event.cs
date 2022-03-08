using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Event : IEntity
    {
        public int EventId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTitle { get; set; }
    }
}
