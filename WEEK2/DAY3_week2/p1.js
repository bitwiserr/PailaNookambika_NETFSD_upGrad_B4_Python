// Function to show confirmation message
function showConfirmation() {
  const confirmation = document.getElementById("confirmation");
  confirmation.style.display = "block";
}

// Attach event listener after DOM is loaded
document.addEventListener("DOMContentLoaded", () => {
  const feedbackBtn = document.getElementById("feedback-btn");
  feedbackBtn.addEventListener("click", showConfirmation);
});
