namespace SupportAnalyticsAPI.Models
{
    public class Ticket
    {
        public int Id {get;set;}
        public string CustomerName {get;set;}
        public string Issue {get;set;}
        public string Status {get;set;}
        public DateTime CreatedAt {get;set;}
    }
}