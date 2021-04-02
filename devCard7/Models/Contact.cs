using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devCard7.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="پرکردن این فیلد اجباری است")]
        [MinLength(3, ErrorMessage ="حداقل کاراکتر لازم 3 می باشد")]
        [MaxLength(100, ErrorMessage ="حداکثر کاراکتر قابل نوشتن 100 می باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "پرکردن این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
