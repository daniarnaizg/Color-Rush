using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rotate : MonoBehaviour {

    //public Material material;

    public float speed = 1f;
    public Vector3 rotAmount = new Vector3(0, 90, 0);
    public int sceneIndex;

    private void Start()
    {
        GetComponent<Renderer>().material.color = Color.HSVToRGB((Random.Range(0.0f, 1.0f)), 0.7f, 1f, true);
    }

    IEnumerator OnMouseDown() // A couroutine can be run each frame so we can do animation.
    {
       if (transform.rotation.eulerAngles[0] % 90 == 0)
        {
            float endTime = Time.time + 0.8f; // When to end the coroutine
            float step = 20f / speed; // How much to step by per sec
            Vector3 fromAngle = transform.eulerAngles; // start rotation
            Vector3 targetRot = transform.eulerAngles + rotAmount; // where we want to be at the end
            float t = 0; // how far we are. 0-1
            while (Time.time <= endTime)
            {
                t += step * Time.deltaTime;
                transform.eulerAngles = Vector3.Lerp(fromAngle, targetRot, t);
                yield return 0;
            }
            SceneManager.LoadScene(sceneIndex);
        }
    }

}
