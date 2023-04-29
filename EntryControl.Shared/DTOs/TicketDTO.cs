namespace EntryControl.Shared.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }

        public DateTime UsedDate { get; set; }

        public bool IsUsed { get; set; }

        public string? Gate { get; set; }
    }
}