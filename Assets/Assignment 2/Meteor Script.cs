using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    public RectTransform rectTransform;     //store meteor's RectTransorm, use to set anchoredPosition
    public int speed;                       //meteor's speed
    float position;                         //current Y position
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        position += Time.deltaTime * speed;     //move over deltaTime
        Vector2 vector2 = rectTransform.anchoredPosition;
        vector2.x -= position;          //move down left
        vector2.y -= position / 3;
        rectTransform.anchoredPosition = vector2;       //update position
        if (vector2.y < -300)
        {
            Destroy(gameObject);    //when it's out of screen, destory
        }
    }
}
