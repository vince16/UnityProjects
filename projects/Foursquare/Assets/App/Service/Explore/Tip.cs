using System;

public class Tip
{
	public string id { get; set; }
	public int createdAt { get; set; }
	public string text { get; set; }
	public string type { get; set; }
	public bool logView { get; set; }
	public int agreeCount { get; set; }
	public int disagreeCount { get; set; }
	public Todo todo { get; set; }
	public User2 user { get; set; }
}

