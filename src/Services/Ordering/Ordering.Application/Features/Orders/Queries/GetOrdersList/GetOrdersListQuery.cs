using System;
using System.Collections.Generic;
using MediatR;
using Ordering.Domain.Entities;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public string UserName { get; set; }

        public GetOrdersListQuery(string userName)
        {
            this.UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }

        
    }
}
