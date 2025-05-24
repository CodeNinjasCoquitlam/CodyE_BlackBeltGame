using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Filter 
{
    public static bool Effect;

    public static void effectEnabled()
    {

    }

    public static void Switch()
    {
        if (Effect == false)
        {
            Effect = true;
        }
        else if (Effect == true)
        {
            Effect = false;
        }
    }
}
