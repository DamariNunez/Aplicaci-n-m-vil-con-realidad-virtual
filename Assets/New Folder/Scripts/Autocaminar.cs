using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autocaminar : MonoBehaviour {
    public GameObject VisionVr;
    public const int AnguloRecto = 90;
    public bool EstaCaminando = false;
    public float velocidad;
    public bool CaminarCuandoPulsamos;
    public bool caminarCuandoMiramos;
    public bool CaminarLaPosicionY;
    public double AnguloDelUmbral;
    public bool CongelarLaPosicionY;
    public float compensarY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (caminarCuandoMiramos && !CaminarCuandoPulsamos && !EstaCaminando && VisionVr.transform.eulerAngles.x >= AnguloDelUmbral && VisionVr.transform.eulerAngles.x <= AnguloRecto)
        {
            EstaCaminando = true;
        }
        else if (caminarCuandoMiramos && !CaminarCuandoPulsamos && EstaCaminando && (VisionVr.transform.eulerAngles.x <= AnguloDelUmbral || VisionVr.transform.eulerAngles.x >= AnguloRecto))
        {
            EstaCaminando = false;
        }
        if (EstaCaminando)
        {
            Caminar();
        }
        if (CongelarLaPosicionY)
        {
            transform
                .position = new Vector3(transform.position.x, compensarY, transform.position.z);
        }
        
	}
    public void Caminar() {
        Vector3 Direccion = new Vector3(VisionVr.transform.forward.x, 0, VisionVr.transform.forward.z).normalized * velocidad * Time.deltaTime;
        Quaternion Rotacion = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        transform.Translate(Rotacion * Direccion);

    }
}
