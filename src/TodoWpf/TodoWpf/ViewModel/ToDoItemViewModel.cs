using System.ComponentModel;
using System.Runtime.CompilerServices;
using TodoWpf.Annotations;

namespace TodoWpf.ViewModel
{
    public class ToDoItemViewModel : INotifyPropertyChanged
    {
        private static int _idCounter = 0;
        

        public int Id { get; } = _idCounter++;

        private string _name;
        private bool _isDone;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var ev = PropertyChanged;
            ev?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}