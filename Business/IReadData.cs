using TinyCsvParser;



/*
 * Developed by :Abhinaya R, Date : 2/19/2022
 * Interface class with read data method
 */


namespace Pokemon360.Business
{
    public interface IReadData
    {
        IList<Pokemon> GetPokemons();
    }
}
