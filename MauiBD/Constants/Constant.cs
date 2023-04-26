

using MauiBD.ViewModel;
using Microsoft.Win32.SafeHandles;

namespace MauiBD.Constants;

public static  class Constant
{
    public const string AUTH_TOKEN_KEY = "Auth_Token";
    public const string AUTH_NAME_KEY = "Auth_name";
    public static int Authid = 10;
    public static string AuthToken
    {
        
       get => Preferences.Get(Constants.Constant.AUTH_TOKEN_KEY, string.Empty);
        set => Preferences.Set(Constants.Constant.AUTH_TOKEN_KEY, value);
    }
    public static string AuthName
    {

        get => Preferences.Get(Constants.Constant.AUTH_NAME_KEY, string.Empty);
        set => Preferences.Set(Constants.Constant.AUTH_NAME_KEY, value);
    }
    /*public static int AuthId
    {

        //get => Preferences.Get(Constants.Constant.AUTH_ID_KEY,"");
        // set => Preferences.Set(Constants.Constant.AUTH_ID_KEY, value);
         get => Preferences.Get(A);
        set => Preferences.Get(A)
        //get => Preferences.Get(Constants.Constant.AUTH_ID_KEY, 1);

    }*/
}
