﻿using UnityEngine;
using System.Collections;

public class QuickWindBuff : BuffDebuff 
{
	private int remainingDuration;
	private string name;
	private float buffStrength;

	public QuickWindBuff()
	{
		name = "QuickWindBuff";
		remainingDuration = 10;
		buffStrength = 0.1f;
	}

	public int GetRemainingDuration()
	{
		return remainingDuration;
	}

	public string GetName()
	{
		return name;
	}

	public void onApply (Stats stats)
	{
		stats.movementModifier += buffStrength;
	}
	
	public void onSecond (Stats stats)
	{
		
		remainingDuration--;

	}
	
	public void onEnd(Stats stats)
	{
		stats.movementModifier -= buffStrength;
	}
}
