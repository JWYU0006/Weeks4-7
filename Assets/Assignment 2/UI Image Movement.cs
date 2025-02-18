using UnityEngine;

public class UIImageMovement : MonoBehaviour
{
    public RectTransform m_RectTransform;      //UI Image game object
    public float speed;                 //Sky speed, also time speed
    float distance;                     //how far sky has moved
    public int imageWidth;              //pixels of image width
    // Start is called before the first frame update
    void Start()
    {
        m_RectTransform = GetComponent<RectTransform>();        //fetch RectTransform from UI Image game object
    }

    // Update is called once per frame
    void Update()
    {
        distance -= Time.deltaTime * speed;         //sky move left over time.
        m_RectTransform.anchoredPosition = new Vector2(distance, 0);        //set horizontal anchor position
    }
}
