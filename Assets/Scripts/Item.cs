using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
	public string itemName;
	public Sprite itemImage;
	public bool isEquipped;
}