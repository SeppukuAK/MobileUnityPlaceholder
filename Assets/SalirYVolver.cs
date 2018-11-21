using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirYVolver : MonoBehaviour {

	// Use this for initialization
	void Start () {

#if !UNITY_ANDROID
        Destroy(this.gameObject);
#endif

    }

#if UNITY_ANDROID

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); //Se carga la aplicación :(
                                //Hay que ser amables :(
        }
    }
#endif

}
