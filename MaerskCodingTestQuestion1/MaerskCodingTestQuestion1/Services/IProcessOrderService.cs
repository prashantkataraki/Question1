using MaerskCodingTestQuestion1.Question1;
using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Services
{
    public interface IProcessOrderService
    {
        string Calculatte();

        string Add(ProductViewModel product);

        string Edit(ProductViewModel product);

        List<ProductViewModel> GetAllProducts();
    }
}
