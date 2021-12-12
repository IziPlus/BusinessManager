using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessManager.DomainClasses
{
    public class Frooshande
    {
        public Frooshande()
        {

        }

        [Key]
        [Display(Name ="شناسه")]
        public int Id { get; set; }

        [Display(Name ="عنوان فروشنده")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(200,ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Title { get; set; }

        [Display(Name = "شماره ثابت")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(12, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Telephone { get; set; }

        [Display(Name = "نشانی")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        public string Address { get; set; }

        public virtual ICollection<HesabFrooshande> HesabFrooshande { get; set; }
    }
}
