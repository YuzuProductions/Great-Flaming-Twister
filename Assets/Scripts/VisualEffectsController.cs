using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VisualEffectsController : MonoBehaviour
{
    public bool isPlaying = true;
    public List<string> FireWorksNames = null;
    void Update() { 


        var ps = GetComponent<VisualEffect>();
        if (Input.GetKeyDown(KeyCode.Space)){
              string name  = FireWorksNames[Random.Range(0, 3)];
            ps.SendEvent(name);}

        if (isPlaying) { }
        
        else { }
        
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            ps.Play();
        }
            //ps.Stop();
    }
}
