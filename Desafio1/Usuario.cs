using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio1
{
    public class Usuario
    {
        #region Variables

        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contraseña;
        private string _Mail;

        #endregion Variables

        #region Constructor

        public Usuario()
        {
            _Id = 0;
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _NombreUsuario = string.Empty;
            _Contraseña = string.Empty;
            _Mail = string.Empty;
        }

        #endregion Constructor

        #region Propiedades

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
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

        [Required]
        [MaxLength(100)]
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (this._Nombre != value)
                {
                    this._Nombre = value;
                }
            }
        }

        [Required]
        [MaxLength(100)]
        public string Apellido
        {
            get { return _Apellido; }
            set
            {
                if (this._Apellido != value)
                {
                    this._Apellido = value;
                }
            }
        }

        [Required]
        [MaxLength(100)]
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set
            {
                if (this._NombreUsuario != value)
                {
                    this._NombreUsuario = value;
                }
            }
        }

        [Required]
        [MaxLength(20)]
        public string Contraseña
        {
            get { return _Contraseña; }
            set
            {
                if (this._Contraseña != value)
                {
                    this._Contraseña = value;
                }
            }
        }

        [Required]
        [MaxLength(255)]
        public string Mail
        {
            get { return _Mail; }
            set
            {
                if (this._Mail != value)
                {
                    this._Mail = value;
                }
            }
        }

        #endregion Propiedades
    }
}
