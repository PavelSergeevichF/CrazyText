using UnityEngine;
using UnityEngine.UI;

public class ViewButtonManager : MonoBehaviour
{
    private Generator _generator;
    public Text textResult;

    private void Awake()
    {
        _generator = new Generator();
        textResult = GameObject.Find("TextResult").GetComponent<Text>();
        textResult.text = "Нажмите сгенерировать";
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    public void GeneratorButton()
    {
        textResult.text=_generator.UpdateGenereit();
    }
    public void ButtonNextPerson()    { textResult.text = _generator.UpdateSelect(TypWord.Person,     true); }
    public void ButtonNextVerb()      { textResult.text = _generator.UpdateSelect(TypWord.Verb,       true); }
    public void ButtonNextAdjective() { textResult.text = _generator.UpdateSelect(TypWord.Adjective,  true); }
    public void ButtonNextNoun()      { textResult.text = _generator.UpdateSelect(TypWord.Noun,       true); }
    public void ButtonBackPerson()    { textResult.text = _generator.UpdateSelect(TypWord.Person,    false); }
    public void ButtonBackVerb()      { textResult.text = _generator.UpdateSelect(TypWord.Verb,      false); }
    public void ButtonBackAdjective() { textResult.text = _generator.UpdateSelect(TypWord.Adjective, false); }
    public void ButtonBackNoun()      { textResult.text = _generator.UpdateSelect(TypWord.Noun,      false); }
}
