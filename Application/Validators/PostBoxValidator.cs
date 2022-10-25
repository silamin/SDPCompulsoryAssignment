using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PostBoxValidator: AbstractValidator<PostBoxDTO>
{
    //to finalize
    public PostBoxValidator()
    {
        RuleFor(p => p.Length).GreaterThan(0);
        RuleFor(p => p.Width).GreaterThan(0);
        RuleFor(p => p.Height).GreaterThan(0);
        RuleFor(p => p.Weight).GreaterThan(0);

    }
}