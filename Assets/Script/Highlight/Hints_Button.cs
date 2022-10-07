using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Hints_Button : MonoBehaviour
{
    public bool Opened;
    public Button button;

    public UnityEvent Show;
    public UnityEvent Close;

    public Text text;

    Highlight highlight;

    public void ShowTheHints()
    {
        Show?.Invoke();
        text.text = "返回";
        Opened = true;
        //Debug.Log("B");
        button.enabled = true;
    }

    public void CloseTheHints()
    {
        Close?.Invoke();
        text.text = "我要提示！！！";
        Opened = false;
        //Debug.Log("A");
        button.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Switch()
    {
        if (Opened == true)
        {
            Invoke("CloseTheHints", 0.1f);
            button.enabled = false;
        }
        else
        {
            Invoke("ShowTheHints", 0.1f);
            button.enabled = false;
        }
    }
}
