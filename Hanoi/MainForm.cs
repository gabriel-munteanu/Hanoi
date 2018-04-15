/*
 * Created by SharpDevelop.
 * User: wyrda
 * Date: 4/16/2011
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hanoi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Constants and variables for drawing
		const int disk_base_size = 20;
		const int disk_multiplier = 10;
		const int disk_height = 25;
		const int stick_base = 120;
		const int stick_height = 270;
		const int stick_thickness = 4;
		const int space_betwin_sticks = 10;
		int[] stick_middle = new int[3];
		
		System.Drawing.Graphics formGraphics;	
		SolidBrush brush_stick = new SolidBrush(Color.DarkBlue);
		Color[] brush_color = new Color[11]{Color.White, 
													Color.Blue, Color.Red, 
													Color.Gray, Color.Green, 
													Color.Yellow, Color.Brown, 
													Color.Violet, Color.Gold, 
													Color.Aqua, Color.Black};
		SolidBrush[] brush_disk = new SolidBrush[11];
		//-------------------------------
		
		//Hanoi variables
		stack Moves;//vector use to store the moves that must be done
		stack[] I;//the 3 stacks
		int step;//used to know at what step we are(the position in the 'Moves' vector)
		//-------------------------------
		//Other variables
		bool forward,back;//used to know if we can go forward or back
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			
			formGraphics = panel_Draw.CreateGraphics();	
			for(int i=0; i<11; i++)
				brush_disk[i] = new SolidBrush(brush_color[i]);
			
			I = new stack[3];
        	I[0] = new stack(11);
        	I[1] = new stack(11);
        	I[2] = new stack(11);
			Moves = new stack(1024);
			
		}
		//--------Deny user changes---------------------------------
		void Cbobox_DiskNrKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}	
		
		
		void Cbobox_DiskNrTextUpdate(object sender, EventArgs e)
		{
			cbobox_DiskNr.Text = "1";
		}
		
		void Txt_PlaySpeedKeyPress(object sender, KeyPressEventArgs e)
		{
			bool allow = false;
			if(e.KeyChar >= '0' && e.KeyChar <= '9')
				allow = true;
			if(e.KeyChar == '.' || e.KeyChar == '\b')
				allow = true;
			if(!allow)
				e.Handled = true;
			
		}	
		
		//--------Hanoi Algorithm(recursive)------------------------	
		void hanoi(int x, int from, int to, int help)
        {
            if (x > 0)
            {
                hanoi(x - 1, from, help, to);
                //move(x, from, to); 
                Moves.push(from*10+to);
                hanoi(x - 1, help, to, from);
            }		
        }
		//--------Step functions------------------------------------
		//---Used to step forward and back through the solution-----
		void Step_Forward()
		{
			if(forward == false)
				return;
			int val ,from, to;
			from = Moves.v[step] / 10;
			to = Moves.v[step] % 10;
			
			I[from].pop(out val);
			I[to].push(val);
			
			step++;
			
			if(step == Moves.n)
				forward = false;
			if(back == false)
				back = true;
		}
		void Step_Back()
		{
			if(back == false)
				return;			
			int val ,from, to;
			
			step--;
			
			from = Moves.v[step] / 10;
			to = Moves.v[step] % 10;
			
			I[to].pop(out val);
			I[from].push(val);			
			
			if(step == 0)
				back = false;
			if(forward == false)
				forward = true;
		}
		
		//--------Draw functions------------------------------------
		void Draw_Base()
		{
			//Draw the bases of the sticks
			formGraphics.FillRectangle( brush_stick, 0, panel_Draw.Height-stick_thickness, stick_base, stick_thickness);
			formGraphics.FillRectangle( brush_stick, stick_base+space_betwin_sticks, panel_Draw.Height-stick_thickness, stick_base, stick_thickness);
			formGraphics.FillRectangle( brush_stick, 2*(stick_base+space_betwin_sticks), panel_Draw.Height-stick_thickness, stick_base, stick_thickness);
			
			//Draw the sticks
			stick_middle[0] = stick_base/2;
			formGraphics.FillRectangle( brush_stick,  stick_middle[0] - stick_thickness/2, panel_Draw.Height - stick_height, stick_thickness, stick_height);
			stick_middle[1] = stick_middle[0] + stick_base + space_betwin_sticks;
			formGraphics.FillRectangle( brush_stick,  stick_middle[1] - stick_thickness/2, panel_Draw.Height - stick_height, stick_thickness, stick_height);
			stick_middle[2] = stick_middle[1] + stick_base + space_betwin_sticks;
			formGraphics.FillRectangle( brush_stick,  stick_middle[2] - stick_thickness/2, panel_Draw.Height - stick_height, stick_thickness, stick_height);
		}
		void Draw_Stacks()
		{
			//Draw the stacks
			for(int j=0; j<3; j++)
				for(int i=0; i<I[j].n; i++)
				{
					int disk_width = (disk_base_size + I[j].v[i] * disk_multiplier);
					formGraphics.FillRectangle( brush_disk[I[j].v[i]],  stick_middle[j] - disk_width/2,
															panel_Draw.Height - stick_thickness - (i+1)*disk_height,
					                           				disk_width,
					                           				disk_height );
				}
		}				
		
		//--------Other events--------------------------------------
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			Draw_Base();
			Draw_Stacks();
		}
		
		void Cbox_AutoPlayCheckedChanged(object sender, EventArgs e)
		{			
			txt_PlaySpeed.Enabled = cbox_AutoPlay.Checked;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			About fabout = new About();
			fabout.ShowDialog();
		}
		//--------Timer event---------------------------------------
		void Tmr_PlayTick(object sender, EventArgs e)
		{
			int new_interval = (int)(float.Parse(txt_PlaySpeed.Text)*1000);
			tmr_Play.Interval = (new_interval == 0 ? tmr_Play.Interval : new_interval) ;
			if(forward)
			{
				Btn_ForwardClick(null, null);				
			}
			else
			{
				Btn_PauseResumeClick(null, null);
			}
		}
		//--------Buttons events------------------------------------
		void Btn_StartStopClick(object sender, EventArgs e)
		{
			if(btn_StartStop.Text == "Start")
			{
				//Variables
				back = false;
				forward = true;					
				btn_StartStop.Text = "Stop";
				cbox_AutoPlay.Enabled = false;
				step = 0;
				
				//Calculation first				
				I[0].flush();
				I[1].flush();
				I[2].flush();
				Moves.flush();
				
				int disk_nr = Int32.Parse(cbobox_DiskNr.Text);
				//fill the first stack
	            for(int i=1; i<=disk_nr; i++)
	            	I[0].push(disk_nr-i+1);
				
				hanoi(disk_nr, 0, 2, 1);
				
				//Drawing after
				formGraphics.Clear(this.BackColor);
				Draw_Base();
				Draw_Stacks();
				
				//Manual or automatic play
				if(cbox_AutoPlay.Checked)
				{
					panel_ManualControl.Enabled = false;
					tmr_Play.Interval = (int)(float.Parse(txt_PlaySpeed.Text)*1000);
					tmr_Play.Enabled = true;
					//tmr_Play.Start();
					btn_PauseResume.Enabled = true;
				}
				else
					panel_ManualControl.Enabled = true;
					
			}
			else
			{
				panel_ManualControl.Enabled = false;
				btn_StartStop.Text = "Start";
				cbox_AutoPlay.Enabled = true;
				if(cbox_AutoPlay.Checked)
				{
					tmr_Play.Enabled = false;
					btn_PauseResume.Enabled = false;
					btn_PauseResume.Text = "Pause";
				}
			}
		}
		
		void Btn_ForwardClick(object sender, EventArgs e)
		{
			Step_Forward();
			formGraphics.Clear(this.BackColor);
			Draw_Base();
			Draw_Stacks();
		}
		
		void Btn_BackClick(object sender, EventArgs e)
		{
			Step_Back();
			formGraphics.Clear(this.BackColor);
			Draw_Base();
			Draw_Stacks();
		}	
		
		void Btn_PauseResumeClick(object sender, EventArgs e)
		{
			if(btn_PauseResume.Text == "Pause")
			{
				tmr_Play.Stop();
				btn_PauseResume.Text = "Resume";
				panel_ManualControl.Enabled = true;
			}
			else
			{
				tmr_Play.Start();
				btn_PauseResume.Text = "Pause";
				panel_ManualControl.Enabled = false;
			}
					
		}	
		
	}
}
