using UnityEngine;
using UnityEngine.UI;

public class FooterItemDisplasy : MonoBehaviour
{
    public Text FooterItemNameText;
    public Text FooterItemValText;

    public FootItem FootItem;
    // Start is called before the first frame update
    void Start()
    {
        ShowItem();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ShowItem()
    {
        FooterItemNameText.text = FootItem.itemName;
        FooterItemValText.text = FootItem.itemVal.ToString();
    }
}
