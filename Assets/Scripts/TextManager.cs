using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TextManager : MonoBehaviour
{

    private TextMeshPro test;
    private string a = "Ich hatte Hae-mi auf der Hochzeitsfeier eines Bekannten kennengelernt.";
    private string b = "Wir trafen uns nicht besonders häufig. Meist ein-, höchstens zwei Mal im Monat.";
    private string c = "Wir gingen zusammen essen und führten leidenschaftliche Gespräche.";
    private string d = "Natürlich bezahlte ich immer die Rechnung für das, was wir tranken und aßen. Manchmal rief auch sie mich an, meistens dann, wenn sie kein Geld, aber Hunger hatte.";
    private string e = "Eines Tages fuhr sie nach Algerien und brachte drei Monate später einen Liebhaber mit.";
    private string f = "Er war Geschäftsmann, sah gut aus und machte im Ganzen keinen schlechten Eindruck.";
    private string g = "Beide besuchten mich an einem Abend.";
    private string h = "Wir aßen zusammen, tranken Bier und rauchten etwas Gras.";
    private string i = "Als der Joint zu Ende war, sagte sie, dass sie müde sei. Sie wird immer sofort müde. Ich begleitete sie in den ersten Stock und brachte sie ins Bett.";
    private string j = "Im Wohnzimmer hatte ihr Freund einen zweiten Joint gedreht. Er war wirklich zäh.";
    private string k = "»Manchmal brenne ich Scheunen ab.«";
    private string l = "»Wie bitte?«";
    private string m = "»Manchmal brenne ich Scheunen ab.«";
    //private string n = "";
    //Schnipp
    private string n = "»Es ist ganz einfach. Ich gieße Benzin aus und werfe ein brennendes Streichholz hinein. Das Feuer lodert auf und das war’s. Es dauert keine fünfzehn Minuten, bis alles verbrannt ist.«";
    //Schnipp
    private string o = "»Das heißt also, dass Sie Scheunen von anderen Leuten abbrennen?«";
    private string p = "»Natürlich. Es sind anderer Leute Scheunen. Deswegen ist es ja schließlich eine Straftat. Es ist genauso eindeutig eine Straftat, wie Sie und ich jetzt hier einen Joint rauchen.«";
    private string q = "»Ich stecke also mutwillig Scheunen, die anderen Leuten gehören, in Brand. Natürlich wähle ich dabei die aus, bei denen kein großes Feuer entstehen kann. Ich möchte ja kein Feuer verursachen. Ich möchte einfach bloß Scheunen abbrennen.«";
    //Schnipp
    private string r = "Das stimmt wahrscheinlich, dachte ich. Außerdem würde sicherlich niemand auf die Idee kommen, dass ein gut gekleideter junger Mann in einem ausländischen Wagen herumfuhr und Scheunen abbrannte.";
    private string s = "»Weiß sie davon?«";
    private string t = "»Sie hat keine Ahnung. Um die Wahrheit zu sagen, außer Ihnen habe ich bis jetzt niemandem davon erzählt.«";
    private string u = "»Das klingt vielleicht komisch. Ich habe das Gefühl, als gäbe es in der Welt eine Menge Scheunen, die alle darauf warten, von mir abgebrannt zu werden.«";
    //Schnipp
    private string v = "»Und wann werden Sie die nächste abbrennen?«";
    private string w = "»Das weiß ich nicht.«";
    private string x = "»Steht denn schon fest, welche Scheune Sie als Nächstes abbrennen?«";
    private string y = "»Ja. Das steht fest.«";
    private string z = "»Es ist eine richtig gute Scheune. Seit langem mal wieder eine, die sich abzubrennen lohnt. Tatsächlich bin ich heute hierher gekommen, um sie zu inspizieren. Das heißt, sie ist hier in der Nähe. Ganz in der Nähe«";
    private string a1 = "»Ich werde auf die Scheunen achten«";
    private string a2 = "»Ja. Es ist jedenfalls ganz nah.«";
    private string empty = "";
    //Schnippppppppp

    //private string x = "";
    //private string x = "";
    //private string x = ""; ...

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
        yield return new WaitForSeconds(3.25f); //Hier ist, solange a da ist, danach kommt b
        test.text = b;
        yield return new WaitForSeconds(4.25f);
        test.text = c;
        yield return new WaitForSeconds(3.75f);
        test.text = d;
        yield return new WaitForSeconds(8.75f);
        test.text = e;
        yield return new WaitForSeconds(4.75f);
        test.text = f;
        yield return new WaitForSeconds(4.25f);
        test.text = g;
        yield return new WaitForSeconds(2.55f);
        test.text = h;
        yield return new WaitForSeconds(3.75f);
        test.text = i;
        yield return new WaitForSeconds(8.25f);
        test.text = j;
        yield return new WaitForSeconds(4.75f);
        test.text = empty;
        yield return new WaitForSeconds(1.25f);
        test.text = k;
        yield return new WaitForSeconds(2.25f);
        test.text = empty;
        yield return new WaitForSeconds(0.25f);
        test.text = l;
        yield return new WaitForSeconds(1.25f);
        test.text = empty;
        yield return new WaitForSeconds(1.0f);
        test.text = m;
        yield return new WaitForSeconds(2.25f);
        test.text = empty;
        yield return new WaitForSeconds(1.6f);
        test.text = n;
        yield return new WaitForSeconds(10.0f);
        test.text = empty;
        yield return new WaitForSeconds(0.5f);
        test.text = o;
        yield return new WaitForSeconds(3.45f);
        test.text = empty;
        yield return new WaitForSeconds(0.3f);
        test.text = p;
        yield return new WaitForSeconds(9.0f);
        test.text = q;
        yield return new WaitForSeconds(11.5f);
        test.text = empty;
        yield return new WaitForSeconds(1.3f);
        test.text = r;
        yield return new WaitForSeconds(10.0f);
        test.text = empty;
        yield return new WaitForSeconds(0.5f);
        test.text = s;
        yield return new WaitForSeconds(2.25f);
        test.text = t;
        yield return new WaitForSeconds(6.0f);
        test.text = u;
        yield return new WaitForSeconds(8.5f);
        test.text = empty;
        yield return new WaitForSeconds(0.5f);
        test.text = v;
        yield return new WaitForSeconds(3.0f);
        test.text = w;
        yield return new WaitForSeconds(1.0f);
        test.text = x;
        yield return new WaitForSeconds(3.5f);
        test.text = y;
        yield return new WaitForSeconds(1.5f);
        test.text = z;
        yield return new WaitForSeconds(10.5f);
        test.text = a1;
        yield return new WaitForSeconds(2.0f);
        test.text = a2;

       
    }
}

