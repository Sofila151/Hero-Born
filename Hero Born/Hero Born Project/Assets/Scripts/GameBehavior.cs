using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour 
 {
    private int _itemsCollected = 0;
 
    // 1
     public int Items
     {
         // 2
         get { return _itemsCollected; }

         // 3
         set { 
                _itemsCollected = value; 
                Debug.LogFormat("Items: {0}", _itemsCollected);
         }
      }
 
     private int _playerHP = 10;
 
     // 4
     public int HP 
     {
         get { return _playerHP; }
         set { 
                _playerHP = value; 
                Debug.LogFormat("Lives: {0}", _playerHP);
          }
     }
 } 