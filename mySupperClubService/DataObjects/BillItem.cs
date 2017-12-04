using Microsoft.Azure.Mobile.Server;

namespace mySupperClubService.DataObjects
{
    public class BillItem : EntityData
    {
        public string LocationName { get; set; }

        public string EventId { get; set; }
    }
}