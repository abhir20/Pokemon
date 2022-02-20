namespace Pokemon360
{
    public class Pokemon
    {
       // Name Type 1	Type 2	Total HP  Attack Defense Sp.Atk Sp.Def Speed Generation  Legendary

        public string Name { get; set; }
        public string Type1 {  get; set; }
        public string Type2 { get; set; }

        public decimal Total { get; set; }


        public int HP { get; set; }

        public double Attack { get; set; }
        public int Defense { get; set; }

        public int SpAttack { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }


        public int Generatior { get; set; }
        public bool Legendary { get; set; }
    }
}