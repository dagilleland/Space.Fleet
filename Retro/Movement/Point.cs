/*
 * File:		Point.java
 * Author:		Allan Anderson
 * Date:		Apr 23, 2009
 * Modified:	Apr 23, 2009
 * Purpose:		
 */

using System;

public class Point {
	private int x;
	private int y;
	private int distanceTravelled;
	private int sectorX;
	private int sectorY;
	private int quadrantX;
	private int quadrantY;
	
	public int getSectorX() {
		return sectorX;
	}

	public int getSectorY() {
		return sectorY;
	}

	public int getQuadrantX() {
		return quadrantX;
	}

	public int getQuadrantY() {
		return quadrantY;
	}

	public int getX() {
		return x;
	}
	
	public int getY() {
		return y;
	}
	
	public int getDistanceTravelled(){
		return distanceTravelled;
	}
	
	public Point(int x, int y) {
		this.x = x + Globals.Random.Next(10);
		this.y = y + Globals.Random.Next(10);
		distanceTravelled = 0;
		galacticPoint();
	}
	
	public Point(){
		randomPoint();
		distanceTravelled = 0;
		galacticPoint();
	}
	
	public void move(double navTheta, double velocity){
		double c;
		int a, b;
		c = velocity * 10.0;
		double theta = (Math.Round((navTheta * 45 - 45) * 10.0) / 10.0) * Math.PI / 180;
		a = (int)(Math.Round(c * Math.Cos(theta) * 1000.0) / 1000.0);
		b = (int)(Math.Round(c * Math.Sin(theta) * 1000.0) / 1000.0);
		x += a;
		y += b;
		if(x < 0)
			x += 100;
		if(x > 100)
			x -= 100;
		if(y < 0)
			y += 100;
		if(y > 100)
			y -= 100;
		distanceTravelled = (int)c;
		galacticPoint();
	}
	
	public void randomPoint(){
		x = Globals.Random.Next(100);
		y = Globals.Random.Next(100);
	}
	
	private void galacticPoint(){
		sectorX = x % 10;
		sectorY = y % 10;
		quadrantX = x / 10;
		quadrantY = y / 10;
	}
	
}
public static class Globals
{
    public static Random Random { get; private set; } = new Random();
}