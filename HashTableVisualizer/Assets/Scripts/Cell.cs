using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public List<int> valueChain = new List<int>();
    public List<GameObject> valueGameObjects = new List<GameObject> ();
    public int Index;

    public void StoreValue(int value)
    {
        valueChain.Add(value);
        Visualize();
    }

    private void Visualize()
    {
        for (int i = 0; i < valueGameObjects.Count; i++)
        {
            if (i < valueChain.Count)
            {
                valueGameObjects[i].SetActive(true);
                valueGameObjects[i].GetComponentInChildren<TextMesh>().text = valueChain[i].ToString();
            }
            else
            {
                valueGameObjects[i].SetActive(false);
            }
        }
    }
}
