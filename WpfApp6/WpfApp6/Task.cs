using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
  public  class Task
    {
        private string _name;
        private string _description;
        private bool _isCompleted;

        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            IsCompleted = false;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public bool IsCompleted
        {
            get => _isCompleted;
            set => _isCompleted = value;
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"Задача: {Name} Описание: {Description}";
        }
    }
}
