using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ders1_2 : MonoBehaviour
{

    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        double[] ages = { 1, 2, 3, 45, 6 };
        ders1 firstLesson = new ders1();
        Debug.Log( "foo2: " + firstLesson.AverageAge(ages) );

        cube.GetComponent<Transform>().position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
