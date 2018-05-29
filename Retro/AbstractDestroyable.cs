

using System;

public abstract class AbstractDestroyable : AbstractLocatable 
	, IDestroyable {
	private int shieldLevel = 0;
	private int energyReserve;
	
	public int getShieldLevel() {
		return shieldLevel;
	}
	
	
	public int getEnergyReserveLevel() {
		return energyReserve;
	}

	
	public int getTotalEnergy() {
		return shieldLevel + energyReserve;
	}


	protected void setShieldLevel(int newLevel) {
		// TODO: Write unit tests to confirm the logic here!
		/* energy | shield | newLevel | newEnergy | newSheild
		 * 500    | 200    | 250      = 450       | 250
		 * 100    | 200    | 250      =  50       | 250
		 * 100    | 200    | 300      =   0       | 300
		 * 100    | 200    | 400      =   0       | 300
		 *   0    | 200    | 400      =   0       | 200
		 *   0    | 200    | 100      = 100       | 100
		 *   0    | 200    |   0      = 200       |   0
		 * 500    | 200    |  50      = 650       |  50
		 */
		if(newLevel < 0)
			throw new ArgumentException("Invalid energy level (must be greater than zero)");
		if(newLevel - shieldLevel > energyReserve)
			newLevel = energyReserve;
		int difference = newLevel - shieldLevel;
		shieldLevel = newLevel;
		energyReserve -= difference;
		
	}
	
	public bool isDestroyed() {
		return shieldLevel <= 0;
	}
	
	public AbstractDestroyable(int energy)
	{
		if(energy < 0)
			throw new ArgumentException("Invalid energy level (must be greater than zero)");
		this.energyReserve = energy;
	}
	
	protected abstract void transferEnergy();

    #region IDestroyable Implementation
    public void takeDamage(int energyBlast)
    {
        throw new NotImplementedException();
    }
    #endregion
}
