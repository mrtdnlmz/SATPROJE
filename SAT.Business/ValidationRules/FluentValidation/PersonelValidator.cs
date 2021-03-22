using FluentValidation;
using SAT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Business.ValidationRules.FluentValidation
{
    public class PersonelValidator : AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            //RuleFor(p => p.Adi).NotEmpty().WithMessage("Ürün ismi boş olamaz");
            //RuleFor(p => p.SicilNo).NotEmpty();
            //RuleFor(p => p.iseGirisTarihi).NotEmpty();
            //RuleFor(p => p.Departman).NotEmpty();
            //RuleFor(p => p.Unvan).NotEmpty();

            //RuleFor(p => p.NetUcret).GreaterThan(0);
            //RuleFor(p => p.Foto).GreaterThanOrEqualTo((short)0);
            //RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı A ile başlamalı");

        }

    }

    //private bool StartWithA(string arg)
    //{
    //    return arg.StartsWith("A");
    //}
}
