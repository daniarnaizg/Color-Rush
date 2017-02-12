using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        text.color = Color.HSVToRGB((Random.Range(0.0f, 1.0f)), 0.7f, 1f, true);
    }

}
