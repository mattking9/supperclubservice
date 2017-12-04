using Microsoft.Azure.Mobile.Server;
using System.Collections.Generic;

namespace mySupperClubService.DataObjects
{
    public class Group : EntityData
    {        
        public string Name { get; set; }

        //EF Properties
        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}