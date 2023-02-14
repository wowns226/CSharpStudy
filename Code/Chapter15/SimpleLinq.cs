using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main()
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="홍길동",Height=180},
                new Profile(){Name="아무개",Height=150},
                new Profile(){Name="김철수",Height=190},
                new Profile(){Name="임재준",Height=170},
                new Profile(){Name="김링큐",Height=160},
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name} {profile.InchHeight}");
        }
    }
}