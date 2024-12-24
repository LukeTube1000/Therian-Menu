using System;
using System.Collections.Generic;
using UnityEngine;

namespace TherianMenu.Mods
{
    internal class Banned
    {
        // Method to change the banned text with colored text
        public static void ChangeBannedText()
        {
            // Ensure GorillaNetworking namespace is correctly referenced
            GorillaNetworking.GorillaComputer.instance.GeneralFailureMessage("<color=\"blue\">Monke Is Banned By Lemming</color>"); // to make it a different color put <color="THE COLOR">YOUR TEXT HERE</color>
        }

        // Method to make everyone RGB
        public static void MakeEveryoneRGB()
        {
            float h = (Time.frameCount / 180f) % 1f;

            foreach (VRRig vrrig in (VRRig[])GameObject.FindObjectsOfType(typeof(VRRig)))
            {
                vrrig.mainSkin.material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
            }
        }
    }
}
