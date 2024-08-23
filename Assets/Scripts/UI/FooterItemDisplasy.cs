using UnityEngine;
using UnityEngine.UI;

public class FooterItemDisplasy : MonoBehaviour
{
    public Text footerItemNameText;
    public Text footerItemValText;

    public FootItem footItem;
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

        footerItemNameText.text = footItem.itemName;
        if (footItem.itemVal.HasValue)
        {
            footerItemValText.text = footItem.itemVal.ToString();
        }
    }
}
