using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Highlight : MonoBehaviour
{
    public UnityEvent Ready;
    public UnityEvent Main;
    public UnityEvent Pressed;
    public GameObject num;
    private int End = 0;
    private int Now;

    [Header("xyz")]
    public GameObject Background;

    public void Pressing()
    {
        Pressed?.Invoke();
    }
    
    public void Stop_Button(Button a)
    {
        a.GetComponent<Button>().enabled = false;
    }

    public void Start_Button(Button a)
    {
        a.GetComponent<Button>().enabled = true;
    }
    
    public void Disable(GameObject a)
    {
        a.SetActive(false);
    }

    public void Enable(GameObject a)
    {
        a.SetActive(true);
    }

    public void Disable_Ready()
    {
        Disable(Background);
        Disable(num);
        Main?.Invoke();
    }
    
    public void ConuntDown()
    {
        Now--;
        if (End == Now)
        {
            Now = 0;
            End = 0;
            num.GetComponent<Text>().text = "Start";
            Invoke("Disable_Ready", 1);
            CancelInvoke("ConuntDown");
        }
        else
        {
            num.GetComponent<Text>().text = "" + Now;
        }
    }

    public void StartCountDown(int a)
    {
        Now = a;
        InvokeRepeating("ConuntDown", 1, 1);
    }

    private void Awake()
    {
        Ready?.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
