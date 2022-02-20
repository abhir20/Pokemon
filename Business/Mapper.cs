using TinyCsvParser.Mapping;

namespace Pokemon360.Business
{
    public class Mapper : CsvMapping<Pokemon>
    {
        //me Type 1	Type 2	Total HP  Attack Defense Sp.Atk Sp.Def Speed Generation  Legendary
        public Mapper()
               : base()
        {
            MapProperty(1, x => x.Name);
            MapProperty(2, x => x.Type1);

            MapProperty(3, x => x.Type2);

            MapProperty(4, x => x.Total);

            MapProperty(5, x => x.HP);

            MapProperty(6, x => x.Attack);

            MapProperty(7, x => x.Defense);

            MapProperty(8, x => x.SpAttack);

            MapProperty(9, x => x.SpDef);
            MapProperty(10, x => x.Speed);
            MapProperty(11, x => x.Generatior);

            MapProperty(12, x => x.Legendary);
        }
    }
}
