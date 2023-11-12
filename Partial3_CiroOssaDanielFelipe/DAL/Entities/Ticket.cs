using System.ComponentModel.DataAnnotations;

namespace Partial3_CiroOssaDanielFelipe.DAL.Entities
{
    public class Ticket : Entity
    {
        [Required]
        public DateTime? UseDate { get; set; }

        public bool IsUsed { get; set; }

        public Entrance? EntranceGate { get; set; }

        public int IDticket { get; internal set; }

        public enum Entrance
        {
            Oriental,
            Occidental,
            Norte,
            Sur,

        }
    }   
}
