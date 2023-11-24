using System.ComponentModel.DataAnnotations;

namespace Cascd_Dpdwn.Models
{
    public class tbl_Territory
    {
        [Key]
        public int Ter_id { get; set; }
        public string Tr_Name { get; set; }
        public string Region { get; set; }
    }
}
