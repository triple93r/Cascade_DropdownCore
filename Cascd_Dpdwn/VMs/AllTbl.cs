using Cascd_Dpdwn.Data;
using Cascd_Dpdwn.Models;

namespace Cascd_Dpdwn.VMs
{
    public class AllTbl
    {
     
        public List<tbl_Territory> tbl_Territory { get; set; } = new List<tbl_Territory>();
        public List<tbl_Country> tbl_Country { get; set; } = new List<tbl_Country>();
        public List<tbl_Stt> tbl_Stt { get; set; } = new List<tbl_Stt>();

        public tbl_Territory Territory { get; set; } = new tbl_Territory();
        public tbl_Country Country { get; set; } = new tbl_Country();
        public tbl_Stt Stt { get; set; } = new tbl_Stt();

    }
}
