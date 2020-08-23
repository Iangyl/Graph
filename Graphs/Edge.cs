namespace Graphs
{
    class Edge
    {
        public Vertex From { get; private set; }
        public Vertex To { get; private set; }
        public int Weight { get; private set; }
        public bool Oriented { get; private set; }
        public Edge(Vertex From, Vertex To, int Weight = 1)
        {
            this.From = From;
            this.To = To;
            this.Weight = Weight;
        }
        public override string ToString()
        {
            return $"({From}; {To})";
        }
    }
}
