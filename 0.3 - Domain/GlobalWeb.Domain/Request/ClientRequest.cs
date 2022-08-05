using FluentValidation;
using System;

namespace GlobalWeb.Domain.Request
{
    public class ClientRequest
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
    }
    public class ClientRequestValidator : AbstractValidator<ClientRequest>
    {
        public ClientRequestValidator()
        {
            RuleFor(i => i.FullName)
                .NotEmpty()
                .WithMessage("Nome deve ser informado.")
                .NotNull()
                .WithMessage("Nome deve ser informado.");


            RuleFor(i => i.BirthDate)
                .NotEmpty()
                .WithMessage("Data de nascimento deve ser informado.")
                .NotNull()
                .WithMessage("Data de nascimento deve ser informado.");

            RuleFor(i => i.Document)
                .NotEmpty()
                .WithMessage("Documento deve ser informado.")
                .NotNull()
                .WithMessage("Documento deve ser informado.");

            RuleFor(i => i.Address)
                .NotEmpty()
                .WithMessage("Endereço deve ser informado.")
                .NotNull()
                .WithMessage("Endereço deve ser informado.");
        }
    }
}
