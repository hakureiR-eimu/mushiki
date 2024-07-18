using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="SE001",menuName ="Strategy/Economy/Simple")]
public class EconomyStrategy : Strategy
{
    [Header("输入")]
    [Tooltip("经济总量")]public int inTotalEconomy;
    [Tooltip("经济增量")] public int inEconomicIncrement;
    [Tooltip("政治值")] public int inPoliticalValue;
    [Tooltip("文化值")] public int inCulturalValue;
    [Tooltip("科技值")] public int inTechnologyValue;
    [Tooltip("民众信任度")] public int inPublicTrust;
    [Tooltip("对内舆论控制了")] public int inInternalControl;
    [Tooltip("对外舆论控制了")] public int inExternalControl;
    [Header("输出")]
    [Tooltip("经济总量")] public int outTotalEconomy;
    [Tooltip("经济增量")] public int outEconomicIncrement;
    [Tooltip("政治值")] public int outPoliticalValue;
    [Tooltip("文化值")] public int outCulturalValue;
    [Tooltip("科技值")] public int outTechnologyValue;
    [Tooltip("民众信任度")] public int outPublicTrust;
    [Tooltip("对内舆论控制了")] public int outInternalControl;
    [Tooltip("对外舆论控制了")] public int outExternalControl;
    public override void OnExcute()
    {
        Input();
        Output();
    }
    public virtual void Input()
    {
        GameManager.Instance.curCamp.totalEconomy -= inTotalEconomy;
        GameManager.Instance.curCamp.economicIncrement -= inEconomicIncrement;
        GameManager.Instance.curCamp.politicalValue -= inPoliticalValue;
        GameManager.Instance.curCamp.culturalValue -= inCulturalValue;
        GameManager.Instance.curCamp.technologyValue -= inTechnologyValue;
        GameManager.Instance.curCamp.publicTrust -= inPublicTrust;
        GameManager.Instance.curCamp.internalControl -= inInternalControl;
        GameManager.Instance.curCamp.externalControl -= inExternalControl;
    }
    public virtual void Output()
    {
        GameManager.Instance.curCamp.totalEconomy += outTotalEconomy;
        GameManager.Instance.curCamp.economicIncrement += outEconomicIncrement;
        GameManager.Instance.curCamp.politicalValue += outPoliticalValue;
        GameManager.Instance.curCamp.culturalValue += outCulturalValue;
        GameManager.Instance.curCamp.technologyValue += outTechnologyValue;
        GameManager.Instance.curCamp.publicTrust += outPublicTrust;
        GameManager.Instance.curCamp.internalControl += outInternalControl;
        GameManager.Instance.curCamp.externalControl += outExternalControl;
    }
}
