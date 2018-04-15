/*
 * Created by SharpDevelop.
 * User: wyrda
 * Date: 4/16/2011
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Hanoi
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
	class stack
	{
		private int MAX_NR;
		public int n;
		public int[] v;
		
		public stack(int max)
		{
			MAX_NR = max;
			n = 0;
			v = new int[MAX_NR];
		}
		
		public bool push(int val)
		{
			if(n < MAX_NR-1)
			{
				v[n++] = val;
				return true;
			}
			return false;
		}
		public bool pop(out int val)
		{
			if(n > 0)
			{
				val = v[--n];
				return true;
			}
			val = 0;
			return false;
		}
		public void flush()
		{
			n = 0;
		}
	}
}
