namespace Helpers.InputParsers
{
    using System.Collections.Generic;

    public interface IParser
    {
        List<int> ReadIntegerNumbers(string sequence);
    }
}
