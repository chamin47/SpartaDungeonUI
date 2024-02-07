using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupManager : MonoBehaviour
{
	public GameObject equipConfirmPopup; // 장착 확인 팝업 프리팹
	private Item currentItem; // 현재 선택된 아이템

	// 팝업을 표시하는 메소드
	public void ShowEquipPopup(Item item)
	{
		currentItem = item;
		equipConfirmPopup.SetActive(true);
		equipConfirmPopup.GetComponentInChildren<TextMeshProUGUI>().text = $"이 아이템을 {(item.isEquipped ? "해제" : "장착")}하시겠습니까?";
	}

	// "Yes" 버튼 클릭 시 호출될 메소드
	public void OnConfirmEquip()
	{
		// 아이템의 장착 상태를 토글
		currentItem.isEquipped = !currentItem.isEquipped;
		equipConfirmPopup.SetActive(false);
		// 여기에 아이템 장착/해제 후 처리 로직 추가 (예: 인벤토리 UI 업데이트)
	}

	// "No" 버튼 클릭 시 호출될 메소드
	public void OnCancelEquip()
	{
		equipConfirmPopup.SetActive(false);
	}
}
