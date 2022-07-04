using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linker : MonoBehaviour
{
    private static Linker instance;
    public static Linker Instance
    { 
        get 
        { 
            if (instance == null)
                instance = FindObjectOfType<Linker>();
            return instance; 
        } 
    }

    public HashTableManager HashTableManager;
    public UIManager UIManager;
}
