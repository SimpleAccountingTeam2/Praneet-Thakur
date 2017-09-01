using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    /// <summary>
    /// This class is for mapping of AccountingOption to this call named AccountingOptionDtos
    /// </summary>
    public class AccountingOptionDtos
    {
        public int OptionId { get; set; }
        public string OptionDate { get; set; }
        public string OptionCommas { get; set; }
        public string OptionDecPlaces { get; set; }
        public string OptionCurrencyName { get; set; }
        public string DefaultCashorBankAcc { get; set; }
    }
}