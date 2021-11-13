namespace Smyers.Extensions
{
    public static class IntExtensions
    {
        public static string CommaDelimitAndSpace(this int[] inputArray)
        {
            return String.Join(", ", inputArray);
        }
    }
}