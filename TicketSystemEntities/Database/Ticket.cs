

namespace TicketSystemEntities.Database
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TechId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Location { get; set; }
        public int Priority { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        //TODO: Break into it's own entity
        //public virtual Tech Tech { get; set; }

    }
}
