namespace NETMVC.Models 
{
    public class ProductModel
    {
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Picture { get; set; }
        public double UnitPrice { get; set; }
        public virtual CatalogModel Catalog { get; set; }
    }
}