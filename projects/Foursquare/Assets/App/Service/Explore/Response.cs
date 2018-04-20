using System;
using System.Collections.Generic;

public class Response
{
	public int suggestedRadius { get; set; }
	public string headerLocation { get; set; }
	public string headerFullLocation { get; set; }
	public string headerLocationGranularity { get; set; }
	public string query { get; set; }
	public int totalResults { get; set; }
	public SuggestedBounds suggestedBounds { get; set; }
	public List<Group> groups { get; set; }
}