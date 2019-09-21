using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class OpenLinks : MonoBehaviour {

	public void openPortfolio()
    {
        Application.OpenURL("http://www.alexandercrane.me/");
    }

    public void openLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/alexander-crane-51160098/");
    }
}
