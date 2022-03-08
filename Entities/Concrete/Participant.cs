using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Participant : IEntity
    {
        public int ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Degree { get; set; }
        public int DepartmentId { get; set; }



    }
}
