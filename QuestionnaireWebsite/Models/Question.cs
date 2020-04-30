using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebsite.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string QustionTitle { get; set; }

        [ForeignKey("QuestionnareId")]
        public Questionnaire Questionnare { get; set; }
        public int QuestionnareId { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
