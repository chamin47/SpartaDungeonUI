using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupManager : MonoBehaviour
{
	public GameObject equipConfirmPopup; // ���� Ȯ�� �˾� ������
	private Item currentItem; // ���� ���õ� ������

	// �˾��� ǥ���ϴ� �޼ҵ�
	public void ShowEquipPopup(Item item)
	{
		currentItem = item;
		equipConfirmPopup.SetActive(true);
		equipConfirmPopup.GetComponentInChildren<TextMeshProUGUI>().text = $"�� �������� {(item.isEquipped ? "����" : "����")}�Ͻðڽ��ϱ�?";
	}

	// "Yes" ��ư Ŭ�� �� ȣ��� �޼ҵ�
	public void OnConfirmEquip()
	{
		currentItem.isEquipped = !currentItem.isEquipped;
		equipConfirmPopup.SetActive(false);
		Inventory.TriggerItemUpdatedEvent();
	}

	// "No" ��ư Ŭ�� �� ȣ��� �޼ҵ�
	public void OnCancelEquip()
	{
		equipConfirmPopup.SetActive(false);
	}
}
