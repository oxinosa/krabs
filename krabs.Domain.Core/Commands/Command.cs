﻿using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Text;
using krabs.Domain.Core.Events;

namespace krabs.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
