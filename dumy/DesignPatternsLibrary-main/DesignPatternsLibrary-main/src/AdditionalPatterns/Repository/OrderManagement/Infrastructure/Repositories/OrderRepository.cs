﻿using OrderManagement.Domain;
using OrderManagement.Infrastructure.Repositories.Contracts;

namespace OrderManagement.Infrastructure.Repositories;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(OrderManagementContext context)
        : base(context)
    {
    }

    public Order? GetTheMostExpensive() =>
        _context.Orders
            .OrderByDescending(order => order.Price)
            .FirstOrDefault();
}
