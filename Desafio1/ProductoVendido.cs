using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return _Id; }
            set
            {
                if (this._Id != value)
                {
                    this._Id = value;
                }
            }
        }

        public int IdProducto
        {
            get { return _IdProducto; }
            set
            {
                if (this._IdProducto != value)
                {
                    this._IdProducto = value;
                }
            }
        }

        public int Stock
        {
            get { return _Stock; }
            set
            {
                if (this._Stock != value)
                {
                    this._Stock = value;
                }
            }
        }

        public int IdVenta
        {
            get { return _IdVenta; }
            set
            {
                if (this._IdVenta != value)
                {
                    this._IdVenta = value;
                }
            }
        }

        #endregion Propiedades
    }
}
