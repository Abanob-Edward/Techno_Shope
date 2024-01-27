using Context;
using Infrastructure.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class CartproudectRepository: Repository<ProductCartItem, int> , ICartproudectRepository
    {
        private readonly _Context context;
        public CartproudectRepository(_Context _context) : base(_context)
        {
            this.context = _context;

        }
    }
}
