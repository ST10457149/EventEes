namespace EventEes.Models
{
    public class Booking
    {
        public int Id { get; set; }  // Booking ID
        public DateTime Date { get; set; }  // Date of booking
        public int VenueId { get; set; }  // Foreign key to Venue
        public int EventId { get; set; }  // Foreign key to Event

        // Navigation Properties
        public Venue Venue { get; set; }  // Navigation to the Venue
        public Event Event { get; set; }  // Navigation to the Event
    }
}
