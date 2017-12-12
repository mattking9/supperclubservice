using Microsoft.Azure.Mobile.Server;

namespace mySupperClubService.DataObjects
{
    public class BillItem : EntityData
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public string EventId { get; set; }

        public string UserId { get; set; }
    }
}