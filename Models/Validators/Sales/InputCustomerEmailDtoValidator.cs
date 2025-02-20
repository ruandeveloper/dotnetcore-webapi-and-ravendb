﻿using dotnetcore_webapi_and_ravendb.Models.Dtos.SalesDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_webapi_and_ravendb.Models.Validators.Sales
{
    public class InputCustomerEmailDtoValidator : AbstractValidator<InputCustomerEmailDto>
    {
        public InputCustomerEmailDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}
