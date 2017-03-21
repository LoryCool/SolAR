using UnityEngine;
using System.Collections;


public class MenuComportamiento : MonoBehaviour {

	public int iEstado;

	// Use this for initialization
	void Start () {
		iEstado = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MuestraMenu(){
		if (iEstado == 2) {
			GetComponent<Animation>().Play ("MenuIn");
			iEstado = 1;
		} 
		else {
			GetComponent<Animation>().Play ("MenuOut");
			iEstado = 2;
		}
	}
}
