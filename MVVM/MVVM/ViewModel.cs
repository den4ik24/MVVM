using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    public class ViewModel: INotifyPropertyChanged
    {
        public ViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private string messageName;
        public string MessageName
        {
            get
            {
                return messageName;
            }
            set
            {
                messageName = value;
                OnPropertyChanged();
            }
        }

        private int messageAge;
        public int MessageAge
        {
            get
            {
                return messageAge;
            }
            set
            {
                messageAge = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Favor()
        {
            Model model = new Model();
            MessageName = model.Name();
        }

        public void Favor2()
        {
            Model model = new Model();
            MessageAge = model.Age();
        }
    }
}
