class LoginModel{
    private string _login;
    private string _password;

    private static LoginModel instance;
 
    private LoginModel()
    {}
 
    public static LoginModel getInstance()
    {
        if (instance == null)
            instance = new LoginModel();
        return instance;
    }

    public void postLogin(string? login){
        instance._login = login;
    }

    public void postPassword(string? password){
        instance._password = password;
    }

    public void checkUser(){
        if(_login.Equals("a") && _password.Equals("a")){
            Navigator.getInstance().UpdateCurrentNode("2");
        } else {
            Console.WriteLine("GO AWAY BLYAD");
            
        }
    }
}