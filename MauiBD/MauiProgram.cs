using MauiBD.Service;
using MauiBD.View;
using MauiBD.ViewModel;
using Microsoft.Extensions.Logging;


namespace MauiBD;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//View
		
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<WelcomePage>();
        builder.Services.AddTransient<ArticlesPage>();
        builder.Services.AddTransient<EditProfilPage>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<Register2Page>();
        builder.Services.AddTransient<FaqPage>();
        builder.Services.AddTransient<StartPage>();
        builder.Services.AddTransient<TestdePredonPage>();
        builder.Services.AddTransient<CentreHospitalierPage>();
        builder.Services.AddTransient<RdvPage>();
        builder.Services.AddTransient<Rdv2Page>();
        builder.Services.AddTransient<EditPasswordPage>();
        builder.Services.AddTransient<ArticleDetailPage>();
        builder.Services.AddTransient<ParameterPage>();
        builder.Services.AddTransient<EditPassword1Page>();
        builder.Services.AddTransient<ApropoPage>();
        builder.Services.AddTransient<ProfilPage>();






        //Services
        builder.Services.AddSingleton<LoginService>();
        builder.Services.AddTransient<ArticleService>();
        builder.Services.AddTransient<LogoutService>();
        builder.Services.AddTransient<ServiceHospital>();
        builder.Services.AddTransient<ServiceCheckMail>();
        builder.Services.AddTransient<ResetPasswordService>();
        builder.Services.AddTransient<ServiceDisplayProfil>();
       


        //ViewModel
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<BaseViewModel>();
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<StartViewModel>();
        builder.Services.AddTransient<WelcomeViewModel>();
        builder.Services.AddTransient<RegisterViewModel>();
        builder.Services.AddTransient<Register2ViewModel>();
        builder.Services.AddTransient<ArticleViewModel>();
        builder.Services.AddTransient<ArticleDetailViewModel>();
        builder.Services.AddTransient<ParameterViewModel>();
        builder.Services.AddTransient<CenterHospitalViewModel>();
        builder.Services.AddTransient<EditPassword1ViewModel>();
        builder.Services.AddTransient<EditPasswordViewModel>();
        builder.Services.AddTransient<ProfilViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
