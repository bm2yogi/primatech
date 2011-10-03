using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PrimatechMVC.Models
{
    [MetadataType(typeof(WidgetModelMetadata))]
    public class Widget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class WidgetModelMetadata
    {
        [Required, ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Remote("SkuExists", "Widgets")]
        public string SKU { get; set; }

        [Required, Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
    }
}

public class EmailAttribute : RegularExpressionAttribute
{
    const string pattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";

    public EmailAttribute() : base(pattern) { }
}