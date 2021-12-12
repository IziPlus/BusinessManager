using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessManager.DomainClasses
{
    public class RizKharid
    {
        public RizKharid()
        {

        }

        [Key]
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "شناسه صورت حساب")]
        public int IdHesabFrooshande { get; set; }

        [Display(Name = "ردیف")]
        public int Radif { get; set; }

        [Display(Name = "شرح کالا")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(200, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Description { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        public int Count { get; set; }

        [Display(Name = "قیمت واحد")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string UnitPrice { get; set; }

        [Display(Name = "قیمت کل")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Price { get; set; }


        [Display(Name = "قیمت فروش")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string SalesPrice { get; set; }

        /// <summary>
        /// navigation prperty
        /// </summary>
        public virtual HesabFrooshande HesabFrooshande { get; set; }

    }
}
