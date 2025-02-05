using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColor()
    {
        sr.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
    }
}
