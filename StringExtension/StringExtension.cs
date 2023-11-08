namespace StringExtension
{
    public static class StringExtension
    {
        /// <summary>
        /// Split string by length
        /// </summary>
        /// <param name="text">String to be splitted</param>
        /// <param name="chunkLength">Length size</param>
        /// <returns>Enumerable with splitted stirng</returns>
        public static IEnumerable<string> SplitBy(this string text, int chunkLength)
        {
            if (string.IsNullOrEmpty(text)) throw new ArgumentException();

            if (chunkLength < 1) throw new ArgumentException();

            for (int i = 0; i < text.Length; i += chunkLength)
            {
                if (chunkLength + i > text.Length)
                    chunkLength = text.Length - i;

                yield return text.Substring(i, chunkLength);
            }
        }
    }
}