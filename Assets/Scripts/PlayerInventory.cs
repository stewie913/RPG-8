using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;

 

      private void Start()
    {
        
        inventory = new Inventory();

    }
}
