using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralObj : MonoBehaviour
{
    public GameObject prefabitem;
    [SerializeField] private List<ItemObj> items;
    public ItemObj selectedItem;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instanite(prefabitem, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(keyCode.R))
        {
            SetRamdomItemNumber();
        }
        if (Input.GetKey(KeyCode.Backspace))
        {
            foreach (ItemObj item in items)
            {
                DeletedItem(item);
            }
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                DeletedItem(selectedItem);
            }

        }




        void Awake()
        {
            items = new List<ItemObj>();
        }

        void RegisterItem(ItemObj item)
        {
            items.Add(item);
        }

        void UnregisterItem(ItemObj item)
        {
            if (items.Contains(item))
            {

                items.Remove(item);
            }
        }

        void SetRamdomItemNumber()
        {
            int randomNum = randomNum.Range(0, 100);

            foreach (ItemObj item in items)
            {
                item.transorm.GetComponentInChildren<PartOfItem>().Number = randomNum;
            }
        }

        void DeletedItem(ItemObj item)
        {
            if (item != null)
            {
                Destroy(item.gameObject);
            }

        }

    }
}
