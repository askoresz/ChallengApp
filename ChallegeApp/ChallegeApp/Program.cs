User user1 = new User("Adam", "32423fddf");
User user2 = new User("Monika", "32423fddf");
User user3 = new User("Andrzej", "32423fddf");
User user4 = new User("Sylwestr", "32423fddf");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;
class User

{

    public static string GameName = "Diablo";
    private List<int> score = new List<int>();



    public User(string Login, string password)
    {
        this.Login = Login;
        this.Password = password;

    }
    public string Login { get; private set; }

    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number)
    {
        this.score. Add(number);
    }

}