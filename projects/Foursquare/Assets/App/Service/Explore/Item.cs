using System;
using System.Collections.Generic;

public class Item
{
	public Reasons reasons { get; set; }
	public Venue venue { get; set; }
	public List<Tip> tips { get; set; }
	public string referralId { get; set; }
}

