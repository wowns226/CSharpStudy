using System;

namespace GroupBy
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

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

                foreach (var profile in Group.Profiles)
                    Console.WriteLine($">>> {profile.Name}, {profile.Height}");
            }
        }
    }
}