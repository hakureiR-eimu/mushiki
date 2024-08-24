using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FooterPoolDisplay : MonoBehaviour
{
    public GameObject footerItemPrefeb;
    public GameObject footerPool;
    public int playerID;



    List<GameObject> footItems = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

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

        /*GetObjectName();*/
        if (_button.gameObject.name == "FooterControlIcon1")
        {
            GameManager.Instance.playerPhase = 0;

            RenderInnerEconomy();

        }
        else if (_button.gameObject.name == "FooterControlIcon2")
        {
            GameManager.Instance.playerPhase = 1;

            RenderInnerSociety();
        }


    }

    private void RenderInnerEconomy()
    {
        for (int i = 0; i < 5; ++i)
        {
            GameObject newFooterItem = GameObject.Instantiate(footerItemPrefeb, footerPool.transform);
            newFooterItem.GetComponent<FooterItemDisplasy>().footItem = GameManager.Instance.data.GetPlayerData(playerID)[i];

            Button buttonComponent = newFooterItem.GetComponent<Button>();
            int index = i;
            buttonComponent.onClick.AddListener(() => OnButtonClick(index));

            footItems.Add(newFooterItem);
        }
    }
    private void RenderInnerSociety()
    {
        for (int i = 5; i < 10; ++i)
        {
            GameObject newFooterItem = GameObject.Instantiate(footerItemPrefeb, footerPool.transform);
            newFooterItem.GetComponent<FooterItemDisplasy>().footItem = GameManager.Instance.data.GetPlayerData(playerID)[i];

            Button buttonComponent = newFooterItem.GetComponent<Button>();
            int index = i - 5;
            buttonComponent.onClick.AddListener(() => OnButtonClick(index));

            footItems.Add(newFooterItem);
        }
    }
    private void ClearFootItems()
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
    void OnButtonClick(int index)
    {
        if (GameManager.Instance.curCamp.haveActed == true)
        {
            Debug.Log("本回合已经操作过啦！");
            return;

        }

        //Debug.Log("点击了按钮" + index);
        Text buttonText = footItems[index].GetComponentInChildren<Text>();
        //if (buttonText != null)
        //{
        //    Debug.Log("按钮的文本内容是:" + buttonText.text);
        //}

        string playerLog = "";
        if (GameManager.Instance.playerID == 3)
        {
            playerLog += "台湾";
        }
        else
        {
            playerLog += GameManager.Instance.curCamp.campName;
        }

        playerLog += ",";
        playerLog += buttonText.text;

        Debug.Log(playerLog);

        GameManager.Instance.influenceLog.Add(playerLog);

        GameManager.Instance.curCamp.haveActed = true;
    }
}
