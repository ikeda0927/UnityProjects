using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Transform mytransform;
    float diff;
    // Start is called before the first frame update
    void Start()
    {
        mytransform = this.transform;
        diff = 0.009f;
    }

    // Update is called once per frame
    void Update()
    {
        //0.2f ~ 2.25fの範囲で移動させる
        if(mytransform.position.z < 0.2f)
        {
            diff = 0.009f;
        }else if(mytransform.position.z > 2.25f)
        {
            diff = -0.009f;
        }
        mytransform.position = new Vector3(mytransform.position.x,mytransform.position.y,mytransform.position.z + diff);
    }
}
