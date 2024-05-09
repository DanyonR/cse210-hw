using System;

public class Scripture
{
    private Reference _reference;
    private List<string> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<string>(text.Split(' '));
    }

    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
}