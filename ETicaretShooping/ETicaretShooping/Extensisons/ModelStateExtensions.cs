using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ETicaretShooping.Extensisons
{
    public static class ModelStateExtensions
    {
        public static void AddModelErrorList(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, List<string> errors)
        {
            errors.ForEach(x =>
            {
                modelState.AddModelError(string.Empty, x);
            });
        }

        public static void AddModelErrorList(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState, IEnumerable<IdentityError> errors)
        {
            errors.ToList().ForEach(x =>
            {
                modelState.AddModelError(string.Empty, x.Description);
            });
        }
    }
}
