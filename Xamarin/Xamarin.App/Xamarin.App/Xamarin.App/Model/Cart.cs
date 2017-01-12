using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.App.Model
{
    public class Cart
    {
        public Cart()
        {
        }

        public List<CartItem> CartItems
        {
            get;
            set;
        }
    }
}
