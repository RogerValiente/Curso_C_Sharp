using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    public class Venta
    {
        #region Variables

        private int _Id;
        private string _Comentarios;
        public int _IdUsuario;

        #endregion Variables

        #region Constructores

        public Venta()
        {
            _Id = 0;
            _Comentarios = string.Empty;
            _IdUsuario = 0;
        }

        #endregion Constructores

        #region Propiedades

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Comentarios
        {
            get { return _Comentarios; }
            set { _Comentarios = value; }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        #endregion Propiedades
    }
}
