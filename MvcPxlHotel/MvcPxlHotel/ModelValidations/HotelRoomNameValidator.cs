using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MvcPxlHotel.ModelValidations
{
    public class HotelRoomNameValidator : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
           List<ModelValidationResult> errors = new List<ModelValidationResult>();

            if (!string.IsNullOrEmpty(context.Model.ToString()))
            {
                for (int i = 0; i < context.Model.ToString().Length; i++)
                {
                    if (char.IsDigit(context.Model.ToString()[i]))
                    {
                        errors.Add(new ModelValidationResult("", "Er zijn geen cijfers toegelaten in dit veld"));

                        break;

                        //string input = context.Model.ToString();

                        //foreach (char c in input)
                        //{
                        //    if (char.IsDigit(c))
                        //    {
                        //        result.Add(new("", "No digits allowed in the room name.")); break;
                        //    }
                        //}
                    }
                }

            
            }
            return errors;
        }
    }
}
