using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("CourseParticipant", Schema = "CourseParticipants")]
    public class CourseParticipant
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ParticipantId { get; set; }
        
        //Navigation Properties
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        [ForeignKey("ParticipantId")]
        public virtual Participant Participant { get; set; }
    }
}