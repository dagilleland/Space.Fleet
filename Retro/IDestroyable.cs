

public interface IDestroyable {
	/**
	 * The shieldLevel is the amount of energy that is
	 * dedicated to protecting the vessel. This figure
	 * is modified whenever the vessel takes damage.
	 * @return shieldLevel
	 */
	int getShieldLevel();
	/**
	 * The energyReserveLevel is the amount of energy 
	 * (excluding that dedicated to shields) which is
	 * available for routing to various ship systems.
	 * @return energyReserveLevel
	 */
	int getEnergyReserveLevel();
	/**
	 * The total energy is the sum of the shieldLevel
	 * and energyReserveLevel and any other systems.
	 * @return
	 */
	int getTotalEnergy();
	void takeDamage(int energyBlast);
	bool isDestroyed();
}
