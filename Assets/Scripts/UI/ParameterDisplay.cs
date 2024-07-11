using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterDisplay : MonoBehaviour
{
    //
    public Text totalEconomy;
    public Text economicIncrement;
    public Text politicalValue;
    public Text culturalValue;
    public Text technologyValue;
    public Text publicTrust;
    public Text internalControl;
    public Text externalControl;
    public Text militaryChips;
    public Text militaryValue;
    private void Update()
    {
        UpdateValue();
    }
    private void UpdateValue()
    {
        totalEconomy.text = GameManager.Instance.curCamp?.totalEconomy.ToString();
        economicIncrement.text=GameManager.Instance.curCamp?.economicIncrement.ToString();
        politicalValue.text = GameManager.Instance.curCamp?.politicalValue.ToString();
        culturalValue.text=GameManager.Instance.curCamp?.culturalValue.ToString();
        technologyValue.text=GameManager.Instance.curCamp?.technologyValue.ToString();
        if (GameManager.Instance.curCamp?.publicTrustP < 0)
        {
            publicTrust.text = GameManager.Instance.curCamp?.publicTrust.ToString();
        }
        else
        {
            publicTrust.text = GameManager.Instance.curCamp?.publicTrust.ToString()
                + "/" + GameManager.Instance.curCamp?.publicTrustP.ToString();
        }
        internalControl.text=GameManager.Instance.curCamp?.internalControl.ToString();
        externalControl.text=GameManager.Instance.curCamp?.externalControl.ToString();
        militaryChips.text=GameManager.Instance.curCamp?.militaryChips.ToString();
        militaryValue.text=GameManager.Instance.curCamp?.militaryValue.ToString();
    }
}
