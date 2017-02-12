using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class square : MonoBehaviour {

    private float timeStamp = 0f;

    public Material material;
    private GameObject objective;

    void Start()
    {
        timeStamp = Time.time + 0.5f;
        objective = FindObjectOfType<Spawner>().objective;
    }

    void OnMouseDown()
    {
        if (gameObject == objective && Time.time >= timeStamp)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Score.count++;
        }
        else if(Time.time >= timeStamp)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Score.count = 0;
        }
    }
}
