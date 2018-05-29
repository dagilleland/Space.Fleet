

public class GameUniverse {
	// Singleton pattern
	private static GameUniverse universe = null;
	public static GameUniverse getUniverse(){
		if(universe == null)
			universe = generateUniverse();
		return universe;
	}
	private static GameUniverse generateUniverse() {
		// TODO Auto-generated method stub
		/*
		 * We want to generate a 2D universe based on
		 * a graph.
		 * 
		 * Future versions may include a hex-based graph
		 * system.
		 */
		return null;
	}
	private GameUniverse(){}
	
	private Quadrant[][] galacticMap;
	public Quadrant getQuadrant(Location position){
		return galacticMap[position.getX()][position.getY()];
	}

}
