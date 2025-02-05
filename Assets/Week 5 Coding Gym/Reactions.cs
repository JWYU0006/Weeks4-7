using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Week5CodingGym : MonoBehaviour
{
    float speed;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += speed * Time.deltaTime;
        }
        transform.position = position;

        if (Vector2.Distance(new Vector2(6, 0.5f), position) >= 2)
        {
            slider.value = 0;
        }
        else
        {
            slider.value += Time.deltaTime;
        }
    }
}
