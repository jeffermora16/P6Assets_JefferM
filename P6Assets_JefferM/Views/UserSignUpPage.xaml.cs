using P6Assets_JefferM.ViewModels;
using P6Assets_JefferM.Models;

namespace P6Assets_JefferM.Views;

public partial class UserSignUpPage : ContentPage
{

    UserViewModel? vm;

    public UserSignUpPage(UserViewModel? vm)
    {
        this.vm = vm;
    }

    public UserSignUpPage()
    {
        InitializeComponent();

        BindingContext = vm =  new UserViewModel();

        LoadUserRoles(); 
    }

    private async void LoadUserRoles()
    {
        CboxUserRole.ItemsSource = await vm.GetAllUserRolesAsync();
    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}