﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander2.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

	public static class MobileCenterConstants
	{
		public const string AndroidAppId = "9c9bccaf-be03-4510-87e9-71ef7aab0e62";
		public const string iOSAppId = "";
	}
}
