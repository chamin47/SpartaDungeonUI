using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string itemName;
    public string description;
    public bool isEquipped;

    public Item(string itemName, string description, bool isEquipped)
	{
		this.itemName = itemName;
		this.description = description;
		this.isEquipped = isEquipped;
	}
}
