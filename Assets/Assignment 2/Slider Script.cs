using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;                       //get slider component
    public UIImageMovement uiImageMovement;     //script class, get distance
    bool isDragging;                            //store dragging statues
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDragging)        //if is not dragging, avoid set each other's value at same time
        {
            slider.value = -uiImageMovement.distance;       //slider value equals how far image has moved
        }
    }

    //if drag slider, image move with slider bar
    public void SliderValueChanged()
    {
        uiImageMovement.distance = -slider.value;
    }

    //if end dragging, resume updating slider value
    public void EndDragging()
    {
        isDragging = false;
    }
}
