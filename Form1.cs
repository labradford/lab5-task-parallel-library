using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class Form1 : Form
	{
		#region Fields
		
		#endregion Fields

		#region Constructors
		public Form1()
		{
			InitializeComponent();
		}
		#endregion Constructors

		#region Methods
		/// <summary>
		/// Update the pi output text box
		/// </summary>
		/// <param name="pi">New value for pi</param>
		private void UpdatePiTextBlock(string pi)
		{
			// TODO:
		}
		
		/// <summary>
		/// Task to calculate an ever-growing number of digits in pi (up to 1,000,000)
		/// </summary>
		private void CalculatePiTask()
		{
			// TODO:
		}
		#endregion Methods

		#region Event Handlers
		/// <summary>
		/// Demonstrates Paralel.ForEach
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void parallelGoButton_Click(object sender, EventArgs e)
		{
			// TODO:
		}

		/// <summary>
		/// Start the pi calculation task
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void taskGoButton_Click(object sender, EventArgs e)
		{
			// TODO:
		}

		private void taskCancelButton_Click(object sender, EventArgs e)
		{
			// TODO:
		}

		#endregion Event Handlers
	}
}
