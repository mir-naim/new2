using System.ComponentModel.DataAnnotations;

namespace MVC_APU_FlowerShop2023.Models
{
    public class Subject
    {
        [Key]
        public int Subject_ID { get; set; }

        public string Name { get; set; }
    }
}
