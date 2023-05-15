using Microsoft.AspNetCore.Components.Forms;

namespace BlazorSampleCrud.App.UI.Infrastructures
{
    public class BootstrapCssClassProvider:FieldCssClassProvider
    {
        //public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        //{
        //    var IsValid = !editContext.GetValidationMessages(fieldIdentifier).Any();
        //    if (editContext.IsModified(fieldIdentifier))
        //    {
        //        return IsValid ? "is-valid" : "is-invalid";
        //    }

        //    return IsValid ? "" : "is-invalid";


        //}

        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var IsValid = !fieldIdentifier.FieldName.Contains(".") || editContext.GetValidationMessages(fieldIdentifier).Any()==false;
            return IsValid ? "is-valid" : "is-invalid";
        }
    }
}
