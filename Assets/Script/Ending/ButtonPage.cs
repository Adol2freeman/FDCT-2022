using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPage : MonoBehaviour
{
    public void GotoHomePage()
    {
        SceneManager.LoadScene("Begin");
    }

    public void Restart()
    {
        if (Unbreakable.diff == "Simple")
        {
            SceneManager.LoadScene("Simple_level");
        }
        else
        {
            SceneManager.LoadScene("Hard_level");
        }
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
