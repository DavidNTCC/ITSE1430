using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Data.Memory
{
    public class MemoryProductDatabase
    {
        public Product Add( Product product, out string message )
        {

            //Check for null
            if (product == null)
            {
                message = "Product cannot be null";
                return null;
            };

            //validate product
            var error = product.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                message = error;
                return null;
            }

            //TODO: Verify Unique product;

            //Add
            var index = FindEmptyProductIndex();
            if (index >= 0)
            {
                message = "Out of memory";
                return null;
            };

            _products[index] = product;
            message = null;
            return product;
        }

        public Product Edit( Product product, out string message )
        {
            //Check for null
            if (product == null)
            {
                message = "Product cannot be null";
                return null;
            };

            //validate product
            var error = product.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                message = error;
                return null;
            }

            //TODO: Verify Unique product;

            //Find existing
            var existingIndex = GetById(product.Id);
            if (existingIndex < 0)
            {
                message = "Product not found";
                return null;
            };

            _products[existingIndex] = product;
            message = null;
            return product;
        }

        private int FindEmptyProductIndex()
        {
            for (var index = 0; index < _products.Length; ++index)
            {
                if (_products[index] == null)
                {
                    return index;
                }
            }
            return -1;
        }

        private int GetById ( int id )
        {
            for (var index = 0; index < _products.Length; ++index)
            {
                if (_products[index]?.Id == id)
                    return index;
            };

            return -1;
        }

        public void Remove ( int id )
        {
            if (id > 0)
            {
                var index = GetById(id);
                if (index >= 0)
                    _products[index] = null;
            }
        }

        public Product[] GetAll()
        {
            return _products;
        }

        private Product[] _products;
    }
}
