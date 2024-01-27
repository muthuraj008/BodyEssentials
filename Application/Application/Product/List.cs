using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class List
    {
        public class Query : IRequest<List<Product>>
        {
            
        }

        public class Handler : IRequestHandler<Query, List<Product>>
        {
            private readonly DataContext _dataContext;

            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }
            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataContext.Products.ToListAsync();
            }
        }
    }
}
