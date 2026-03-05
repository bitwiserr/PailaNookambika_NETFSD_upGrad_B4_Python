// Function to add a new task
function addTask() {
  const taskInput = document.getElementById("task-input");
  const taskText = taskInput.value.trim();

  if (taskText === "") return; // ignore empty input

  const taskList = document.getElementById("task-list");

  // Create new list item
  const li = document.createElement("li");
  li.innerHTML = `
    <span class="task-text">${taskText}</span>
    <button class="delete-btn">Delete</button>
  `;

  taskList.appendChild(li);
  taskInput.value = ""; // clear input
}

// Function to handle task actions (event delegation)
function handleTaskActions(event) {
  const target = event.target;

  // Mark task as completed when clicking on text
  if (target.classList.contains("task-text")) {
    target.parentElement.classList.toggle("completed");
  }

  // Delete task when clicking delete button
  if (target.classList.contains("delete-btn")) {
    target.parentElement.remove();
  }
}

// Initialize event listeners
document.addEventListener("DOMContentLoaded", () => {
  const addBtn = document.getElementById("add-btn");
  const taskList = document.getElementById("task-list");

  addBtn.addEventListener("click", addTask);
  taskList.addEventListener("click", handleTaskActions); // event delegation
});
