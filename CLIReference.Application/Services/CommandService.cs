﻿using CLIReference.Application.Interfaces;
using CLIReference.Application.ViewModels;
using CLIReference.Domain.Interfaces;

namespace CLIReference.Application.Services
{
    public class CommandService : ICommandService
    {
        public ICommandRepository _commandRepository;
        public CommandService(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }
        public CommandDTO GetCommands()
        {
            return new CommandDTO()
            {
                Commands = _commandRepository.GetCommands()
            };
        }
    }
}
