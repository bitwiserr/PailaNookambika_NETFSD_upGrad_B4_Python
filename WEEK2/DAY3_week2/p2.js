// Apply the selected theme to the body and save preference
function applyTheme(theme) {
  document.body.className = theme;
  localStorage.setItem("theme", theme);
}

// Toggle between light and dark themes
function toggleTheme() {
  const currentTheme = document.body.className;
  const newTheme = currentTheme === "light" ? "dark" : "light";
  applyTheme(newTheme);

  // Update button text for clarity
  const toggleButton = document.getElementById("theme-toggle");
  toggleButton.textContent = newTheme === "light" ? "Switch to Dark Mode" : "Switch to Light Mode";
}

// Initialize theme on page load
document.addEventListener("DOMContentLoaded", () => {
  const savedTheme = localStorage.getItem("theme") || "light";
  applyTheme(savedTheme);

  const toggleButton = document.getElementById("theme-toggle");
  toggleButton.textContent = savedTheme === "light" ? "Switch to Dark Mode" : "Switch to Light Mode";
  toggleButton.addEventListener("click", toggleTheme);
});
