using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduktion : MonoBehaviour
{
    // public = syns i unity 
    // kommentar = syns inte i unity
    // int = Heltal
    // float = decimal tal (uptill 7)
    // double = decimal tal (uptill 15)
    // Bool = Ja/Nej
    // Char = Karaktär
    // String = Text (Hur lång som helst)
    // Debug.log = Print
    public int testInt = 5;
    public float testFloat = 1.0f;
    public double testdouble = 2.0;
    public bool testBool = true;
    public char testChar = 'A';
    public string testString = "Nämen va fan";
    public string sentence1 = "Hello there";
    public string sentence2 = "Another happy landing";
    public string sentence3 = "So uncivilized";
    public int number = 25;
    public int triangleBase = 6;
    // Use this for initialization
    void Start()
    {
        TestFunktion();
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
    }
    void TestFunktion()
    {
        Debug.Log("Test funktion()");
    }
    void Uppgift1()
    {
        Debug.Log(
            string.Format(
                "Svaret på  (963d * 421d) - (175463d / 87d) är {0}",
                    (963d * 421d) - (175463d / 87d)));
    }
    void Uppgift2()
    {
        print(sentence1);
        print(sentence2);
        print(sentence3);


    }
    void Uppgift3()
    {
        Debug.Log(
          string.Format(
              "Talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}",
                number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));



    }
    void Uppgift4()
    {
        Debug.Log(
            string.Format(
                "Svaret på 8 * 6 / 2 är {0}m^2", (8 * 6 / 2)));

    }
    void Uppgift5()
    {
        Debug.Log(
            string.Format(
                "Svaret på 360 / 22.5 är {0}", (360 / 22.5)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
