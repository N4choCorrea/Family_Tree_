namespace Library
{
    public class VisitorN3 : IVisitor
    {
        private Person biggestnameperson;
        private int sizename = 0;
        public override void Visit(Node nodo)
        {
            nodo.Person.Accept(this);
            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }
        }
        public override void Visit(Person persona)
        {
            int cantidadletras = persona.Name.Length;
            if(sizename <= cantidadletras)
            {
                biggestnameperson = persona;
                sizename = cantidadletras;
            }
            ContentBuilder.Append($"La persona con mas letras en su nombre es: {biggestnameperson.Name}");
        }

    }
}