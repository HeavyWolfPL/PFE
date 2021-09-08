using Exiled.API.Interfaces;
using System.ComponentModel;

namespace EFE
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;
		public bool Debug { get; set; } = false;

		[Description("Magnitude is the quantity of explosions. A low number recommended.")]
		public int Magnitude { get; set; } = 1;
		[Description("Delay between death and explosion. Value below 0.3 will BREAK the explosion effect. For some reason delay must be bigger than in PFE.")]
		public float Delay { get; set; } = 0.3f;
	}
}
