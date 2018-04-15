/*
 * Created by SharpDevelop.
 * User: wyrda
 * Date: 4/18/2011
 * Time: 3:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hanoi
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		
		void Btn_CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
