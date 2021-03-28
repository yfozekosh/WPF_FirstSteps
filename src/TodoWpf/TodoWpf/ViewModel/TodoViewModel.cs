using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TodoWpf.Annotations;

namespace TodoWpf.ViewModel
{
    public sealed class TodoViewModel : INotifyPropertyChanged
    {
        private ToDoItemViewModel _selectedItem;

        public TodoViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItemViewModel>
            {
                new ToDoItemViewModel
                {
                    Name = "A",
                    IsDone = false
                },
                new ToDoItemViewModel
                {
                    Name = "B",
                    IsDone = true
                }
            };

            // SelectedItem = ToDoItems[0];
        }
        
        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; }

        public ToDoItemViewModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var ev = PropertyChanged;
            ev?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}