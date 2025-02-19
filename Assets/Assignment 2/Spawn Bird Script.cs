using UnityEngine;

public class SpawnBirdScript : MonoBehaviour
{
    public GameObject birdPrefab;
    public Transform parentUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBird()
    {
        GameObject newBird = Instantiate(birdPrefab, parentUI);             //clone a new bird and set parent object
        RectTransform birdRect = newBird.GetComponent<RectTransform>();     //get new bird's rectTransorm
        birdRect.anchoredPosition = new Vector2(0, Random.Range(-100, -300));                   //spawn randomly on y axis
    }
}
