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

    public IEnumerator Search(string text)
    {
        if (int.TryParse(text, out int key))
        {
            for (int i = 0; i < Table[Hash(key)].valueChain.Count; i++)
            {
                yield return new WaitForSecondsRealtime(1);
                Color color = Table[Hash(key)].valueGameObjects[i].GetComponent<SpriteRenderer>().material.color;
                Table[Hash(key)].valueGameObjects[i].GetComponent<SpriteRenderer>().material.color = Color.grey;
                if (Table[Hash(key)].valueChain[i] == key)
                {
                    Table[Hash(key)].valueGameObjects[i].GetComponent<SpriteRenderer>().material.color = Color.green;
                    break;
                }
                else
                {
                    Table[Hash(key)].valueGameObjects[i].GetComponent<SpriteRenderer>().material.color = Color.red;
                }

            }
        }
    }
}
