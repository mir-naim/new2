using System.ComponentModel.DataAnnotations;

namespace MVC_APU_FlowerShop2023.Models
{
    public class Result
    {
        [Key]
        public int Result_ID {  get; set; }

        public int Student_ID { get; set; }

        public int Teacher_ID { get; set; }

        public int Subject_ID {  get; set; }

        public int ? Marks {  get; set; }
    }
}
