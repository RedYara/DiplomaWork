﻿using Application.Interfaces;
using MediatR;

namespace Application.CQRS.Commands.Order.CreateOrder
{
    public class CreateOrderCommandHandler(IWebDbContext dbContext) : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IWebDbContext _dbContext = dbContext;

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Domain.Order
            {
                CreationDate = DateTime.Now,
                RowId = request.RowId,
                Name = request.Name,
                Phone = request.Phone,
                RowType = request.rowType,
                Email = request.Email,
                Status = "В обработке"
            };
            await _dbContext.Orders.AddAsync(order, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return order.Id;

        }
    }
}
