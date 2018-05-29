

public class Starbase : AbstractDestroyable {
	/*
	 * Rules:
	 * - If klingons are in the same quadrant, the starbase
	 *   can send out an emergency hail and must raise
	 *   shields.
	 * - Klingons will attack while in the same sector
	 *   (even if the federation ship is not around)
	 * - Quick energy replenishment rate
	 * - Can't move (of course)
	 * - Can't inflict damage
	 * - Won't drop shields if klingons around
	 * - Will drop shields when federation ship docks (sans klingons)
	 */
	public Starbase():base(4000) {
		setShieldLevel(500);
	}

	private string pingSignature = "<B>";
	
	public void takeDamage(int energyBlast) {
		// TODO: Add logic for how a Starbase should take damage.
		// Note: Starbases don't have engines or weapons, so all their
		//		 power is available for sheilds!
		if(isDestroyed())
			pingSignature = "-b-";
	}

	
	public string ping() {
		return pingSignature;
	}

	
	protected override void transferEnergy() {
		// TODO Auto-generated method stub
		
	}

}
