using System.ComponentModel.DataAnnotations;

namespace EntryControl.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Display(Name = "Fecha/Hora")]
        public string? UsedDate { get; set; }

        public bool IsUsed { get; set; }

        public string? Gate { get; set; }
    }
}
