namespace EventEes.Models
{
    public class Event
    {
        public int Id { get; set; }  // Primary key for the Event

        public string Name { get; set; }  // Name of the Event

        public DateTime Date { get; set; }  // Date of the Event

        public string Description { get; set; }  // Description of the Event

        // Foreign Key for Venue
        public int VenueId { get; set; }

        // Navigation Property for the relationship between Event and Venue
        public Venue Venue { get; set; }
    }
}
