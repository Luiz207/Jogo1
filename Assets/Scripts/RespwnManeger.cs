using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class RespwnManeger : MonoBehaviour {



    private float _respawnTimeCounter;
    public float _respawnTime;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        _respawnTimeCounter += Time.deltaTime;
        if (_respawnTimeCounter >= _respawnTime) {

            Respawn();
            _respawnTimeCounter = 0;


        }

       }
    private void Respawn()
    {
        GameObject gameBlockPrefab = Resources.Load("GameBlock") as GameObject;
        GameObject gameBlock = Instantiate(gameBlockPrefab);
        gameBlock.transform.SetParent(transform,false);

        
    }

 }

