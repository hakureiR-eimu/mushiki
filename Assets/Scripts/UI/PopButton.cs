using UnityEngine;

public class PopButton : MonoBehaviour
{
    bool newspaperState = false;
    public void OnClick()
    {
        OnClickNewspaper();
        Debug.Log($"你点击了{gameObject.name},重写此方法以弹出弹窗");
    }
    private void OnClickNewspaper()
    {
        GameObject newspaper = GameManager.Instance.Newspaper;

        newspaperState = !newspaperState;
        newspaper.SetActive(newspaperState);

        string text = "";
        foreach (var item in GameManager.Instance.influenceLog)
        {
            text += item;
            text += "\n";
        }

        newspaper.GetComponent<NewspaperDisplay>().updateNews(text);


    }
}
