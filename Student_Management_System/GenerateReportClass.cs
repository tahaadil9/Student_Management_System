using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class GenerateReportClass
    {
        int Sessional, Mids, Final, FinalProject;

        public GenerateReportClass(int SessionalMarks, int MidMarks, int FinalTermMarks, int FinalProject) { 
        
            this.Sessional = SessionalMarks;
            this.Mids = MidMarks;
            this.Final = FinalTermMarks;
            this.FinalProject = FinalProject;


        }
        public int Calculate_TotalMarks()
        {
            int Obtained = Sessional+Mids+FinalProject+Final;
            return Obtained;
           
        }

        public string Calculate_Status(int ObtainedMarks)
        {
            if(ObtainedMarks < 60)
            {
                return "Fail";
            }

            else
            {
                return "Cleared";
            }
            
        }


    }
}
