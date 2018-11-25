using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundScript : MonoBehaviour {
    public Text quoteText;
    public Renderer rend;
    public static int counter = 0;
	public string[] quotes = new string[5];



	// Use this for initialization
	void Start () {
		

    }
	

    public void SoundOnCollison()
    {
        counter = 1;
		quoteText.text ="jkldfv";

    }

	// Update is called once per frame
	void Update () {
		quotes[0] = "AAAAA";
		quotes[1] = "BBBBB";
		quotes[2] = "CCCCC";
		quotes[3] = "EEEEE";
		quotes[4] = "DDDDD";

        if (counter == 1)
        {
			int index = Random.Range (0, 5);
			quoteText.text ="jkldfv";
			counter = 0;
        }
        if (counter == 0)
        {
           quoteText.text = "NC";
        }
        
    }
}
