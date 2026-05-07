namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Represents the data required to create a new user.
    /// </summary>
    internal class CreateUserCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
