using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessManager.ViewModels
{
    public class AddMoshtariViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "شماره صفحه")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [Range(0, 100000000, ErrorMessage = "{0} معتبر نیست")]
        public int Radif { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(200, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Nam { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(200, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Family { get; set; }
    }
}
