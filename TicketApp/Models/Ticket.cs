namespace TicketApp.Models
{
    public enum Priority
    {
        Low, Mid, High
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public string TechId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public String Location { get; set; }
        public Priority Priority { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        public virtual Tech Tech { get; set; }

    }
}
