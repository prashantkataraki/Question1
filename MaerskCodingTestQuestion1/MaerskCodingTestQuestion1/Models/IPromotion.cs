using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Question1
{
    internal interface IPromotion
    {
        int Process(ProductViewModel currentProduct, List<ProductViewModel> products);

    }
}
