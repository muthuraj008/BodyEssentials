import axios from "axios";
import { useEffect, useState } from "react";

const baseURL = "https://localhost:7196/api/Product";

function AllProducts() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    axios.get(baseURL).then((response) => {
      setProducts(response.data);
    });
  }, []);

  return (
    <div>
      <h2>My products</h2>
      <ul>
        {products.map((product: any) => (
          <li key={product.id}>
            {product.productName} in category {product.catagory}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default AllProducts;
