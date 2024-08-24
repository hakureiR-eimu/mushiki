using UnityEngine;
using UnityEngine.UI;

public class NewspaperDisplay : MonoBehaviour
{
    public Text news;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void updateNews(string newsString)
    {
        news.text = newsString;
    }
    public NewspaperDisplay()
    {
        news.text = "";
    }
}
