using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour {

    public GameObject basketPreFab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < numBaskets; i++) {
            GameObject tBasketGO = Instantiate(basketPreFab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
