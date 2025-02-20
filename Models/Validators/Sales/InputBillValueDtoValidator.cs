using dotnetcore_webapi_and_ravendb.Models.Dtos.SalesDtos;
using FluentValidation;

namespace dotnetcore_webapi_and_ravendb.Models.Validators.Sales
{
    public class InputBillValueDtoValidator : AbstractValidator<InputBillValueDto>
    {
        public InputBillValueDtoValidator()
        {
            RuleFor(x => x.Value).GreaterThan(0);
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}