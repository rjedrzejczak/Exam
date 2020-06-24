using System;

namespace EnumFlagsAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que. 1
            var user1 = new user();
            user1.usergroup = Group.manager | Group.admin;
		
            Console.WriteLine( "Ans.1 - {0}", user1.usergroup);
		
            //Que. 2
            var user2 = new user();
            user2.usergroup = Group.admin;
		
            Console.WriteLine( "Ans.2 - {0}", user2.usergroup == Group.admin);
		
            //Que. 3
            var user3 = new user();
            user3.usergroup = Group.Supervisors;
		
            Console.WriteLine( "Ans.3 - {0}", user3.usergroup < Group.admin);

        }
    }
    
    public class user
    {
        public Group usergroup {get;set;}
    }
	
    [System.FlagsAttribute]
    public enum Group
    {
        user = 1,
        Supervisors = 2,
        manager = 4,
        admin = 8
    }
}