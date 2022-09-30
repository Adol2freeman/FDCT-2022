using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    [Header("Event")]
    public UnityEvent change;

    public GameObject Photo1;
    public GameObject Photo2;
    public GameObject Answer;

    [Header("False")] 
    public Texture2D[] F_Images;
    public int F_len = 5;
    public Texture2D F0;
    public Texture2D F1;
    public Texture2D F2;
    public Texture2D F3;
    public Texture2D F4;
    private int num_True = 0;

    [Header("True")] 
    public Texture2D[] T_Images;
    public int T_len = 5;
    public Texture2D T0;
    public Texture2D T1;
    public Texture2D T2;
    public Texture2D T3;
    public Texture2D T4;
    private int num_False = 0;

    [Header("Answer")]
    public Texture2D[] Ans_Images;
    public int Ans_len = 5;
    public Texture2D Ans0;
    public Texture2D Ans1;
    public Texture2D Ans2;
    public Texture2D Ans3;
    public Texture2D Ans4;

    public void Delay()
    {
        Answer.SetActive(false);
        change?.Invoke();
        ChangeIn();
    }
    
    public void ChangeIn()
    {
        Invoke("Change", (float) 0.01);
    }
    
    public void Change()
    {
        num_True = UnityEngine.Random.Range(0, T_len - 1);
        num_False  = UnityEngine.Random.Range(0, F_len - 1);

        if (Photo1.tag == "True")
        {
            Photo1.GetComponent<RawImage>().texture = T_Images[num_True];
            Photo2.GetComponent<RawImage>().texture = F_Images[num_False];
        }
        else
        {
            Photo1.GetComponent<RawImage>().texture = F_Images[num_False];
            Photo2.GetComponent<RawImage>().texture = T_Images[num_True];
        }
    }

    public void ShowAns()
    {
        Answer.SetActive(true);
        Answer.GetComponent<RawImage>().texture = Ans_Images[num_True];
        Invoke("Delay", 4);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        F_Images = new Texture2D[F_len];
        F_Images[0] = F0;
        F_Images[1] = F1;
        F_Images[2] = F2;
        F_Images[3] = F3;
        F_Images[4] = F4;
        
        T_Images = new Texture2D[T_len];
        T_Images[0] = T0;
        T_Images[1] = T1;
        T_Images[2] = T2;
        T_Images[3] = T3;
        T_Images[4] = T4;

        Ans_Images = new Texture2D[Ans_len];
        Ans_Images[0] = Ans0;
        Ans_Images[1] = Ans1;
        Ans_Images[2] = Ans2;
        Ans_Images[3] = Ans3;
        Ans_Images[4] = Ans4;
        
        //start
        Invoke("Change",  (float) 0.02);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}