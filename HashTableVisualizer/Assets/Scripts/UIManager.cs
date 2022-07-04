using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private InputField InputField;
    [SerializeField]
    private InputField SearchInputField;

    public GameObject MainPanel;
    public GameObject InputPanel;
    public GameObject SearchPanel;

    public string GetInputFieldValue
    {
        get { return InputField.text; }
    }
    public string GetSearchInputFieldValue
    {
        get { return SearchInputField.text; }
    }

    public void HandleAddSubmitClick()
    {
        InputPanel.SetActive(false);
        Linker.Instance.HashTableManager.AddSubmittedValue(GetInputFieldValue);
    }

    public void HandleSearchSubmitClick()
    {
        SearchPanel.SetActive(false);
        StartCoroutine(Linker.Instance.HashTableManager.Search(GetSearchInputFieldValue));
    }
}
