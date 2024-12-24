using System;
using System.Collections.Generic;
using System.Text;

namespace TherianMenu.Mods
{
    internal class Speedboost
    {
        public static void Speedboostmod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 8f;
        }
    }
}

