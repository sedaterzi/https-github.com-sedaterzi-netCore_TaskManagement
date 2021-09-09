using System;

namespace netCore_TaskManagement
{
    public class EventViewModel
    {
        public EventViewModel()
        {
        }

        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public string Title { get; internal set; }
        public string Description { get; internal set; }
    }
}