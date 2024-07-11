using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CampParameter : MonoBehaviour 
{
    public string campName;
    /// <summary>
    /// 经济总量1
    /// </summary>
    public int totalEconomy;
    /// <summary>
    /// 经济增量
    /// </summary>
    public int economicIncrement;
    /// <summary>
    /// 政治值
    /// </summary>
    public int politicalValue;
    /// <summary>
    /// 文化值
    /// </summary>
    public int culturalValue;
    /// <summary>
    /// 科技值
    /// </summary>
    public int technologyValue;
    /// <summary>
    /// 民众信任度
    /// </summary>
    public int publicTrust;
    /// <summary>
    /// 特殊民众信任度（美国专用，其他国家默认为-100）
    /// </summary>
    public int publicTrustP = -100;
    /// <summary>
    /// 对内舆论控制了
    /// </summary>
    public int internalControl;
    /// <summary>
    /// 对外舆论控制了
    /// </summary>
    public int externalControl;
    /// <summary>
    /// 与NPC的关系
    /// </summary>
    public List<int> relationWithNPCs;
    /// <summary>
    /// 军事筹码
    /// </summary>
    public int militaryChips;
    /// <summary>
    /// 军事值
    /// </summary>
    public int militaryValue;
}
