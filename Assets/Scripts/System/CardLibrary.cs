using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLibrary : MonoBehaviour
{
    private static CardLibrary instance;
    public static CardLibrary Instance
    {  get { return instance; } }
    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        instance = this;
        Strategy[] economy = Resources.LoadAll<Strategy>("Strategy/Econmy");
        for(int i = 0; i < economy.Length; i++)
        {
            economyStrategy.Add(economy[i].id, economy[i]);
        }
    }
    private Dictionary<string, Strategy> economyStrategy;
    public Strategy GetEconomyStrategy(string id)
    {
        if(economyStrategy.ContainsKey(id))
        {
            return economyStrategy[id];
        }  
        else
        {
            Debug.Log("无法找到该id对应的发展策略");
            return null;
        }
    }
}
