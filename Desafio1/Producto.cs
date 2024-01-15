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

    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }

    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }

    public double Costo
    {
        get { return _Costo; }
        set { _Costo = value; }
    }

    public double PrecioVenta
    {
        get { return _PrecioVenta; }
        set { _PrecioVenta = value; }
    }

    public int Stock
    {
        get { return _Stock; }
        set { _Stock = value; }
    }

    public int IdUsuario
    {
        get { return _IdUsuario; }
        set { _IdUsuario = value; }
    }

    #endregion Propiedades
}
