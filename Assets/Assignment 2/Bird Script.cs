using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public RectTransform rectTransform;     //store bird's RectTransorm, use to set anchoredPosition
    public int speed;                       //bird's speed
    float position;                         //current X position
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        position += Time.deltaTime * speed;     //move over deltaTime
        rectTransform.anchoredPosition = new Vector2(position, rectTransform.anchoredPosition.y);       //only update x axis
        if (position > 2000)
        {
            Destroy(gameObject);    //when it's out of screen, destory
        }
    }
}
