namespace BlazorApp1.Pages
{
    public partial class Todo
    {
        private string? newTodo;

        private List<TodoItem> todos = new();

        private void Add()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }


        private void Dell(TodoItem todoItem)
        {
            todos.Remove(todoItem);
        }

    }
}
