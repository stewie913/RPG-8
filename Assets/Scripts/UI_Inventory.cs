using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
   private Inventory inventory;
   private Transform itemSlotContainer;
   private Transform itemSlotTemplate;

      private void Awake(){
         itemSlotContainer = transform.Find("itemSlotContainer");
         itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
         if(!itemSlotContainer){
               Debug.LogError("ItemslotContainer Not Found in Awake");

         }
         if(!itemSlotTemplate){
               Debug.LogError("ItemslotTemplate Not Found in Awake");
         }



      }


   public void SetInventory(Inventory inventory){
        this.inventory = inventory;
        RefreshInventoryItems();
   }
   
   private void RefreshInventoryItems(){
      if(inventory == null){
         Debug.LogError("Inventory is null!");
         return;
      }
      int x = 0;
      int y = 0;
      float itemSlotCellSize = 30f;
      foreach(Item item in inventory.GetItemList()){
         if(!itemSlotTemplate){
            Debug.LogError("Item Slot Template is not set");
         }
         else {
            Debug.Log("Item Slot Template is not null");
            Debug.Log(itemSlotTemplate);
         }
         if(!itemSlotContainer){
            Debug.LogError("Item Slot Container is not set");
         }
         else {
            Debug.Log("Item Slot Container is not null");
            Debug.Log(itemSlotContainer);
         }
            
         RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
         itemSlotRectTransform.gameObject.SetActive(true);
         itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
         x++;
         if (x > 4){
            x = 0;
            y++;
         }

      }
      
   }
   }