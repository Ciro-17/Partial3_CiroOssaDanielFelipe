using System.ComponentModel.DataAnnotations;

namespace Partial3_CiroOssaDanielFelipe.DAL.Entities
{
    public class Ticket : Entity
    {
        [Required]
        public DateTime? UseDate { get; set; }

        public bool IsUsed { get; set; }

        public String? EntranceGate { get; set; }
    }   
}
