using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace PrimatechMVC.Validation
{
    public class EmailAttribute: RegularExpressionAttribute//, IClientValidatable
    {
        private const string emailPattern = @"^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*)\\.+[a-zA-Z]{2,9})$";

        public EmailAttribute() : base(emailPattern){}
    }
}
