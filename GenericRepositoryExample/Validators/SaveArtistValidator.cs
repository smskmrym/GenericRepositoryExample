using FluentValidation;
using GenericRepositoryExample.Models.Dto;

namespace GenericRepositoryExample.Validators
{
    public class SaveArtistValidator : AbstractValidator<SaveArtistDto>
    {
        public SaveArtistValidator()
        {
            RuleFor(artist => artist.Name).NotEmpty().MaximumLength(30);
        }
    }
}
