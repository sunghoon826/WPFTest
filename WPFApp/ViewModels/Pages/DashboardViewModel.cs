namespace WPFApp.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject // OnPropertyChanged 와 같은 함수들이 정의되어있음.
    {
        // 변경점을 트래킹을 해서 뷰 쪽에 전달한다 [ObservableProperty] -->  내부적으로 Property를 자동으로 생성해줌,
        // Property가 정의 되어있지 않아도 가져다 쓸수있음.데이터 바인딩 용도로 사용됨.

        //Set 관련구문이 내부 정의 되어있음
        // OnTextChanging(value);
        // OnTextChanging(default, value);
        // OnPropertyChanging(global::CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Text);
        // text = value; -> Clicked!! 할당 
        //            OnTextChanged(value);
        // OnTextChanged(default, value);
        // OnPropertyChanged(global::CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Text);
        [ObservableProperty]
        private string? text = string.Empty;

        [ObservableProperty]
        private int _counter = 0;

        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
            this.Text = "Clicked!!"; 
        }
        [RelayCommand]
        private void OnTextChanged()
        { 
        
        }
    }
}
