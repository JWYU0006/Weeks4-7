using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTranceparency : MonoBehaviour
{
    public UIImageMovement uiImageMovement;         //script class: UI Image Movement
    int period = 6;                                 //how many periods in a day
    int currentPeriod;                              //which period now
    int width;                                      //store width in UI Image Movement script
    float currentAnchorPosition;                    //store current horizontal anchor position
    static List<Image> images = new List<Image>();  //declare an static images list, it's common and can be access from all objects
    Image image;                                    //temporarily store Image component
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        if (image != null) { images.Add(image); }   //add all images into image list
        //if (image.sprite.name != "Dawn") { image.enabled = false; }     //disable all image but first one "Dawn"
    }

    // Update is called once per frame
    void Update()
    {
        width = uiImageMovement.imageWidth;         //get width of sky image
        //Debug.Log(width);
        //for (int i = 0; i < images.Count; i++)
        //{
        //    Debug.Log(i + "," + images[i].sprite.name);
        //}
        currentAnchorPosition = -uiImageMovement.m_RectTransform.anchoredPosition.x;      //get parent image's anchor position, add - to make it positive
        currentPeriod = (int)currentAnchorPosition / (width / 6);       //width/6 is how long(pixels) a period is, divide currentAnchorPosition is current period
        Debug.Log(currentAnchorPosition + "," + currentPeriod);
        switch (currentPeriod)
        {
            case 0:
                SwitchImages("Dawn");
                break;
            case 1:
                SwitchImages("Morning");
                break;
            case 2:
                SwitchImages("Noon");
                break;
            case 3:
                SwitchImages("Sunset");
                break;
            case 4:
                SwitchImages("Dusk");
                break;
            case 5:
                SwitchImages("Evening");
                break;
            default:
                break;
        }
    }

    //enable image component which has image name matches the argument, unabled others
    void SwitchImages(string imageName)
    {
        for (int i = 0; i < images.Count; i++)
        {
            //if (images[i].sprite.name == imageName) { images[i].enabled = true; } else { images[i].enabled = false; }
            if (images[i].sprite.name == imageName)
            {
                images[i].color = new Color(255, 255, 255, 255);
            }
            else
            {
                images[i].color = new Color(255, 255, 255, 0);
            }
        }
    }
}
