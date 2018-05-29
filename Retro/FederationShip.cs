

public class FederationShip : AbstractDestroyable , IActionable {
	/*
	 * Rules:
	 * - can move within quadrant & sector
	 * - takes energy to repair ship systems
	 * - can dock as part of moving (if starbase shields are down)
	 * - will repair/replenish when docked
	 * - docking takes a turn (more if more damage)
	 */
	private ShipSystem[] shipSystems = new ShipSystem[System.Enum.GetValues(typeof (ShipSystem.SystemType)).Length];
	private int photonTorpedoes = 12;
	private bool docked = false;
	
	
	public FederationShip():base(3000) {
		// TODO Auto-generated constructor stub
		// TODO: Create all the ship systems
		int index = 0;
		foreach(ShipSystem.SystemType system in System.Enum.GetValues(typeof(ShipSystem.SystemType)))
		{
			shipSystems[index] = new ShipSystem(system, 5);
			index++;
		}
	}

	
	protected override void transferEnergy() {
		// TODO Auto-generated method stub

	}

	
	public void move() {
		// TODO Auto-generated method stub
		/*
		 * use code similar to that shown in:
		 * starTrek.mod.oop.movement.Point move()
		 */
	}

	
	public void shoot(IDestroyable target) {
		// TODO Auto-generated method stub

	}

	
	public void takeDamage(int energyBlast) {
		// TODO Auto-generated method stub

	}

	
	public string ping() {
		// TODO Auto-generated method stub
		return null;
	}

	
	public void takeTurn() {
		// TODO Auto-generated method stub
		
	}
}
