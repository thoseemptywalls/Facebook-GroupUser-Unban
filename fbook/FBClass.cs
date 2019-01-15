using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace fbook
{
    class FBClass
    {
        public static string GetUserID(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic MyData = fb.Get("/me");
            return MyData.id;


        }
        public static string GetUserName(string AccessToken)
        {
            FacebookClient fb = new FacebookClient(AccessToken);
            dynamic MyData = fb.Get("/me");
            return MyData.name;
        }
    }
}
