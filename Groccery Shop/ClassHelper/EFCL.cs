using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groccery_Shop.ClassHelper
{
    internal class EFCL
    {
        public static DB.ProductShopEntities Context { get; } = new DB.ProductShopEntities();
    }
}