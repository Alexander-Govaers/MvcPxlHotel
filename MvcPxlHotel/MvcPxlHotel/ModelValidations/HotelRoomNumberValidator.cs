using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MvcPxlHotel.ModelValidations
{
    public class HotelRoomNumberValidator : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            List<ModelValidationResult> list = new List<ModelValidationResult>();

            if (!string.IsNullOrEmpty(context.Model.ToString()))
            {
                if(int.TryParse(context.Model.ToString(), out int number))
                {
                    if (number < 10 || number > 100)
                    {
                        list.Add(new ModelValidationResult("", "Hotelnummer moet tussen de 10 en 100 liggen"));
                    }
                }
                else
                {
                    list.Add(new ModelValidationResult("", "Moet een getal zijn!"));

                }
                
            }

            return list;
        }
    }
}
