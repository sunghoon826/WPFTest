using WPFApp.Interfaces;

namespace WPFApp.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject // OnPropertyChanged 와 같은 함수들이 정의되어있음.
    {
        private readonly IDateTime _iDateTime;
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
        //[ObservableProperty]
        //private string? text = string.Empty;

        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private string? currentTime= string.Empty;

        public DashboardViewModel(IDateTime dateTime)
        {
            this._iDateTime = dateTime; //생성될때 객체 변수에 할당됨.
        }

        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
            //this.Text = "Clicked!!"; 
        }
        [RelayCommand]
        private void OnTextChanged()
        { 
            this.CurrentTime = this._iDateTime.GetCurentTime().ToString();
            //버튼을 클릭할때, OnTextChanged() 커맨드에 의해서 함수가 호출되고,
            //인터페이스를 통해서 서비스에서 제공하는 getCurrentTime 이라는 함수를 호출해서 DateTime.Now를 가져옴
            //그러면 DateTime.Now를는 이 CurrentTime 이라는 속성에 지정이 되고 데이터 바인딩을 통해서이 TextBlock에 표시됨.

            // 뷰 모델에서는 인터페이스 객체에서 명시적으로 제공하는 메소드들만 호출해서 쓰도록 구현.
            //crud 작업도 서비스 클래스를 만들고 인터페이스로 데이터베이스 인터페이스를 하나 생성해서 그 인터페이스를
            //     뷰 모델에서 가져다가 CRUD 함수들을 호출하고 거기에 대한 실질적인 로직은 서비스 클래스들에서 수행을 하도록 설계를 하고 개발을 하도록 구현
        }
        
    }
}
