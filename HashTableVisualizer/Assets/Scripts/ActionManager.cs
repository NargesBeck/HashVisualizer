using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        Linker.Instance.UIManager.MainPanel.SetActive(false);
    }

    public void OnAddButtonClick()
    {
        Linker.Instance.UIManager.InputPanel.SetActive(true);
    }

    public void OnAddSubmitButtonClick()
    {
        Linker.Instance.UIManager.HandleAddSubmitClick();
    }

    public void OnSearchButtonClick()
    {
        Linker.Instance.UIManager.SearchPanel.SetActive(true);
    }

    public void OnSearchSubmitButtonClick()
    {
        Linker.Instance.UIManager.HandleSearchSubmitClick();
    }
}
