namespace StockFacil.Services
{
    public class RegistroProductoService
    {
        public bool CodigoValido(string codigo)
        {
            return !string.IsNullOrWhiteSpace(codigo);
        }
    }
}