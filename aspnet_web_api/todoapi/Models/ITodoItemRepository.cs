/*This interface represents the Repository Pattern*/
using System;
using System.Collections.Generic;

namespace todoapi
{
    public interface ITodoItemRepository
    {
        IEnumerable<TodoItem> getAll();
        TodoItem getById (Guid id);
        TodoItem add(TodoItem todo);
        TodoItem remover (Guid id);
        void update (TodoItem todo);
    }
}