using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public List<Item> items;
	public static event Action OnItemUpdated; // 아이템 업데이트 이벤트 정의

	[SerializeField]
	private Transform slotParent;
	[SerializeField]
	private Slot[] slots;

#if UNITY_EDITOR
	private void OnValidate()
	{
		slots = slotParent.GetComponentsInChildren<Slot>();
	}
#endif

	void Awake()
	{
		FreshSlot();
	}

	public void FreshSlot()
	{
		int i = 0;
		for (; i < items.Count && i < slots.Length; i++)
		{
			slots[i].item = items[i];
		}
		for (; i < slots.Length; i++)
		{
			slots[i].item = null;
		}
	}

	public void AddItem(Item _item)
	{
		if (items.Count < slots.Length)
		{
			items.Add(_item);
			FreshSlot();
			OnItemUpdated?.Invoke(); // 아이템 업데이트 이벤트 호출
		}
		else
		{
			print("슬롯이 가득 차 있습니다.");
		}
	}

	public static void TriggerItemUpdatedEvent()
	{
		OnItemUpdated?.Invoke();
	}
}
