using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    public class ProductoVendido
    {
        #region Variables

        private int _Id;
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;

        #endregion Variables

        #region Constructores

        public ProductoVendido()
        {
            _Id = 0;
            _IdProducto = 0;
            _Stock = 0;
            _IdVenta = 0;
        }

        #endregion Constructores

        #region Propiedades

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        #endregion Propiedades
    }
}
