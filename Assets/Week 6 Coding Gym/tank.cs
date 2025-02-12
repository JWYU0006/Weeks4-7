using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tank : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject emptyObj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }
        transform.position = pos;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        emptyObj.transform.up = mousePos - (Vector2)emptyObj.transform.position;
    }
}
