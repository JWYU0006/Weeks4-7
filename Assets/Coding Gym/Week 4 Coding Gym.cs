using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4CodingGym : MonoBehaviour
{
    public AudioSource audioSource;
    public SpriteRenderer sr;
    float t;
    int c = 0;
    float audioLength;
    float duration;
    float tBird;
    // Start is called before the first frame update
    void Start()
    {
        audioLength = audioSource.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 3)
        {
            t = 0;
            c++;
            Debug.Log(c);
            audioSource.Play();
            duration = 3f / c;
            Debug.Log(duration);
        }
        tBird += Time.deltaTime;
        if (tBird >= duration && c >= 0)
        {
            if (sr.enabled == false)
            {
                sr.enabled = true;
                tBird = 0;
                c--;
                Debug.Log("show");
            }
            else
            {
                sr.enabled = false;
                tBird = 0;
                c--;
                Debug.Log("hide");
            }
            //Debug.Log("c");
        }
    }
}
