using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.IdentityModel.Tokens;

namespace MvcPxlHotel.ModelValidations
{
    public class CountryValidator : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            List<ModelValidationResult> errors = new List<ModelValidationResult>();

           if (!string.IsNullOrEmpty(context.Model?.ToString()))
           {
               if(context.Model.ToString() != "BE" ||  context.Model.ToString() != "NL")
                {
                    errors.Add(new ModelValidationResult("", "Deze mag enkel de waardes BE of NL hebben!"));
                }
           }

           return errors;
        }
    }
}
