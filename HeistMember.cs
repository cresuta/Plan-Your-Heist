class HeistMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public HeistMember(string name, int skillLevel, decimal courageFactor)
        {
            this.Name = name;
            this.SkillLevel = skillLevel;
            this.CourageFactor = courageFactor;
        }

    }