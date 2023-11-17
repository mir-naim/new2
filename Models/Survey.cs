using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_APU_FlowerShop2023.Models
{
    public enum LikertScale
    {
        StronglyDisagree = 1,
        Disagree = 2,
        Neutral = 3,
        Agree = 4,
        StronglyAgree = 5
    }

    public class Survey
    {
        [Key]
        public int Survey_ID { get; set; }

        public int Student_ID { get; set; }

        public DateTime SurveyDate { get; set; }

        public string? Q1 { get; set; }

        public string? Q2 { get; set; }

        public LikertScale? Q3 { get; set; }

        public LikertScale? Q4 { get; set; }

        public LikertScale? Q5 { get; set; }
    }
}
