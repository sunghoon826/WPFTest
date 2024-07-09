using System.Windows.Media;
using Wpf.Ui.Controls;
using WPFApp.ViewModels.Pages;

namespace WPFApp.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel> // 대시보드가 생성될때 뷰모델을 가져옴
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel) 
        {
            ViewModel = viewModel;
            DataContext = this;

            ViewModel.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
        }

        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e) //어떤값들이 변경 되었는지 알수 있음.
        {
            switch (e.PropertyName)
            {
                case "Text":

                    this.btnClickMe.Background = new SolidColorBrush(Colors.White);

                    break;
                    
            }
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
