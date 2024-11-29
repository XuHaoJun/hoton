using Hoton.Tokenizer.Interfaces;
using JiebaNet.Segmenter;

namespace Hoton.Tokenizer.Services;

public class TokenizerService : ITokenizerService
{
    private static readonly JiebaSegmenter _segmenter = new();

    public IEnumerable<string> TokenizeForSearch(string text)
    {
        var tokens = _segmenter.CutForSearch(text);

        var result = new List<string>();

        // ngram
        foreach (var token in tokens)
        {
            if (decimal.TryParse(token, out _))
            {
                result.Add(token);
            }
            else
            {
                for (int i = 0; i < token.Length; i++)
                {
                    for (int j = i + 1; j <= token.Length; j++)
                    {
                        result.Add(token.Substring(i, j - i));
                    }
                }
            }
        }

        return result;
    }
}
