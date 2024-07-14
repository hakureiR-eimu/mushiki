using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
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
        if(instance!=null)
        {
            return;
        }
        instance = this;
        Initialize();
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
        rounds++;
        for(int i = 0; i < campList.Count; i++)
        {
            campList[i].haveActed = false;
        }
    }
    public CampParameter curCamp;
    public List<CampParameter> campList;
    public void ChangeCurCamp(int id)
    {
        curCamp = campList[id];
        for (int i = 0; i < campList.Count; i++)
        {
            if(i==id)
            {
                Color tempColor=campList[i].GetComponent<Image>().color;
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
}
