using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    // 내가 가진 아이템 리스트 (실제 게임에서는 Player 데이터 등에서 가져와야 함)
    public List<ItemData> playerInventory;

    // 슬롯들을 생성할 부모 오브젝트 (ItemGrid)
    public Transform gridParent;

    // 복제해서 사용할 슬롯 프리팹
    public GameObject slotPrefab;

    void Start()
    {
        // 인벤토리를 처음 열 때 슬롯들을 생성
        CreateSlots();
    }

    public void CreateSlots()
    {
        // playerInventory 리스트에 있는 모든 아이템에 대해 반복
        foreach (ItemData item in playerInventory)
        {
            // 슬롯 프리팹을 gridParent 아래에 생성
            GameObject newSlot = Instantiate(slotPrefab, gridParent);

            // 생성된 슬롯의 아이콘 이미지를 아이템 아이콘으로 변경
            // 자식 오브젝트의 Image 컴포넌트를 서칭
            Image itemIcon = newSlot.transform.Find("ItemIcon").GetComponent<Image>();
            itemIcon.sprite = item.itemIcon;
        }
    }
}