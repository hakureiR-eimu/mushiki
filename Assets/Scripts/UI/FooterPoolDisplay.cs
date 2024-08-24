using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FooterPoolDisplay : MonoBehaviour
{
    public GameObject footerItemPrefeb;
    public GameObject footerPool;
    public int playerID;

    InnerDataStore innerDataStore;

    List<GameObject> footItems = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        innerDataStore = GetComponent<InnerDataStore>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickUpper()
    {
        playerID = GameManager.Instance.playerID;
        ClearFootItems();
        if (GameManager.Instance.playerPhase == 0)
        {
            RenderInnerEconomy();
        }
        else if (GameManager.Instance.playerPhase == 1)
        {
            RenderInnerSociety();
        }

    }
    public void OnClickFooterControl(Button _button)
    {
        playerID = GameManager.Instance.playerID;
        ClearFootItems();
        int index = -1;
        /*GetObjectName();*/
        if (_button.gameObject.name == "FooterControlIcon1")
        {
            GameManager.Instance.playerPhase = 0;
            index = 1;
            RenderInnerEconomy();

        }
        else if (_button.gameObject.name == "FooterControlIcon2")
        {
            GameManager.Instance.playerPhase = 1;
            index = 2;
            RenderInnerSociety();
        }
        Debug.Log(index);

    }

    private void RenderInnerEconomy()
    {
        for (int i = 0; i < 5; ++i)
        {
            GameObject newFooterItem = GameObject.Instantiate(footerItemPrefeb, footerPool.transform);
            newFooterItem.GetComponent<FooterItemDisplasy>().footItem = innerDataStore.GetPlayerData(playerID)[i];

            footItems.Add(newFooterItem);
        }
    }
    private void RenderInnerSociety()
    {
        for (int i = 5; i < 10; ++i)
        {
            GameObject newFooterItem = GameObject.Instantiate(footerItemPrefeb, footerPool.transform);
            newFooterItem.GetComponent<FooterItemDisplasy>().footItem = innerDataStore.GetPlayerData(playerID)[i];

            footItems.Add(newFooterItem);
        }
    }
    public void ClearFootItems()
    {
        foreach (var item in footItems)
        {
            Destroy(item);
        }
        footItems.Clear();
    }

    private void GetObjectName()
    {
        string objectName = gameObject.name;
        Debug.Log(objectName);
    }
}
