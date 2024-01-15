using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return this._Id; }
            set { 
                if(this._Id != value)
                {
                    this._Id = value;
                }
            }
        }
        [Required]
        [MaxLength(2000)]
        public string Comentarios
        {
            get { return this._Comentarios; }
            set {
                if (this._Comentarios != value)
                {
                    this._Comentarios = value;
                }
            }
        }

        public int IdUsuario
        {
            get { return this._IdUsuario; }
            set
            {
                if (this._IdUsuario != value)
                {
                    this._IdUsuario = value;
                }
            }
        }

        #endregion Propiedades
    }
}
