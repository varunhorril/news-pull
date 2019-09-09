using GuardianNews.Annotations;
using GuardianNews.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuardianNews.Model.ViewModel
{
    public class SubscribeViewModel
    {
        [Required(ErrorMessage = ApiMessages.MISSING_EMAIL)]
        public string Email { get; set; }

        [Required(ErrorMessage = ApiMessages.MISSING_FREQUENCY)]
        [FrequencyValidation(ErrorMessage = ApiMessages.INVALID_FREQUENCY)]
        public string Frequency { get; set; }

        [Required(ErrorMessage = ApiMessages.MISSING_TOPIC)]
        public string Topic { get; set; }
    }
}
