namespace ChallengeApp
{
    public abstract class Person// : System.Object
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
