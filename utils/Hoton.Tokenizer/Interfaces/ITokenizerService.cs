namespace Hoton.Tokenizer.Interfaces;

public interface ITokenizerService
{
  public IEnumerable<string> TokenizeForSearch(string text);
}