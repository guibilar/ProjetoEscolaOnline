using FluentValidation;
using OnlineSchool.Busness.Academico.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.Busness.Models.Validations
{
    public class MaterialDeApoioValidation : AbstractValidator<MaterialDeApoio>
    {
        public MaterialDeApoioValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Link)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}
