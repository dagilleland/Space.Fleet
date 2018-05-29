

public class Sector {
	private IPingable occupant;

	/**
	 * @return the occupant
	 */
	public IPingable getOccupant() {
		return occupant;
	}

	/**
	 * @param occupant
	 */
	public Sector(IPingable occupant) {
		this.occupant = occupant;
	}
	
}
