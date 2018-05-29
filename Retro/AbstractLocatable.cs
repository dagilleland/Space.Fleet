

public abstract class AbstractLocatable : ILocatable, IPingable {
	private Location quadrantPosition;
	private Location sectorPosition;
	
	public Quadrant getQuadrant() {
		return GameUniverse.getUniverse().getQuadrant(quadrantPosition);
	}

	
	public Location getQuadrantPosition() {
		return quadrantPosition;
	}

	
	public Sector getSector() {
		return getQuadrant().getSector(sectorPosition);
	}

	
	public Location getSectorPosition() {
		return sectorPosition;
	}

    #region IPingable Implementation
    public string ping()
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
