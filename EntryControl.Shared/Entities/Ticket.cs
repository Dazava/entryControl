using System.ComponentModel.DataAnnotations;

namespace EntryControl.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha/Hora")]
        public DateTime UsedDate { get; set; }

        public bool IsUsed { get; set; }

        public string? Gate { get; set; }
    }
}
