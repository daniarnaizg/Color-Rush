using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Color color;

    public static int count;
    public Text text;

    private void Start()
    {
        color = FindObjectOfType<Spawner>().mainColor;
    }

    void Update()
    {
        text.text = count.ToString();
        text.color = color;
    }
}
