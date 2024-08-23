/// <summary>
/// 定义基本Footer对象
/// </summary>
public class FootItem
{
    public string itemName;
    public int? itemVal;
    public FootItem(string _itemName, int _itemVal)
    {
        itemName = _itemName;
        itemVal = _itemVal;
    }
    public FootItem(string _itemName)
    {
        itemName = _itemName;
    }
}