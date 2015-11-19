using UnityEngine;
using System.Collections;

public class rampeOnClick : MonoBehaviour {

    void OnMouseDown()
    {
        if (!varGlobales.isCamFauteuil)
        {
            if (varGlobales.etatRampe == 0 || varGlobales.etatRampe == 1)
            {
                varGlobales.etatRampe += 1;
            }
            else
            {
                varGlobales.etatRampe = 0;
            }
            Debug.Log(varGlobales.etatRampe);
        }

    }
}
