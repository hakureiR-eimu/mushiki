using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
    public CampParameter curCamp;
    public List<CampParameter> curCampList;
}
