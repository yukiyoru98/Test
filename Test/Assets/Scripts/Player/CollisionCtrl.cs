﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCtrl : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "SceneObjects"){
            CollideSceneObj(collision);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "SceneObjects"){
            TriggerSceneObj(collider);
        }
    }
    void CollideSceneObj(Collision2D collision){
        
        //Debug.Log("CollideSceneObj");
        //Debug.Log(collision.GetContact(0).normal);

        if(collision.gameObject.name == "Block_Root" && collision.GetContact(0).normal == Vector2.down){
            //if hit the bottom of the Block
            collision.gameObject.SendMessage("isHit", PlayerData.self.Power);
        }

        if(collision.gameObject.name == "CoinBlock_Root" && collision.GetContact(0).normal == Vector2.down){
            //if hit the bottom of the CoinBlock
            collision.gameObject.SendMessage("isHit");
        }
    }
    void TriggerSceneObj(Collider2D collider){
        if(collider.gameObject.name == "Coin_Root"){
            //if touch the Coin
            collider.gameObject.SendMessage("GetCoin");
        }
        
    }
}