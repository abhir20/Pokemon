using CsvHelper;
using System.Text;
using TinyCsvParser;

/*
 * Developed by :Abhinaya R, Date : 2/19/2022
 * Business class to read CSV file and apply conditions and return it to controller
 */
namespace Pokemon360.Business
{
    public class ReadData : IReadData
    {
       
        public IList<Pokemon> GetPokemons()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            Mapper csvMapper = new Mapper();
            IList<Pokemon> pokemons = new List<Pokemon>();
            CsvParser<Pokemon> csvParser = new CsvParser<Pokemon> (csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile(@"C:\Users\abhin\OneDrive\Desktop\Github\pokeman360-qvridx\Data\pokemon.csv", Encoding.ASCII)
                         .ToList();
          


            foreach (var details in result)
            {
                Pokemon pokemons1 = new Pokemon();
                {
                    if (details.Result.Legendary == true && (details.Result.Type1 != "Ghost") || details.Result.Type2 != "Ghost")
                        {
                        pokemons1.Name = details.Result.Name;

                        pokemons1.Type1 = details.Result.Type1;

                        pokemons1.Type2 = details.Result.Type2;

                        if (details.Result.Name.StartsWith("G"))
                        {
                            int count = 0;
                            if (details.Result.Name.Contains("G"))
                            {
                                count++;
                            }


                            pokemons1.Defense = (details.Result.Name.Length - count) * 5;
                        }
                        else
                        {
                            pokemons1.Defense = details.Result.Defense;
                        }
                        if (!string.IsNullOrEmpty(details.Result.Type1) && !string.IsNullOrEmpty(details.Result.Type2))
                        {
                            if (details.Result.Type1 == "Fire" || details.Result.Type2 == "Fire")
                            {
                                pokemons1.Attack = details.Result.Attack - details.Result.Attack * 0.1;
                            }
                            else if (details.Result.Type1 == "Bug" || details.Result.Type2 == "Bug" || details.Result.Type1 == "Flying" || details.Result.Type2 == "Flying")
                            {

                                pokemons1.Attack = details.Result.Attack + details.Result.Attack * 0.1;
                            }
                            else

                                pokemons1.Attack = details.Result.Attack;
                        }
                        

                        pokemons1.SpAttack = details.Result.SpAttack;

                        pokemons1.HP = (!string.IsNullOrEmpty(details.Result.Type1) && details.Result.Type1 == "Steel" || details.Result.Type2 == "Steel" ) ? details.Result.HP * 2 : details.Result.HP;

                        pokemons1.Generatior = details.Result.Generatior;

                        pokemons1.Legendary = details.Result.Legendary;

                        pokemons1.Speed = details.Result.Speed;

                        pokemons1.Total = details.Result.Total;

                        pokemons1.SpDef = details.Result.SpDef;
                    }

                }
                pokemons.Add(pokemons1);
            }

            return pokemons;
        }
    }
}
