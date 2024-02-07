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
		Inventory.OnItemUpdated += UpdateSlotUI; // 이벤트 구독
	}

	void OnDisable()
	{
		Inventory.OnItemUpdated -= UpdateSlotUI; // 이벤트 구독 해제
	}

	void UpdateSlotUI()
	{
		if (_item != null)
		{
			image.sprite = item.itemImage;
			image.color = new Color(1, 1, 1, 1);
			// 장착 상태에 따른 UI 변경, 예를 들어 테두리 변경 등
			image.transform.parent.GetComponent<Image>().color = _item.isEquipped ? Color.green : Color.white;
		}
		else
		{
			image.color = new Color(1, 1, 1, 0);
		}
	}
}
