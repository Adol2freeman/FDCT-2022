using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Static_Mode : MonoBehaviour
{
    public List<GameObject> Photos;
    public Transform Clone_Spawpoint;

    public float timer;
    public bool Go = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Go)
        {
            Clone();
            timer = 0;
            Go = false;
        }

        timer += Time.deltaTime;
        if(timer >= 10)
        {
            Go = true;
        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Begin");
    }

    public void Clone()
    {
        int Random_num = Random.Range(0, 5);
        Instantiate(Photos[Random_num], Clone_Spawpoint);
    }

}
