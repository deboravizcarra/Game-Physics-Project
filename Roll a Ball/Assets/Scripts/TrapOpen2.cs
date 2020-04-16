using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen2 : MonoBehaviour
{
    public GameObject Cube;

        void OnTriggerEnter(){
        Cube.GetComponent<Animation>().Play("TrapDoorAnim2");
    }
}
