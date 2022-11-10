namespace Library
{
    public class VisitorN2 : IVisitor
    {
        private Node nodomayor;
        private int size = 0;
        public override void Visit(Node nodo)
        {
            int cantidadHijos = nodo.Children.Count;
            if(size <= cantidadHijos)
            {
                nodomayor =  nodo;
                size = cantidadHijos;
            }
            nodomayor.Person.Accept(this);

            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }
        }
        public override void Visit(Person persona)
        {
            ContentBuilder.Append($"La persona con mas hijos es: {nodomayor.Person.Name}");
        }


    }
}