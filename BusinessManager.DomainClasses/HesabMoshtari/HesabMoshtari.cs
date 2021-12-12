using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessManager.DomainClasses
{
    public class HesabMoshtari
    {
        public HesabMoshtari()
        {

        }

        [Key]
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "شناسه مشتری")]
        public int MoshtariId { get; set; }

        [Display(Name = "تاریخ میلادی")]
        public DateTime? date { get; set; }

        [Display(Name = "تاریخ")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        public string dateShamsi { get; set; }


        [Display(Name ="شرح")]
        [Required(ErrorMessage ="{0} نمی تواند خالی باشد")]
        public string Description { get; set; }

        [Display(Name ="بدهکار")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50,ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Debtor { get; set; }

        [Display(Name ="بستانکار")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Creditor { get; set; }
        
        [Display(Name ="باقیمانده")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Remaining { get; set; }

        /// <summary>
        /// navigation prperty
        /// </summary>
        public virtual Moshtari Moshtari { get; set; }

        public virtual ICollection<RizFroosh> RizFroosh { get; set; }

    }
}
