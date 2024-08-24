using UnityEngine;
using UnityEngine.UI;

public class OnClickFooterItem : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener
            (delegate ()
            {
                OnClick(this.gameObject);
            });
    }

    public void OnClick(GameObject _obj)
    {
        print("点击了按钮：" + _obj.name);
    }
}