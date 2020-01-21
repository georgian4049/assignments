using System;

public class room
{
	int price;
	string name;
	int[,] loc= new int[1,1];
	public void set_details(string nam)
	{
		name=nam;
	}
	public void display_name()
	{
		Console.Write("name of this room is "+name);
	}
}
					
public class Program
{	
	public static void Main()
	{
		string room_name;
		room a= new room();
		Console.Write("Buddy enter the room's name\n");
		room_name=Console.ReadLine();
		a.set_details(room_name);
		a.display_name();
			}
}
