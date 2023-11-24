using System.ComponentModel.DataAnnotations;

namespace Cascd_Dpdwn.Models
{
    public class tbl_Stt
    {
        [Key]
        public int Stt_id { get; set; }
        public string St_Name { get; set;}
        public int Cnt_id { get; set;}
    }
}
