using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskWcf.DAL
{
    public class WebTrackDAL : DataAccessLayer
    {
        public Boolean PutTracking(Models.WebTrack webTrack)
        {
            try
            {
                db.WebTracker.Add(new WebTracker
                {
                    URLRequest = webTrack.URLRequest,
                    SourceIp = webTrack.SourceIp,
                    TimeOfAction = webTrack.TimeOfAction
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
