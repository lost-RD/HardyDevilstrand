using System;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;

namespace HardyDevilstrand
{
	[StaticConstructorOnStartup]
	public class PlantDevilstrand : Plant
	{
		public override bool Dying
		{
			get
			{
				return (this.def.plant.LimitedLifespan && this.ageInt > this.def.plant.LifespanTicks);
			}
		}
	}
}
