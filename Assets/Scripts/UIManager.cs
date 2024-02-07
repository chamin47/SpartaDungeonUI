using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject statusPanel;
    public GameObject inventoryPanel;
    public TextMeshProUGUI playerIdText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI goldText;
	public TextMeshProUGUI AtkText;
	public TextMeshProUGUI DefText;
	public TextMeshProUGUI HpText;
	public TextMeshProUGUI CriticalText;

	private PlayerData playerData;

	private void Start()
	{
        playerData = new PlayerData("CDM", 10, 20000, 35, 40, 100, 25);
        UpdateUI();
	}

	private void UpdateUI()
	{
        playerIdText.text = "ID: " + playerData.playerId;
        levelText.text = "LEVEL: " + playerData.level;
        goldText.text = ""+playerData.gold;
        AtkText.text = "" + playerData.Atk;
        DefText.text = "" + playerData.Def;
        HpText.text = "" + playerData.Hp;
        CriticalText.text = "" + playerData.Critical;
    }

    public void ShowStatus()
    {
        statusPanel.SetActive(true);
        inventoryPanel.SetActive(false);
    }

    public void ShowInventory()
    {
        inventoryPanel.SetActive(true);
        statusPanel.SetActive(false);
    }

    public void HidePanels()
    {
        statusPanel.SetActive(false );
        inventoryPanel.SetActive(false);
    }
}
