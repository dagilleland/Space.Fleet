/*
 * File:		AutoNavigation.java
 * Author:		Allan Anderson
 * Date:		Apr 23, 2009
 * Modified:	Apr 23, 2009
 * Purpose:		
 */


using System;
/**
* @author aanderson
*
*/
public class AutoNavigation {
	private Point startingPoint;
	private Point endingPoint;
	
	public Point getStartingPoint() {
		return startingPoint;
	}
	
	public Point getEndingPoint() {
		return endingPoint;
	}
	
	public AutoNavigation(Point startingPoint, Point endingPoint){
		this.startingPoint = startingPoint;
		this.endingPoint = endingPoint;
	}
	
	public int calculateSectors(){
		int sectors = 0;
		sectors = (int)(Math.Sqrt(Math.Pow(startingPoint.getX() - endingPoint.getX(), 2) + Math.Pow(startingPoint.getY() - endingPoint.getY(), 2)));
		return sectors;
	}
	
	public double calculateWarpSpeed(){
		double warpSpeed = 0.0;
		warpSpeed = calculateSectors() / 10.0;
		return warpSpeed;
	}
	
	public double calculateNavTheta(){
		double navTheta = 0.0;
		double theta = Math.Acos((double)(startingPoint.getX() - endingPoint.getX()) / calculateSectors()) * 180.0 / Math.PI;
		if(endingPoint.getY() < startingPoint.getY())
			theta += 180;
		navTheta = Math.Round(((theta + 45) / 45) * 10.0) / 10.0; 
		return navTheta;
	}
	
	public int turnsRequired(){
		int turns = 1;
		if(calculateSectors() > 90)
			turns ++;
		return turns;
	}
}
