// Predefined product array (state)
const products = [
  "Laptop",
  "Smartphone",
  "Headphones",
  "Keyboard",
  "Mouse",
  "Monitor",
  "Smartwatch",
  "Tablet"
];

// Function to render product list
function renderProducts(filteredProducts) {
  const productList = document.getElementById("product-list");
  const noResults = document.getElementById("no-results");

  productList.innerHTML = ""; // clear previous list

  if (filteredProducts.length === 0) {
    noResults.style.display = "block";
    return;
  }

  noResults.style.display = "none";

  filteredProducts.forEach(product => {
    const li = document.createElement("li");
    li.textContent = product;
    productList.appendChild(li);
  });
}

// Function to filter products based on search input
function filterProducts(event) {
  const query = event.target.value.toLowerCase();
  const filtered = products.filter(product =>
    product.toLowerCase().includes(query)
  );
  renderProducts(filtered);
}

// Initialize app
document.addEventListener("DOMContentLoaded", () => {
  const searchBox = document.getElementById("search-box");

  // Initial render
  renderProducts(products);

  // Event delegation: listen to input changes
  searchBox.addEventListener("input", filterProducts);
});
