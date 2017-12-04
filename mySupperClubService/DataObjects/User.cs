using Microsoft.Azure.Mobile.Server;

namespace mySupperClubService.DataObjects
{
    public class User : EntityData
    {        
        public string GroupId { get; set; }

        public string Name { get; set; }        
    }
}