using System.Collections.Generic;
public class Scripture
{
    Reference _reference;
    List<Word> _words;
    Random _random; // exceeding the core requirement

    public Scripture(Reference Reference,List<Word> words)
    {
        _reference=Reference;
        _words=words;
        _random = new Random(); // exceeding the core requirement
    
    }

    public void HideRandomWords(int wordsToHide) // exceeding the core requirement
    {
    
    List<int> indexesToHide = new List<int>();

    while (indexesToHide.Count < wordsToHide)
    {
        int index = _random.Next(0, _words.Count);
        
        // Verificar index
        if (!indexesToHide.Contains(index))
        {
            indexesToHide.Add(index);
        }
    }

    foreach (int index in indexesToHide)
    {
        _words[index].Hide();
    }

    }

    public string GetDisplayText()
    {

        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }
        return displayText;
    

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetDisplayText() != new string('_', word.GetDisplayText().Length))
            {
                return false;
            }
        }
        return true;
    }

}