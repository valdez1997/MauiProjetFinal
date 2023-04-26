using MauiBD.View;
using MauiBD.ViewModel;

namespace MauiBD;

public partial class AppShell : Shell
{
	public AppShell()
	{
        
		InitializeComponent();
        
        Routing.RegisterRoute(nameof(WelcomePage), typeof(WelcomePage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(StartPage), typeof(StartPage));
        Routing.RegisterRoute(nameof(CentreHospitalierPage), typeof(CentreHospitalierPage));
        Routing.RegisterRoute(nameof(ArticlesPage), typeof(ArticlesPage));
        Routing.RegisterRoute(nameof(FaqPage), typeof(FaqPage));
        Routing.RegisterRoute(nameof(TestdePredonPage), typeof(TestdePredonPage));
        Routing.RegisterRoute(nameof(EditProfilPage), typeof(EditProfilPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(Register2Page), typeof(Register2Page));
        Routing.RegisterRoute(nameof(Rdv2Page), typeof(Rdv2Page));
        Routing.RegisterRoute(nameof(RdvPage), typeof(RdvPage));
        Routing.RegisterRoute(nameof(EditPasswordPage), typeof(EditPasswordPage));
        Routing.RegisterRoute(nameof(ArticleDetailPage),typeof(ArticleDetailPage));
        Routing.RegisterRoute(nameof(ParameterPage), typeof(ParameterPage));
        Routing.RegisterRoute(nameof(EditPassword1Page), typeof(EditPassword1Page));


    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }
}
