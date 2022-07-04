using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private InputField InputField;

    public GameObject MainPanel;
    public GameObject InputPanel;

    public string GetInputFieldValue
    {
        get { return InputField.text; }
    }

    public void HandleSubmitClick()
    {
        InputPanel.SetActive(false);
        Linker.Instance.HashTableManager.AddSubmittedValue(GetInputFieldValue);
    }
}
