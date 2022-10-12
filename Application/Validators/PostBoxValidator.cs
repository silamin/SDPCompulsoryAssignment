using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PostBoxValidator: AbstractValidator<PostBoxDTO>
{
    //to finalize
    public PostBoxValidator()
    {
        RuleFor(p => p.Price).NotEmpty();
    }
}