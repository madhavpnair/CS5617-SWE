namespace CampusMemberDirectory;

public abstract class CampusMember
{
    protected CampusMember(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract string DescribeRole();

}
