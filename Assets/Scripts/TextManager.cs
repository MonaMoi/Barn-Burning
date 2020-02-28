using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TextManager : MonoBehaviour
{

    private TextMeshPro test;
    private string a = "Ich hatte Hae-mi auf der Hochzeitsfeier eines Bekannten kennengelernt und mich mit ihr angefreundet";
    private string b = "Ihr Einkommen war minimal und sie lebte vom Wohlwollen ihrer Liebhaber";
    private string c = "Wir trafen uns nicht besonders häufig. Meist ein-, höchstens zwei Mal im Monat";
    private string d = "Wir gingen zusammen essen oder tranken etwas in einer Bar. Und wir führten leidenschaftliche Gespräche";
    private string e = "Natürlich bezahlte ich immer die Rechnung für das, was wir tranken und aßen. Manchmal rief auch sie mich an, meistens dann, wenn sie kein Geld, aber Hunger hatte";
    private string f = "Sie flog nach Algerien und bat mich in der Zeit Ihre Katze zu füttern. Jeden Tag ging ich bei ihr vorbei. Die Katze bekam ich aber nie zu Gesicht";
    private string g = "Drei Monate später war sie wieder da. Sie hatte drei Kilo abgenommen und war braungebrannt… Und sie brachte einen neuen Liebhaber mit";
    private string h = "Er war Mitte bis Ende zwanzig und groß, war korrekt gekleidet und hatte eine höfliche Art zu reden";
    private string i2 = "Sein Gesichtsausdruck war etwas nichtssagend, aber er sah gut aus und machte keinen schlechten Eindruck";
    private string j = "Er erzählte, dass er Handelsgeschäfte betreibe, doch über den Inhalt dieser Geschäfte sagte er nichts weiter";
    private string k = "Ich habe ihn danach mehrmals wiedergetroffen. Jedes Mal, wenn ich ihr zufällig irgendwo begegnete, stand er mit Sicherheit neben ihr. Verabredete ich mich mit ihr, brachte er sie mit dem Auto zu unserem Treffpunkt";

    void Start()
    {
        StartCoroutine("changeText");

        test = GetComponent<TextMeshPro>();
        test.text = a;
    }

    void Update()
    {
        
    }


    private void TextClear()
    {
        test.text = "";
    }

    private IEnumerator changeText()
    {
        // for(int i = 0; i < 3; i++) { 
        yield return new WaitForSeconds(0f);
        for (int i = 9; i <10; i++) {
            if (test.text == a)
            {

                yield return new WaitForSeconds(5.0f); //Hier ist, solange a da ist, danach kommt b
                test.text = b;
                

            }
            else if (test.text == b)
            {
                yield return new WaitForSeconds(5.0f);
                test.text = c;
            }
            else if (test.text == c)
            {
                yield return new WaitForSeconds(5.0f);
                test.text = d;
            }
            else if (test.text == d)
            {
                yield return new WaitForSeconds(6.0f);
                test.text = e;
            }
            else if (test.text == e)
            {
                yield return new WaitForSeconds(9.0f);
                test.text = f;
            }
            else if (test.text == f)
            {
                yield return new WaitForSeconds(10.0f);
                test.text = g;
            }
            else if (test.text == g)
            {
                yield return new WaitForSeconds(8.0f);
                test.text = h;
            }
            else if (test.text == h)
            {
                yield return new WaitForSeconds(6.0f);
                test.text = i2;
            }
            else if (test.text == i2)
            {
                yield return new WaitForSeconds(6.0f);
                test.text = j;
            }
            else if (test.text == j)
            {
                yield return new WaitForSeconds(7.0f);
                test.text = k;
            }
            StartCoroutine("changeText");
        }
    }
}

