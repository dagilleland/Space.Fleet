

using System;

public class ShipSystem {
	// Would it be better to have a separate enum class?
	// With a separate enum class we could define properties for
	// each system (i.e. damage levels and repair time).
	public enum SystemType{ COMPUTER, ENGINES, SHIELDS, SHORT_RANGE_SENSORS, LONG_RANGE_SENSORS, PHASERS, TORPEDOS, SUB_SPACE_COMMUNICATIONS }
	
	private SystemType subsystem;
	private int damage = 0;
	private int repairRate;
	/**
	 * @return the subsystem
	 */
	public SystemType getSubsystem() {
		return subsystem;
	}
	/**
	 * @return the damage
	 */
	public int getDamage() {
		return damage;
	}
	/**
	 * @return the repairRate
	 */
	public int getRepairRate() {
		return repairRate;
	}
	/**
	 * @param subsystem
	 */
	public ShipSystem(SystemType subsystem, int repairRate) {
		if(repairRate <= 0)
			throw new ArgumentException("Repair rates must be greater than zero");
		this.subsystem = subsystem;
		this.repairRate = repairRate;
	}
	
	public void setDamage(int damage) {
		if(damage < 0)
			throw new ArgumentException("Damage cannot be negative");
		this.damage = damage;
	}
	
	public void repair(){
		int damage = getDamage() - getRepairRate();
		if(damage < 0)
			damage = 0;
		setDamage(damage);
	}
}
