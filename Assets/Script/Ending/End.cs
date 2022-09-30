using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class End : MonoBehaviour
{
    public UnityEvent Show_Score;
    public Text Score;

    [Header("Canvas")]
    public GameObject ScorePage;
    public GameObject ButtonPage;
    public GameObject KnowMore;

    [Header("Button")]
    public GameObject Back;

    public void ToSecondPage()
    {
        Restart();
        ScorePage.SetActive(false);
        ButtonPage.SetActive(true);
        KnowMore.SetActive(false);
        Back.SetActive(false);
    }

    public void ToThirdPage()
    {
        ButtonPage.SetActive(false);
        KnowMore.SetActive(true);
        Back.SetActive(true);

    }
    
    public void Restart()
    {
        Unbreakable.pressed_time = 0;
        Unbreakable.presseed_True = 0;
    }

    //YOooOoooO
    public void show_score()
    {
        Score.GetComponent<Text>().text = "分數： " + Unbreakable.presseed_True + "/" + Unbreakable.pressed_time;
        Invoke("ToSecondPage", 3); 
    }

    // Start is called before the first frame update
    void Start()
    {
        //Score.GetComponent<Text>().text = "分數： " + Unbreakable.presseed_True + "/" + Unbreakable.pressed_time;
        ButtonPage.SetActive(false);
        KnowMore.SetActive(false);
        Show_Score?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
