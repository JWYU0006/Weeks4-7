using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTranceparency : MonoBehaviour
{
    public UIImageMovement uiImageMovement;         //script class: UIImageMovement
    int periods = 6;                                 //how many periods in a day
    int currentPeriod;                              //which period now
    int width;                                      //store width in UI Image Movement script
    float currentAnchorPosition;                    //store current horizontal anchor position
    static List<Image> images = new List<Image> { null, null, null, null, null, null };  //declare an static images list, it's common and can be access from all objects
    Image image;                                    //temporarily store Image component
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = new Color(1, 1, 1, 0);
        switch (image.sprite.name)
        {
            case "Dawn":
                images[0] = image;
                break;
            case "Morning":
                images[1] = image;
                break;
            case "Noon":
                images[2] = image;
                break;
            case "Sunset":
                images[3] = image;
                break;
            case "Dusk":
                images[4] = image;
                break;
            case "Evening":
                images[5] = image;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        width = uiImageMovement.imageWidth;         //get width of sky image
        //Debug.Log(image.name + ": " + image.sprite.name);
        //for (int i = 0; i < images.Count; i++)
        //{
        //    Debug.Log(i + "," + images[i].sprite.name);
        //}
        currentAnchorPosition = -uiImageMovement.m_RectTransform.anchoredPosition.x;      //get parent image's anchor position, add - to make it positive
        currentPeriod = (int)currentAnchorPosition / (width / periods);       //width/6 is how long(pixels) a period is, divide currentAnchorPosition is current period
        //Debug.Log(currentAnchorPosition + "," + currentPeriod);
        switch (currentPeriod)      //call SwitchImages function base on current period
        {
            case 0:
                SwitchImages("Dawn", currentAnchorPosition / (width / periods));
                break;
            case 1:
                SwitchImages("Morning", currentAnchorPosition / (width / periods));
                break;
            case 2:
                SwitchImages("Noon", currentAnchorPosition / (width / periods));
                break;
            case 3:
                SwitchImages("Sunset", currentAnchorPosition / (width / periods));
                break;
            case 4:
                SwitchImages("Dusk", currentAnchorPosition / (width / periods));
                break;
            case 5:
                SwitchImages("Evening", currentAnchorPosition / (width / periods));
                break;
            default:
                Debug.Log("No image");
                break;
        }
    }

    //enable image component which has image name matches the argument, unabled others
    void SwitchImages(string imageName, float periodFloat)
    {
        for (int i = 0; i < images.Count; i++)
        {
            if (images[i].sprite.name == imageName)
            {
                images[i].color = new Color(1, 1, 1, 1 - (periodFloat - (int)periodFloat));
                if (i == periods - 1)
                {
                    images[0].color = new Color(1, 1, 1, periodFloat - (int)periodFloat);
                }
                else
                {
                    images[i + 1].color = new Color(1, 1, 1, periodFloat - (int)periodFloat);
                }
            }
        }
    }
}
