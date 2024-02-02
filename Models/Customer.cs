using System.ComponentModel.DataAnnotations;

namespace APICrudClient.Models
{


    public class Customer 
    {
      public int id {  get; set; }

        [StringLength(75)]

        public string firstName { get; set; } = "";


        [StringLength(75)]
        public string lastName { get; set; } = "";


        [StringLength(75)]
        public string phoneNo { get; set; } = "";


        [StringLength(75)]
        public string emailId { get; set; } = "";
    }
}
