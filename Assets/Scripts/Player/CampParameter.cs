using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CampParameter : MonoBehaviour 
{
    public string campName;
    /// <summary>
    /// 经济总量
    /// </summary>
    public float totalEconomy;
    /// <summary>
    /// 经济增量
    /// </summary>
    public float economicIncrement;
    /// <summary>
    /// 政治值
    /// </summary>
    public float politicalValue;
    /// <summary>
    /// 文化值
    /// </summary>
    public float culturalValue;
    /// <summary>
    /// 科技值
    /// </summary>
    public float technologyValue;
    /// <summary>
    /// 民众信任度
    /// </summary>
    public float publicTrust;
    /// <summary>
    /// 对外舆论控制了
    /// </summary>
    public float externalControl;
    /// <summary>
    /// 对内舆论控制了
    /// </summary>
    public float internalControl;
    /// <summary>
    /// 与NPC的关系
    /// </summary>
    public List<float> relationWithNPCs;
    /// <summary>
    /// 军事筹码
    /// </summary>
    public float militaryChips;
    /// <summary>
    /// 军事值
    /// </summary>
    public float militaryValue;
}
