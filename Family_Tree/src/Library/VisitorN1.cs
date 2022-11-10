namespace Library
{
    public class VisitorN1 : IVisitor
    {
      public int SumarEdades { get; private set; }
        public override void Visit(Node nodo)
        {
            nodo.Person.Accept(this);
            foreach (Node item in nodo.Children)
            {
                item.Accept(this);
            }
        }
        public override void Visit(Person persona)
        {
            this.SumarEdades += persona.Age;
            ContentBuilder.Append($"La suma  de las edades es: {this.SumarEdades}");
        }
    }
}
            

 
