

public class Location {
	private int x;
	private int y;
	/**
	 * @return the x
	 */
	public int getX() {
		return x;
	}
	/**
	 * @return the y
	 */
	public int getY() {
		return y;
	}
	/**
	 * @param x
	 * @param y
	 */
	public Location(int x, int y) {
		this.x = x;
		this.y = y;
	}
	/*
	 * Do we want to add logic to check that x and y
	 * are valid coordinates?
	 */
}
