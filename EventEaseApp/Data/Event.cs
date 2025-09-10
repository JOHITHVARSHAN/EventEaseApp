using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Data;

public class Event
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public DateTime? Date { get; set; }
    public string Location { get; set; } = "";
    public string Description { get; set; } = "";
}
