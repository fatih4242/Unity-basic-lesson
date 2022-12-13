using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ders1 : MonoBehaviour
{



    int updateNumber = 0;
    //Scriptimiz Eğer Sahnede ekli ise sahne başlatıldığında ilk çalışacak Metod'dur


    void Start()
    {
        /*int, String, boolean, double, long

        int a = 2;
        string b = "fatih";
        double c = 2.333;
        long d = 2.434;
        */

        //eşitlemeden sonra değeri değişkenin türünden ayrı olsa bile cast edilen değişkene eşitle
        float firstNumber = (float) 2.2;
        float secondNumber = (float) 2.3;
        //Debug.Log(firstNumber + secondNumber);


        string name = "fatih";
        string surname = "toker";
        int age = 12;

        int secondAge = 0;
        // i < { buraya yazılan değeri } sıra işlemine yerleştirip bize i şeklinde bunu döndürüyor
        for (int i = 1; i <= age; i++)
        {
            secondAge = i;
            //Debug.Log(secondAge);
        }
        //PrintHelloWorld();
        //thisIsAPublicMethod();
        //WhatIsTheAge(age);

        double[] smallAges = { 1, 2, 4, 5, 7, 1, 2, 3, 5, 6, 4 };
        double[] bigAges = { 121, 27, 46, 53, 47 };


        Debug.Log( "foo1: " + AverageAge(smallAges) );

    }

    //Scriptimiz Eğer Sahnede ekli ise sahne başlatıldığında sahnede düzenli olarak çalışır(belirli aralıklarla)
    private void Update()
    {
        
    }

    public void PrintHelloWorld()
    {
    }

    //Erişim Seviyesi, dönecek tip, isim, Opsiyonel( Fonksiyonda bulundan parantezlere yazılımcıya bağlı parametreler )
    public void thisIsAPublicMethod()
    {
        Debug.Log("Hey this is a print from a public method");
    }


    public void WhatIsTheAge(int userAge)
    {
        Debug.Log("Kullanıcının Yaşı : " + userAge);
        if (userAge > 18)
        {
            Debug.Log("Kaydınız Başarıyla Oluşturuldu");
        }
        else if (userAge >= 15 && userAge < 18)
        {
            Debug.Log("birkaç yılınız kalmıştır");
        }
        else
        {
            Debug.Log("Yaşınızın 18'den büyük olması gerekir");
        }
    }

    public double AverageAge(double[] ages)
    {
        double average = 0;
        for (int i = 0; i < ages.Length; i++)
        {
            average += ages[i];
        }

        return average / ages.Length;
    }


}
