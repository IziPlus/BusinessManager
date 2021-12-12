using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessManager.DomainClasses
{
    public class HesabFrooshande
    {
        public HesabFrooshande()
        {

        }

        [Key]
        [Display(Name ="شناسه")]
        public int Id { get; set; }

        [Display(Name = "شناسه فروشنده")]
        public int IdFrooshande { get; set; }

        [Display(Name ="تاریخ میلادی")]
        [Required(ErrorMessage ="{0} نمی تواند خالی باشد")]
        public DateTime date { get; set; }

        [Display(Name ="تاریخ")]
        [Required(ErrorMessage ="{0} نمی تواند خالی باشد")]
        public string dateShamsi { get; set; }

        [Display(Name ="نوع")]
        [Required(ErrorMessage ="{0} نمی تواند خالی باشد")]
        public int Type { get; set; }

        [Display(Name ="مقدار")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50,ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string Meghdar { get; set; }

        [Display(Name ="باقیمانده")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string BaghiMande { get; set; }

        [Display(Name = "شماره فاکتور")]
        [Required(ErrorMessage = "{0} نمی تواند خالی باشد")]
        [MaxLength(50, ErrorMessage = " حداکثر طول {0} کراکتر {1} می باشد")]
        public string ShomareFaktor { get; set; }

        /// <summary>
        /// navigation prperty
        /// </summary>
        public virtual Frooshande Frooshande { get; set; }

        public virtual ICollection<RizKharid> RizKharid { get; set; }

    }
}
