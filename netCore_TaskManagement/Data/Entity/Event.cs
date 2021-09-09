using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netCore_TaskManagement.Data.Entity
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }


    }
}
