using GuardianNews.Models;
using NewsPull.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardianNews.Annotations
{
    public class FrequencyValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (IsValidInteger(value) && IsValidFrequency(value))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ApiMessages.INVALID_FREQUENCY);
        }

        private bool IsValidInteger(object value)
        {
            try
            {
                if (value != null)
                {
                    var integer = Convert.ToInt32(value);

                    return true;
                }
            }
            catch (Exception ex)
            {

            }

            return false;
        } 

        private bool IsValidFrequency(object value)
        {
            var frequency = Convert.ToInt32(value);

            HashSet<int> validFrequencies = new HashSet<int>((int[])Enum.GetValues(typeof(FrequencyTypes)));
            if (validFrequencies.Contains(frequency))
            {
                return true;
            }

            return false;
        }
    }
}
