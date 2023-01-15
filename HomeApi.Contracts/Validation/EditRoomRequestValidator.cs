using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;
using HomeApi.Contracts.Models.Devices.Rooms;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов обновления комнат
    /// </summary>
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public EditRoomRequestValidator() 
        {
            RuleFor(x => x.NewName).NotEmpty();
            RuleFor(x => x.NewArea).NotEmpty();
            RuleFor(x => x.NewVoltage).NotEmpty();
        }
        
    }
}