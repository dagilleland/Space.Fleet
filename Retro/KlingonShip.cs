

public class KlingonShip : AbstractDestroyable , IActionable {
	/*
	 * Rules:
	 * - Can move to different quadrants
	 * - Is seeking starbases (not federation ships)
	 * - Will stay in sector to destroy starbase when found
	 * - Methodically moves sector to sector (no big warp jumps)
	 * - Cannot dock with starbase
	 */
	public KlingonShip(int energy):base(energy) {
		// TODO Auto-generated constructor stub
	}

	
	protected override void transferEnergy() {
		// TODO Auto-generated method stub

	}

	
	public void move() {
		// TODO Auto-generated method stub

	}

	
	public void shoot(IDestroyable target) {
		// TODO Auto-generated method stub

	}

	
	public void takeTurn() {
		// TODO Auto-generated method stub

	}

	
	public void takeDamage(int energyBlast) {
		// TODO Auto-generated method stub

	}

	
	public string ping() {
		// TODO Auto-generated method stub
		return null;
	}

}
