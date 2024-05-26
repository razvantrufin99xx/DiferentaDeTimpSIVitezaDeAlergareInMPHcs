/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/27/2024
 * Time: 1:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculTimpDeViata
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public DateTime dtnow = new DateTime();
		
		public string calculTimpDeLaDataAleasa(int zz, int ll, int aaaa)
		{
			dtnow = DateTime.Now;
			
			int y = dtnow.Year-aaaa;
			int m = Math.Abs(dtnow.Month - ll);
			int d = Math.Abs(dtnow.Day - zz);
			return  " Years: " + y.ToString() + ", Months: " + m.ToString() + ", Days: " + d.ToString();
		}
		//poate vota
		//poate botine un carnet de sofer
		
		public string calculTimpPalaLaPensionareDeLaDataAleas(int zz, int ll, int aaaa)
		{
			dtnow = DateTime.Now;
			
			int y = dtnow.Year-aaaa;
			int m = Math.Abs(dtnow.Month - ll);
			int d = Math.Abs(dtnow.Day - zz);
			int ret = 65-y;
			return  " Years: " + y.ToString() + ", Months: " + m.ToString() + ", Days: " + d.ToString() + ", Pensionare la 65 de ani in :"+ ret.ToString() + " ani";
		}
		public double atletSpeed()
		{
			//an atlet run 100 yard dash into 12 seconds,
			//what speed in mph was having ?
			double ru = 100; //yard dash
			double tim= 12 ; //seconds
			//how many mile per houwe speed have atlet ?
			double fee = ru*3;
			double mila = 5280;
			double mil = fee/mila;
			double sec = 12;
			double secondsinanhour = 3600;
			double secperhour = sec/secondsinanhour;
			double mph = mil/secperhour; //d/t
			return mph;
			
			
			
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Text  = calculTimpDeLaDataAleasa(13,2,1978);
			Text += calculTimpPalaLaPensionareDeLaDataAleas(13,2,1978);
			Text = "MPH = " + atletSpeed().ToString();
		}
	}
}
