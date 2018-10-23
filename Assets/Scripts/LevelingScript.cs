using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelingScript : MonoBehaviour
{

    public int currentXp;
    public int currentLevel = 0;
    public int[] xpPerLevel = new int[50];

    public int gold = 0;

    public Text goldText;
    public Text levelText;

    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("level", 0) - 1;
        gold = PlayerPrefs.GetInt("gold", 0);

        updateUI();
    }

    // Update is called once per frame
    void Update ()
    {
        if(currentLevel != 50)
        {
            if (currentXp >= xpPerLevel[currentLevel])
            {
                currentLevel++;
            }
        }
    }

    public void addExperience(int xpGained)
    {
        currentXp += xpGained;

        updateUI();
    }

    public void addGold(int goldGain)
    {
        gold += goldGain;

        updateUI();
    }

    public void spendGold(int amount)
    {
        gold -= amount;

        updateUI();
    }

    public bool checkSpend(int amount)
    {

        if(amount <= gold)
        {
            return true;
        }

        return false;
    }

    void updateUI()
    {
        goldText.text = " " + gold.ToString();
        levelText.text = "Level " + currentLevel.ToString();
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("level", currentLevel);
        PlayerPrefs.SetInt("gold", gold);
    }

}