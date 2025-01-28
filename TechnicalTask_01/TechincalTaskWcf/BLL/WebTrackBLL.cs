using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskWcf.BLL
{
    public class WebTrackBLL
    {
        public Boolean PutTracking(Models.WebTrack webTrack)
        { 
            return new DAL.WebTrackDAL().PutTracking(webTrack);
        }
    }
}
