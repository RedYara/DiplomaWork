﻿using MediatR;

namespace Diploma.Application.CQRS.Commands.Order.ChangeOrderStatus
{
    public class ChangeOrderStatusCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
