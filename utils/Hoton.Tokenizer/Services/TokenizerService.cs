using Hoton.Tokenizer.Interfaces;
using JiebaNet.Segmenter;

namespace Hoton.Tokenizer.Services;

public class TokenizerService : ITokenizerService
{
    private static readonly JiebaSegmenter _segmenter = new();

    public IEnumerable<string> TokenizeForSearch(string text)
    {
        return _segmenter.CutForSearch(text);
    }
}
