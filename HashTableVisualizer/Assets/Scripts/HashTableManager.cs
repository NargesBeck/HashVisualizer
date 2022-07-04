using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableManager : MonoBehaviour
{
    private const int MaxArrayLength = 17;
    public Cell[] Table;

    public void AddSubmittedValue(string text)
    {
        if (int.TryParse(Linker.Instance.UIManager.GetInputFieldValue, out int newValue))
        {
            int indexOfNewValue = Hash(newValue);
            Table[indexOfNewValue].StoreValue(newValue);
        }
    }

    private int Hash(int input)
    {
        return input % MaxArrayLength;
    }
}
