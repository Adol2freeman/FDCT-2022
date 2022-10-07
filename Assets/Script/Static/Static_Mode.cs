using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Static_Mode : MonoBehaviour
{
    public List<GameObject> Photos;
    public Transform Clone_Spawpoint;

    //public float timer;
    //public bool Go = true;

    // Start is called before the first frame update
    void Start()
    {
        Clone();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Begin");
        Unbreakable.skip = false;
    }

    public void Clone()
    {
        int Random_num = Random.Range(0, 5);
        Instantiate(Photos[Random_num], Clone_Spawpoint);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Clone();
    }

}
