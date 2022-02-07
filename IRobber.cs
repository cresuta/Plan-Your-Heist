interface IRobber
{
    public string Name {get;set;}
    public int SkillLevel {get;set;}
    public int PercentageCut {get;set;}

    public virtual void PerformSkill()
    {
        
    }

    public virtual string Specialty()
    {
        return this.GetType().ToString();
    }

}