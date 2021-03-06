namespace Gof.Behavioral.Visitor
{
    public class Klass : AstNode
    {
        public Klass(string name, Klass parent)
        {
            Name = name;
            Parent = parent;
        }

        public Klass(string name) : this(name, new Klass("obj", null)) {}

        public string Name { get; }
        public Klass Parent { get; }

        public override string Stringify(ISerializer serializer) => serializer.Serialize(this);
    }
}
