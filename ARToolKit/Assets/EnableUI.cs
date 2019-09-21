using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUI : MonoBehaviour {

    public GameObject notDetectedUI;

    // Update is called once per frame
    void Update () {
		if(this.GetComponent<Canvas>().isActiveAndEnabled)
        {
            notDetectedUI.SetActive(false);
        }
        else
        {
            notDetectedUI.SetActive(true);
        }
	}
}
