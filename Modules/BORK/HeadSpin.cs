using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Bark.GUI;
using GorillaNetworking;

namespace Bark.Modules.BORK
{
    public class HeadSpin : BarkModule
    {
        public static readonly string DisplayName = "Head Spin";

        protected override void OnEnable()
        {

        }

        void Update() // makes your head speeeeeen
        {

        }

        public override string GetDisplayName()
        {
            return DisplayName;
        }

        public override string Tutorial()
        {
            return "speeen!!!! you spin me right round baby right round...";
        }

        protected override void Cleanup() { }
    }
}
