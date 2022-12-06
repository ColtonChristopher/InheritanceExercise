using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;
        }

		public string WingColor { get; set; }
		public bool CanFly { get; set; }
		public bool WillMigrate { get; set; }
		public double BeakLength { get; set; }
	}
}

