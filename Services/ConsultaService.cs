namespace StockFacil.Services
{
    public class ConsultaService
    {
        public bool HayStock(int stock)
        {
            return stock > 0;
        }
    }
}