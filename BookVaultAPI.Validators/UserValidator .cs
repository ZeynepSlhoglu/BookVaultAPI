using BookVaultAPI.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(user => user.Email).NotEmpty().EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
        }
    }
}
