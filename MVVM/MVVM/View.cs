using System;
namespace MVVM
{
    public class View
    {
        private ViewModel viewModel;
        public View()
        {
        }

        public void SetViewModel(ViewModel viewModel)
        {
            this.viewModel = viewModel;
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        public void Show()
        {
            viewModel.Favor();
        }

        public void Show2()
        {
            viewModel.Favor2();
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "MessageName")
            {
                Console.WriteLine($"Your teacher is {viewModel.MessageName}");

            }
            if (e.PropertyName == "MessageAge")
            {
                Console.WriteLine($"His age is {viewModel.MessageAge}");
            }
        }
    }
}
