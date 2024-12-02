using Hoton.Tokenizer.Interfaces;
using JiebaNet.Segmenter;

namespace Hoton.Tokenizer.Services;

public class TokenizerService : ITokenizerService
{
    private static readonly JiebaSegmenter _segmenter = new();

    public IEnumerable<string> TokenizeForSearch(string text)
    {
        var tokens = _segmenter.CutForSearch(text)
            .SelectMany(token => token.Length == 1 ? [token] : token.Select(c => c.ToString()))
            .Distinct();
        return tokens;
    }
}
