namespace EventEaseApp.Data
{
    public class EventService
    {
        // Using mock data for the foundational app
        private readonly List<Event> _events = new()
        {
            new() { Id = 1, Title = "Annual Tech Summit", Description = "A gathering of the brightest minds in technology.", Date = new DateTime(2024, 10, 22), Location = "Metropolis Convention Center" },
            new() { Id = 2, Title = "Marketing & Media Mixer", Description = "Network with professionals in the marketing and media industries.", Date = new DateTime(2024, 11, 05), Location = "The Grand Ballroom" },
            new() { Id = 3, Title = "Corporate Leadership Retreat", Description = "An exclusive retreat for executive leadership.", Date = new DateTime(2024, 11, 18), Location = "Mountain View Resort" }
        };

        public Task<List<Event>> GetEventsAsync() => Task.FromResult(_events);

        public Task<Event?> GetEventByIdAsync(int id) => Task.FromResult(_events.FirstOrDefault(e => e.Id == id));
    }
}
