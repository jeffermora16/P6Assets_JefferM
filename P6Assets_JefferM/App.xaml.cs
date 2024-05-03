using P6Assets_JefferM.Views;

namespace P6Assets_JefferM

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
