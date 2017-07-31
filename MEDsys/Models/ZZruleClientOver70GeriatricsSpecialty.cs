using System;
using System.ComponentModel.DataAnnotations;
using MEDsys.ViewModels;
using System.Data.Entity;

namespace MEDsys.Models
{
    public class ZZruleClientOver70GeriatricsSpecialty : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            //Would have to get Client data and employee data based on ID and then do a compare of the attributes
                return ValidationResult.Success;
            
            


        }
    }
}