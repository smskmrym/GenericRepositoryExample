using FluentValidation;
using GenericRepositoryExample.Models.Dto;

namespace GenericRepositoryExample.Validators
{
    public class SaveMusicValidator : AbstractValidator<SaveMusicDto>
    {
        public SaveMusicValidator()
        {
            RuleFor(music => music.Name).NotEmpty().MaximumLength(50);
            RuleFor(music => music.ArtistId).NotEmpty().WithMessage("Id must not be null or 0");
        }
    }
}
