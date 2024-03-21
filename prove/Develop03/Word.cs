using System.Collections.Generic;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
       _text = text;
    }

    public void Hide()
    {
        _isHidden = true;

    }
     public void Show()
    {
        _isHidden=false;

    }
     public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string guion = "";
            int longitud = _text.Length;

            while (guion.Length < longitud)
            {
                guion += "_";
            }
            return guion;
        }
        else
        {
            return _text;
        }
    }

}