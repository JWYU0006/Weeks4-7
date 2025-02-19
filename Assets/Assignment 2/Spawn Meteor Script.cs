using UnityEngine;

public class SpawnMeteorScript : MonoBehaviour
{
    public GameObject meteorPrefab;
    public Transform parentUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnMeteor()
    {
        GameObject newMeteor = Instantiate(meteorPrefab, parentUI);             //clone a new meteor and set parent object
        RectTransform meteorRect = newMeteor.GetComponent<RectTransform>();     //get new meteor's rectTransorm
        meteorRect.anchoredPosition = new Vector2(Random.Range(300, 2600), 120);   //spawn randomly on x axis}
    }
}
