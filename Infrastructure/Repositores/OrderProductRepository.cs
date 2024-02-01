using Appliaction.Contract;
using Context;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class OrderProductRepository: Repository<ProductInOrder, int> , IOrderProductRepository
    {
        private readonly _Context context;
        public OrderProductRepository(_Context _context) : base(_context)
        {
            this.context = _context;

        }
    }
}
