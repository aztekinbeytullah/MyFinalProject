using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Validatör kuralları contructor içine yazılır. Benzer yapılarda olan DTO ların validasyonlarıda bu şekilde yapılır
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWhithA).WithMessage("Ürünler A harfi ile başlamalıdır");
        }

        private bool StartWhithA(string arg)
        {
            return arg.StartsWith("A");   
        }
    }
}
