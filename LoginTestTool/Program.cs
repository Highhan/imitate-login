﻿using System;
using Gtk;
using System.IO;

namespace LoginTestTool
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			String s = Path.Combine (Environment.CurrentDirectory, "../../../xulrunner");

			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
