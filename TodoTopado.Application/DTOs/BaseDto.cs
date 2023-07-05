using FluentValidation.Results;

namespace TodoTopado.Application.DTOs
{
    public abstract class BaseDto
    {
        public abstract bool IsInvalid();
        public abstract List<ValidationFailure> Erros();
    }
}