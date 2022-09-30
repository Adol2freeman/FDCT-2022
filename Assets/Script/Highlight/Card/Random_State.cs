using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Random_State : MonoBehaviour
{
    public GameObject photo1;
    public GameObject photo2;
    
    public void random_state()
    {
        int a = UnityEngine.Random.Range(0, 100);
        if (a % 2 == 0)
        {
            photo1.tag = "True";
            photo2.tag = "False";
        }
        else
        {
            photo1.tag = "False";
            photo2.tag = "True";
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        random_state();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}