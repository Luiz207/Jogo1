using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBox : MonoBehaviour {

    private const int _numColumnGrid= 4;
    private const int _numRowGrid = 9;

    private float _gridAreaWidth;
    private float _gridAreaHeight;

    private float _gameBlockWidth;
    private float _gameBlockHeight;

      
	// Use this for initialization
	void Start () {
       Transform transformGridArea = transform.Find("GridArea");
        SpriteRenderer spriteRendererGridArea = transformGridArea.gameObject.GetComponent<SpriteRenderer>();
        _gridAreaWidth = spriteRendererGridArea.bounds.size.x;
        _gridAreaHeight = spriteRendererGridArea.bounds.size.y;

        _gameBlockWidth = _gridAreaWidth/ _numColumnGrid;
        _gameBlockHeight = _gridAreaHeight / _numRowGrid;

        // Teste
        for (int x=0; x < _numColumnGrid; x++)
        {
            for (int y=0; y < _numRowGrid; y++) {

                GameObject gameBlockPrefab = Resources.Load("GameBlock") as GameObject;
                GameObject gameBlock = Instantiate(gameBlockPrefab);
                gameBlock.transform.position = new Vector3(x *_gameBlockWidth,y*_gameBlockHeight, 0f);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
