using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;

namespace mySupperClubService.DataObjects
{
    public class Event : EntityData
    {        
        public string GroupId { get; set; }

        public string LocationName { get; set; }

        public DateTime EventDate { get; set; }

        //EF Properties

        public virtual ICollection<BillItem> BillItems { get; set; }
    }
}