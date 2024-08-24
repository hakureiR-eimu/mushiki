using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
enum playerState
{
    IsInfluenced,
    IsEndTurn
}
public class GameManager : MonoBehaviour
{
    //
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
        Initialize();
        Init();
    }
    private void Initialize()
    {
        ChangeCurCamp(0);
        rounds = 1;
        for (int i = 0; i < campList.Count; i++)
        {
            campList[i].haveActed = false;
        }
    }
    public int rounds;
    public void NextRound()
    {
        int isEveryoneNotEnd = 0;
        for (int i = 0; i < campList.Count; ++i)
        {
            if (curCamp.haveActed == false)
            {
                isEveryoneNotEnd = 1;
            }
        }
        if (isEveryoneNotEnd == 1)
        {
            Debug.Log("请等待所有人完成操作再结束回合");
            return;
        }
        rounds++;
        for (int i = 0; i < campList.Count; i++)
        {
            campList[i].haveActed = false;
            campList[i].haveUpgrade = false;
        }
    }
    public CampParameter curCamp;
    public List<CampParameter> campList;
    public void ChangeCurCamp(int id)
    {

        curCamp = campList[id];

        ChangePlayer(id); //修改当前国家

        for (int i = 0; i < campList.Count; i++)
        {
            if (i == id)
            {
                Color tempColor = campList[i].GetComponent<Image>().color;
                tempColor = new Color(tempColor.r, tempColor.g, tempColor.b, 1f);
                campList[i].GetComponent<Image>().color = tempColor;
            }
            else
            {
                Color tempColor = campList[i].GetComponent<Image>().color;
                tempColor = new Color(tempColor.r, tempColor.g, tempColor.b, 0.2f);
                campList[i].GetComponent<Image>().color = tempColor;
            }
        }


    }
    public int playerID;
    public int playerPhase;// 0:经济 1:舆情
    public LoadDataDemo data;
    public List<string> influenceLog;

    public void Init()
    {
        data = new LoadDataDemo();
        influenceLog = new List<string>();
        //data.Test();
        Newspaper.SetActive(false);
    }
    public void ChangePlayer(int _playID)
    {
        playerID = _playID;
    }

    public GameObject Newspaper;
}
