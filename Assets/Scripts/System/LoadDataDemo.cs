using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 读取数据
/// </summary>
public class LoadDataDemo
{
    private TextAsset data;         //读取到的数据
    private string dataPath = "Datas/BaseInnerData";        //存放数据的路径
    private Dictionary<int, List<FootItem>> lowItemListDic = new Dictionary<int, List<FootItem>>();

    public LoadDataDemo()
    {
        //if (System.IO.File.Exists("Assets/Datas/BaseInnerData.csv"))
        //{
        //    Debug.Log("路径合法");
        //}
        //else
        //{
        //    Debug.Log("路径非法");
        //    return;
        //}
        data = Resources.Load<TextAsset>(dataPath);
        string[] dataRow = data.text.Split('\n');
        foreach (var row in dataRow)
        {
            List<FootItem> footItemList = new List<FootItem>();

            string[] rowArray = row.Split(',');
            if (rowArray[0] != "player")
            {
                continue;
            }
            int ID = int.Parse(rowArray[1]); //ID
            string name = rowArray[2];
            int ecoSum = int.Parse(rowArray[3]); //经济总量
            int ecoDx = int.Parse(rowArray[4]); //经济增速
            int culPoint = int.Parse(rowArray[5]); //文化值
            int polPoint = int.Parse(rowArray[6]); //政治值
            int tecPoint = int.Parse(rowArray[7]); //科技值

            int trust = int.Parse(rowArray[8]); //民众信任度
            int innerControl = int.Parse(rowArray[9]); //对内舆论控制力
            int outerControl = int.Parse(rowArray[10]); //对外舆论控制力
            int milBase = int.Parse(rowArray[11]);      //军事筹码
            int milPoint = int.Parse(rowArray[12]);     //军事值

            //InnerEconomy
            FootItem footItem0 = new FootItem("经济总量", ecoSum);
            FootItem footItem1 = new FootItem("经济增速", ecoDx);
            FootItem footItem2 = new FootItem("文化值", culPoint);
            FootItem footItem3 = new FootItem("政治值", polPoint);
            FootItem footItem4 = new FootItem("科技值", tecPoint);

            //InnerSociety
            FootItem footItem5 = new FootItem("民众信任度", trust);
            FootItem footItem6 = new FootItem("对内舆论控制力", innerControl);
            FootItem footItem7 = new FootItem("对外舆论控制力", outerControl);
            FootItem footItem8 = new FootItem("军事筹码", milBase);
            FootItem footItem9 = new FootItem("军事值", milPoint);

            footItemList.Add(footItem0);
            footItemList.Add(footItem1);
            footItemList.Add(footItem2);
            footItemList.Add(footItem3);
            footItemList.Add(footItem4);
            footItemList.Add(footItem5);
            footItemList.Add(footItem6);
            footItemList.Add(footItem7);
            footItemList.Add(footItem8);
            footItemList.Add(footItem9);

            lowItemListDic.Add(ID, footItemList);
            //Debug.Log(footItemList[1].itemVal);
        }
    }

    /// <summary>
    /// 根据ID获取底部数据数组
    /// </summary>
    /// <param name="_playerID">playerID</param>
    /// <returns></returns>
    public List<FootItem> GetPlayerData(int _playerID)
    {
        return lowItemListDic[_playerID];
    }
    public void Test()
    {
        foreach (var player in lowItemListDic)
        {
            foreach (var item in player.Value)
            {
                Debug.Log("ItemName:" + item.itemName + ",ItemVal" + item.itemVal.ToString());
            }
        }
    }
}
