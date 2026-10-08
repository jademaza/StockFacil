namespace StockFacil.Services
{
    public class ProductoService
    {
        public bool ValidarProducto(string nombre, decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            if (precio <= 0)
            {
                return false;
            }

            return true;
        }
    }
}