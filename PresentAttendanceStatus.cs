using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class PresentAttendanceStatus : AttendanceStatus
    {
        public override void SetLabel(Attendence attendenceForm)
        {
            attendenceForm.SetPresentLabel();
        }
    }
}
