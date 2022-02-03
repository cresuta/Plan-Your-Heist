using System;
using System.Collections.Generic;
using System.Linq;

class Team
    {
        List<HeistMember> heistTeam = new List<HeistMember>() { };

        public void AddMember(HeistMember member)
        {
            heistTeam.Add(member);
        }

        public int TeamSkillLevel()
        {
            return heistTeam.Sum(member => member.SkillLevel);
        }

        public void DisplayNumberOfMembers()
        {
            Console.WriteLine($"\nTotal number of members on team: {heistTeam.Count}");
        }

        public void DisplayHeistTeamInformation()
        {
            Console.WriteLine("Team List");
            Console.WriteLine("-------------");
            heistTeam.ForEach(member => {
                Console.WriteLine($"\nName: {member.Name} \n Skill Level: {member.SkillLevel} \n Courage Factor: {member.CourageFactor}");
            });
        }

    }