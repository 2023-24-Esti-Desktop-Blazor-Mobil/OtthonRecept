using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms.VisualStyles;
using System.Windows.Navigation;

namespace ReceptProjekt.Validation
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string)
            { string nameToValidate = (string)value; 
            NameValidationRule nvr = new NameValidationRule(nameToValidate);
            if (nvr.IsNameShort) { return new ValidationResult(false, "A név túl rövid!"); }
            if (!nvr.IsFirstLetterUppercase) { return new ValidationResult(false, "A név első betüje nagybetü kell legyen"); }
            if (!nvr.IsotherLetterLowerCase) { return new ValidationResult(false, "Csak az első betü lehet nagy betü!"); }
            if (!nvr.IsOnlyLetters) { return new ValidationResult(false, "A név csak betükből állhat!"); }
        }
        return new ValidationResult(true,"");
    }
    }
}
