namespace CampusMemberDirectory;

public abstract class CampusMember
{
    protected CampusMember(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
        }

        Name = name;
    }

    public string Name { get; }

    public abstract string DescribeRole();

    public virtual string Introduce()
    {
        return $"Hello, my name is {Name}. I am a {DescribeRole()}.";
    }

}
