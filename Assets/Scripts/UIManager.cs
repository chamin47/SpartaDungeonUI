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
    public TextMeshPro playerIdText;
    public TextMeshPro levelText;
    public TextMeshPro goldText;

    private PlayerData playerData;

	private void Start()
	{
        playerData = new PlayerData("CDM", 10, 20000);
        UpdateUI();
	}

	private void UpdateUI()
	{
        playerIdText.text = "ID: " + playerData.playerId;
        levelText.text = "Level: " + playerData.level;
        goldText.text = "Gold: " + playerData.gold;
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
