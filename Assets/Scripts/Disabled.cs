using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabled : MonoBehaviour
{
    //public bool checking;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        DarkbringerEffect darkbringerEffect = effect.GetComponent<DarkbringerEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        DarkbringerEffect darkbringerEffect = effect.GetComponent<DarkbringerEffect>();
        if (Filter.Effect == false)
        {
            darkbringerEffect.enabled = false;
        } 
        else if (Filter.Effect == true)
        {
            darkbringerEffect.enabled = true;
        }
    }

    public void Stitch()
    {
        Filter.Switch();
    }
}