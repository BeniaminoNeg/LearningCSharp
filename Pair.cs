public class Pair<TFirst,TSecond>
{
	public TFirst first;
	public TSecond second;
}

public class Exetute
{
	static void Main()
	{
		Pair<int,string> pair = new Pair<int,string> {
			First = 1,
			Second = "two"
		};
		int i = pair.First; // TFirs is int
		string s = pair.Second; //TSecond is string
	}
}