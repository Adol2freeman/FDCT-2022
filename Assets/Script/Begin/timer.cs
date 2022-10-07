using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject Button;
    public Image image;

    [Header("Timer")]
    public float curr_time;
    public int end_time;

    public Color Not_Respone;
    public Color have_Respone;
    public bool stop;

    // Start is called before the first frame update
    void Start()
    {
        stop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
        {
            curr_time += Time.deltaTime;
            
        }

        if (curr_time >= end_time)
        {
            stop = false;
            image.color = have_Respone;
        }
    }
}
