public abstract class Ability
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation property to Characters
    public virtual ICollection<Character> Characters { get; set; }
}