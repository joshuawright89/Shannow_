using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shannow_Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        //author (joiner?)
        [Display(Name ="By:")]
        public string Author { get; set; }

        //genre (category challenge?)

        //rating (en?)
        [Display(Name ="My rating:")]
        public int Rating { get; set; }

        //type (enum?)

        //wordcount?
        public int ? WordCount { get; set; }

        //series? (joiner?)

        //publisher? (joiner?)
    }
}
