using System;

namespace MVVM
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var view = new View();
            var viewModel = new ViewModel();
            view.SetViewModel(viewModel);
            view.Show();
            view.Show2();
        }
    }
}
