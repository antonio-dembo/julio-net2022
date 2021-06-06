using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace todoapi
{
    public class TodoItemRepositoryMemory : ITodoItemRepository
    {
        private readonly ConcurrentDictionary<Guid,TodoItem> data = new ConcurrentDictionary<Guid, TodoItem>();
        public TodoItemRepositoryMemory(){
            add(new TodoItem {Name = "Tarefa 1", Description= "Minha tarefa 1", IsComplete=false});
            add(new TodoItem {Name = "Tarefa 2", Description= "Minha tarefa 2", IsComplete=true});
        }
        public TodoItem add(TodoItem todo)
        {
            todo.Id = Guid.NewGuid();
            if( data.TryAdd(todo.Id , todo)){
                return todo;
            }
            throw new Exception("Falha de insersão. Id já existe.");
        }

        public IEnumerable<TodoItem> getAll()
        {
            return data.Values;
        }

        public TodoItem getById(Guid id)
        {
            TodoItem todoitem;
            data.TryGetValue(id, out todoitem);
            return todoitem;
        }

        public TodoItem remover(Guid id)
        {
            TodoItem todoitem;
            data.TryRemove(id, out todoitem);
            return todoitem;
        }

        public void update(TodoItem todo)
        {
            data[todo.Id] = todo ;
        }
    }

}