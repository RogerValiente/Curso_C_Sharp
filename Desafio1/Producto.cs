using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Producto
{
    #region Variables

    private int _Id;
    private string _Description;
    private double _Costo;
    private double _PrecioVenta;
    private int _Stock;
    private int _IdUsuario;

    #endregion Variables

    #region Constructores

    public Producto()
    {
        _Id = 0;
        _Description = string.Empty;
        _Costo = 0.0;
        _PrecioVenta = 0.0;
        _Stock = 0;
        _IdUsuario = 0;
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

    [Required]
    [MaxLength(2000)]
    public string Description
    {
        get { return _Description; }
        set
        {
            if (this._Description != value)
            {
                this._Description = value;
            }
        }
    }

    public double Costo
    {
        get { return _Costo; }
        set
        {
            if (this._Costo != value)
            {
                this._Costo = value;
            }
        }
    }

    public double PrecioVenta
    {
        get { return _PrecioVenta; }
        set
        {
            if (this._PrecioVenta != value)
            {
                this._PrecioVenta = value;
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

    public int IdUsuario
    {
        get { return _IdUsuario; }
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
