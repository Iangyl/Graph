namespace Graphs
{
    class Vertex
    {
        public int Number { get; private set; }
        public Vertex(int Number)
        {
            this.Number = Number;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
