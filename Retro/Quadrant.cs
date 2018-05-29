

public class Quadrant : IPingable {
	/*
	 * Rules:
	 * - If a sector has a starbase, then this sector and
	 *   all neighboring sectors are scanned and available
	 *   on the galactic computer.
	 * - 
	 */
	private string name;
	private bool scanned = false;
	private Sector[][] sectorMap;
	
	public Sector getSector(Location position)
	{
		return sectorMap[position.getX()][position.getY()];
	}

	
	public string ping() {
		// TODO Auto-generated method stub
		// e.g.:  013 means zero klingons, one starbase, and three stars
		return null;
	}
}
