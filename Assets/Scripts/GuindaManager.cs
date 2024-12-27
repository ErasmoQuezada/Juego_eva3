using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuindaManager : MonoBehaviour
{
    public static GuindaManager instance;
    
    private int guindas;
    [SerializeField] private TMP_Text guindasDisplay;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    
    private void OnGUI()
    {
        guindasDisplay.text = guindas.ToString();
    }

    public void ChangeGuindas(int amount)
    {
        guindas += amount;
    }
}
