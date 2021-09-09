using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netCore_TaskManagement.Models
{
    public class AddOrUpdateEventModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
    }
}
