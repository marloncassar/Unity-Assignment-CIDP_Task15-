using UnityEngine;
using System.Collections;

public class soundCollision : MonoBehaviour {
	public AudioClip Water;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter (Collision col)
	{

		

		if(col.gameObject.tag == "box1")
		{
			

			GetComponent<AudioSource> ().PlayOneShot (Water);
			
			
			
		}
	}
	

}
