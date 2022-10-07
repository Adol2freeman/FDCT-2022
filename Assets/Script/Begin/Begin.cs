using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    //public bool skip = false;
    //public GameObject a;
    public bool Hi = true;
    public GameObject Content;
    public GameObject rule;
    public GameObject difficulty;
    public GameObject Icon;
    public bool Static_mode = false;
    public float waitting_time;

    float StaticTime;

    [Header("Rule")]
    public GameObject PassRule;

    public void Set(string a)
    {
        Unbreakable.diff = a;
    }

    public void YesSkip()
    {
        Unbreakable.skip = true;
    }

    public void ChooseDifficulty()
    {
        rule.SetActive(false);
        difficulty.SetActive(true);
    }

    public void PassNextScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }

    // Start is called before the first frame update
    void Start()
    {
        //a = GameObject.Find("DontDestory");
        rule.SetActive(false);
        difficulty.SetActive(false);
    }

    void Restart_StaticTimer()
    {
        StaticTime = 0;
        Static_mode = true;
    }

    void Show()
    {
        PassRule.GetComponent<Button>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Static_mode)
        {
            StaticTime += Time.deltaTime;
            //Debug.Log(StaticTime);
        }

        if (Hi)
        {
            if (StaticTime >= waitting_time)
            {
                Restart_StaticTimer();
                SceneManager.LoadScene("StaticMode");
            }

            if (Input.anyKey)
            {
                Restart_StaticTimer();
                if (Unbreakable.skip)
                {
                    Icon.SetActive(false);
                    Content.SetActive(false);
                    difficulty.SetActive(true);
                }
                else
                {
                    Icon.SetActive(false);
                    Content.SetActive(false);
                    rule.SetActive(true);

                    
                    
                }
                Hi = false;
                //SceneManager.LoadScene("Highlight");
            }
        }

        
    }
}
