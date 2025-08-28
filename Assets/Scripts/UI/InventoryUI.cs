using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    // ���� ���� ������ ����Ʈ (���� ���ӿ����� Player ������ ��� �����;� ��)
    public List<ItemData> playerInventory;

    // ���Ե��� ������ �θ� ������Ʈ (ItemGrid)
    public Transform gridParent;

    // �����ؼ� ����� ���� ������
    public GameObject slotPrefab;

    void Start()
    {
        // �κ��丮�� ó�� �� �� ���Ե��� ����
        CreateSlots();
    }

    public void CreateSlots()
    {
        // playerInventory ����Ʈ�� �ִ� ��� �����ۿ� ���� �ݺ�
        foreach (ItemData item in playerInventory)
        {
            // ���� �������� gridParent �Ʒ��� ����
            GameObject newSlot = Instantiate(slotPrefab, gridParent);

            // ������ ������ ������ �̹����� ������ ���������� ����
            // �ڽ� ������Ʈ�� Image ������Ʈ�� ��Ī
            Image itemIcon = newSlot.transform.Find("ItemIcon").GetComponent<Image>();
            itemIcon.sprite = item.itemIcon;
        }
    }
}