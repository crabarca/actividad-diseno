namespace Activity2
{
    public class User
    {
        public string Name { get; }
        public int Age { get; }
        public MembershipType Membership { get; }
        public Gender Gender { get; }

        public User(string name, int age, MembershipType membership, Gender gender)
        {
            Name = name;
            Age = age;
            Membership = membership;
            Gender = gender;
        }
    }
}