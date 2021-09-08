using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace XFE
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;
		public bool Debug { get; set; } = false;
		[Description("Which classes should explode after death?")]
		public List<RoleType> Roles { get; set; } = new List<RoleType>
		{
			RoleType.Scp173,
			RoleType.Scp0492
		};

		[Description("Magnitude is the quantity of explosions. A low number recommended.")]
		public int Magnitude { get; set; } = 1;
		[Description("Delay between death and explosion. Value below 0.3 will BREAK the explosion effect. For some reason delay must be bigger than in PFE.")]
		public float Delay { get; set; } = 0.3f;
	}
}
