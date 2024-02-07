using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
	[SerializeField] Image image;

	private Item _item;
	public Item item
	{
		get { return _item; }
		set
		{
			_item = value;
			UpdateSlotUI();
		}
	}

	void OnEnable()
	{
		Inventory.OnItemUpdated += UpdateSlotUI; // �̺�Ʈ ����
	}

	void OnDisable()
	{
		Inventory.OnItemUpdated -= UpdateSlotUI; // �̺�Ʈ ���� ����
	}

	void UpdateSlotUI()
	{
		if (_item != null)
		{
			image.sprite = item.itemImage;
			image.color = new Color(1, 1, 1, 1);
			// ���� ���¿� ���� UI ����, ���� ��� �׵θ� ���� ��
			image.transform.parent.GetComponent<Image>().color = _item.isEquipped ? Color.green : Color.white;
		}
		else
		{
			image.color = new Color(1, 1, 1, 0);
		}
	}
}
