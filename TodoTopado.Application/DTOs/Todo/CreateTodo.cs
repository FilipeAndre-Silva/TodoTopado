using FluentValidation;
using FluentValidation.Results;

namespace TodoTopado.Application.DTOs.Todo
{
    public class CreateTodo : BaseDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        
        public override bool IsInvalid()
        {
            var validator = new CreateTodoValidator().Validate(this);
            if(validator.IsValid)
            {
                return false;
            } 
            return true;
        }

        public override List<ValidationFailure> Erros()
        {
            var validator = new CreateTodoValidator().Validate(this);
            return validator.Errors;throw new NotImplementedException();
        }
    }

    public class CreateTodoValidator : AbstractValidator<CreateTodo>
    {
        public CreateTodoValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.Title).Length(2, 50);
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.DeadLine).NotNull();
        }
    }
}