namespace Smyers.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string inputString)
        {
            return new string(inputString.ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());
        }
    }
}