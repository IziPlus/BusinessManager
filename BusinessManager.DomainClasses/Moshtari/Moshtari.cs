using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessManager.DomainClasses
{
    public class Moshtari
    {
        public Moshtari()
        {

        }

        [Key]
        [Display(Name ="شناسه")]
        public int Id { get; set; }

        [Display(Name ="شماره صفحه")]
        [Range(0, 100000000, ErrorMessage = "{0} معتبر نیست")]
        [Required(ErrorMessage ="{0} نمی تواند خالی باشد")]
        public int Radif { get; set; }

        [Display(Name ="نام")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(200,ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Nam { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(200, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Family { get; set; }

        [Display(Name = "شناسه معرف")]
        public int? IdParent { get; set; }

        [Display(Name = "شماره ثابت")]
        [MaxLength(12, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Telephone { get; set; }

        [Display(Name = "شماره همراه")]
        [MaxLength(12, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Mobail { get; set; }

        [Display(Name = "نشانی")]
        public string Address { get; set; }

        public virtual ICollection<HesabMoshtari> hesabMoshtari { get; set; }
    }
}
