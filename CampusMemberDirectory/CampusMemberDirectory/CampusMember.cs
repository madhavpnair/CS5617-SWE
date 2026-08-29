namespace CampusMemberDirectory;

public abstract class CampusMember
{
    protected CampusMember(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract string DescribeRole();

    public virtual string Introduce()
    {
        return $"Hello, my name is {Name}. I am a {DescribeRole()}.";
    }

}
