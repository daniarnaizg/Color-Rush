using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject squarePrefab;

    public GameObject objective;

    public ArrayList[] colorList;

    public Color mainColor;

    void Start()
    {
        int randomIndex = Random.Range(1, spawnPoints.Length);
        Debug.Log(randomIndex);
        mainColor = Color.HSVToRGB( (Random.Range(0.0f, 1.0f)), 0.7f, 1f);
        GameObject main = Instantiate(squarePrefab, spawnPoints[0].position, Quaternion.identity) as GameObject;
            main.name = "Cube";
            main.GetComponent<Renderer>().material.color = mainColor;

        for (int i = 1; i < spawnPoints.Length; i++)
        {
            if (i == randomIndex)
            {
                objective = Instantiate(squarePrefab, spawnPoints[i].position, Quaternion.identity) as GameObject;
                objective.name = "Objective";
                objective.GetComponent<Renderer>().material.color = mainColor;
            }
            else
            {
                GameObject go = Instantiate(squarePrefab, spawnPoints[i].position, Quaternion.identity) as GameObject;
                go.name = "Go";
                go.GetComponent<Renderer>().material.color = Color.HSVToRGB((Random.Range(0.0f, 1.0f)), 0.7f, 1f, true);
            }
        }
    }
}
