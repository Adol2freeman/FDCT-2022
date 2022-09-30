using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Respone : MonoBehaviour
{
    public GameObject respone;
    public Text text;

    [Header("Scound")]
    public AudioSource T;
    public AudioSource F;
    public AudioClip True;
    public AudioClip False;

    public void Delay()
    {
        respone.SetActive(false);
        text.GetComponent<Text>().text = "";
        //Invoke("Score", 2);
    }

    public void vocal()
    {
        T.GetComponent<AudioSource>().mute = false;
        F.GetComponent<AudioSource>().mute = false;
    }

    public void Mute()
    {
        T.GetComponent<AudioSource>().mute = true;
        F.GetComponent<AudioSource>().mute = true;
    }

    public void Ended()
    {
        SceneManager.LoadScene("Ending");
        //Debug.Log(Unbreakable.presseed_True + "/" + Unbreakable.pressed_time);
        //End_text.SetActive(true);
        //End_text.GetComponent<Text>().text = "Score: " + Unbreakable.presseed_True + "/" + Unbreakable.pressed_time;
    }

    public void Decision(GameObject a)
    {
        respone.SetActive(true);
        if (a.tag == "True")
        {
            Unbreakable.presseed_True++;
            Unbreakable.pressed_time++;
            respone.GetComponent<Image>().color = new Color32(0,225,0, 80);
            T.PlayOneShot(True);
            text.GetComponent<Text>().text = "答對了！這是真實病患的肺部CT圖，藍色部分是較少病毒堆積處，紅色部分是較多病毒堆積處。";
        }
        else
        {
            Unbreakable.pressed_time++;
            respone.GetComponent<Image>().color = new Color32(225,0,0,80);
            F.PlayOneShot(False);
            text.GetComponent<Text>().text = "答錯了！這是真實病患的肺部CT圖，藍色部分是較少病毒堆積處，紅色部分是較多病毒堆積處。";
        }

        Invoke("Delay", 4);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Unbreakable.pressed_time == 5)
        {
            Invoke("Ended", 3);
        }
    }
}
