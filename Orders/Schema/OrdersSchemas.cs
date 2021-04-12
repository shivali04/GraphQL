using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Orders.Schema
{
    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(OrdersQuery query, IDependencyResolver resolver)
        {
            Query = query;
            DependencyResolver = resolver;
        }

        public IDependencyResolver DependencyResolver { get; }
    }
}
