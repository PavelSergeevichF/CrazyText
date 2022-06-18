
using UnityEngine;

public class Generator
{
    private string _stringResult = "Нажмите сгенерировать";
    private int _personNum    = 0;
    private int _verbNum      = 0;
    private int _adjectiveNum = 0;
    private int _nounNum      = 0;
    public Generator()
    {
    }
    public string UpdateGenereit()
    {
        _personNum = Random.Range(0, Person.word.Length - 1);
        _verbNum = Random.Range(0, Verb.word.Length - 1);
        _adjectiveNum = Random.Range(0, Adjective.word.Length - 1);
        _nounNum = Random.Range(0, Noun.word.Length - 1);
        return WriteLine();
    }
    public string UpdateSelect(TypWord typWord, bool select)
    {
        var _personSize    = Person.word.Length;
        var _verbSize      = Verb.word.Length;
        var _adjectiveSize = Adjective.word.Length;
        var _nounSize      = Noun.word.Length;
        switch (typWord)
        {
            case TypWord.Person:
                if (select) 
                {
                    if (_personNum < _personSize - 1) {  _personNum++;  }
                    else { _personNum = 0; }
                }
                else 
                {
                    if (_personNum > 0) { _personNum--; }
                    else { _personNum = _personSize-1; }
                }
                  break;
            case TypWord.Verb:
                if (select)
                {
                    if (_verbNum < _verbSize - 1) { _verbNum++; }
                    else { _verbNum = 0; }
                }
                else
                {
                    if (_verbNum > 0) { _verbNum--; }
                    else { _verbNum = _verbSize - 1; }
                }
                break;
            case TypWord.Adjective:
                if (select)
                {
                    if (_adjectiveNum < _adjectiveSize - 1) { _adjectiveNum++; }
                    else { _adjectiveNum = 0; }
                }
                else
                {
                    if (_adjectiveNum > 0) { _adjectiveNum--; }
                    else { _adjectiveNum = _adjectiveSize - 1; }
                }
                break;
            case TypWord.Noun:
                if (select)
                {
                    if (_nounNum < _nounSize - 1) { _nounNum++; }
                    else { _nounNum = 0; }
                }
                else
                {
                    if (_nounNum > 0) { _nounNum--; }
                    else { _nounNum = _nounSize - 1; }
                }
                break;
        };
        return WriteLine();
    }
    private string WriteLine()
    {
        _stringResult = Person.word[_personNum] + " ";
        _stringResult += Verb.word[_verbNum] + " ";
        _stringResult += Adjective.word[_adjectiveNum] + " ";
        _stringResult += Noun.word[_nounNum] + ".";
        return _stringResult;
    }
}
