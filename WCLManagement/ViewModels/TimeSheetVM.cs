using WCLManagement.Entities;

namespace WCLManagement.ViewModels
{
    public class TimeSheetVM
    {
        public int EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

        public DateTime StartWorking { get; set; }

        public DateTime EndWorking { get; set; }

        public DateTime BreakStart { get; set; }

        public DateTime BreakEnd { get; set; }
    }
}
