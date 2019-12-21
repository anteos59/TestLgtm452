using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleNetLib;

namespace TestLgtm452
{
    class Program
    {
        static void Main(string[] args)
        {
            OAuthAccessToken oauth = new OAuthAccessToken();
            oauth.AccessToken = "Test LGTM Dotnet Framework 4.5.2";
            Console.WriteLine(oauth.AccessToken);
            Console.ReadLine();
        }
    }
}
