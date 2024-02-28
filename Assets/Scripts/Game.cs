using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    #region SIngleton:Game
    public static Game Instance;
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }       
    }
    #endregion


    [SerializeField] Text[] allCoinsUIText;

    public int coins;

    private void Start()
    {
        UpdateAllCoinsUIText();
    }

    public void UseCoins(int amount)
    {
        coins -= amount;
    }

    public bool HasEnougCoins(int amount)
    {
        return (coins >= amount);
    }

    public void UpdateAllCoinsUIText()
    {
        for(int i = 0; i < allCoinsUIText.Length; i++)
        {
            allCoinsUIText[i].text = coins.ToString();
        }
        
    }
}
