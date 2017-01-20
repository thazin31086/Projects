namespace CMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<System.DateTime> IntroductionDate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Url { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}