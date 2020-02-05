using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ArmFrontEnd
{
	public partial class Form1 : Form
	{
		private CommandDispatcher commDispatch = new CommandDispatcher();

		private byte ledMode { get; set; }
		private short ledPalette { get; set; }
		public BindingList<FormPalette> Palettes { get; set; }

		public FormPalette EditorPalette { get; set; }

		public BindingSource PaletteBindingSource { get; set; }
		public BindingSource SelectedEntrySource { get; set; }


		public Form1()
		{
			InitializeComponent();
			commDispatch.DataReceived += SerialPort_DataReceived;

			ledModeCB.Text = "Confetti Palette";

			Palettes = new BindingList<FormPalette>();
			EditorPalette = new FormPalette();
			EditorPalette.Entries.Add(new PaletteEntry());

			/*Palettes.Add(new FormPalette()
			{
				Name = "Default",
				Entries = { 
                    new PaletteEntry() { Step = 0, R = 255 }, 
                    //new PaletteEntry() { Step = 64, G = 255 }, 
                    new PaletteEntry() { Step = 255, R = 255, G = 255, B = 255 } 
                }
			});

			/*Palettes = new BindingList<FormPalette>() {
				new FormPalette()
				{
					Name = "",
					Entries =
					{

					}
				},
			};*/

			Palettes = PaletteHelper.BuiltInPalettes();

			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = Palettes;
			ledPaletteCB.DataSource = bindingSource;

			BindingSource selectedEntrySource = new BindingSource();
			selectedEntrySource.DataSource = bindingSource;
			selectedEntrySource.DataMember = "Entries";
			paletteEntriesLB.DataSource = selectedEntrySource;
			paletteEntriesLB.DisplayMember = "Label";
			selectedEntrySource.CurrentItemChanged += SelectedEntrySource_CurrentItemChanged;

			PaletteBindingSource = bindingSource;
			SelectedEntrySource = selectedEntrySource;

			pStepUD.DataBindings.Add(new Binding("Value", selectedEntrySource, "Step",false,DataSourceUpdateMode.OnPropertyChanged));
			pRUD.DataBindings.Add(new Binding("Value", selectedEntrySource, "R",false,DataSourceUpdateMode.OnPropertyChanged));
			pGUD.DataBindings.Add(new Binding("Value", selectedEntrySource, "G", false, DataSourceUpdateMode.OnPropertyChanged));
			pBUD.DataBindings.Add(new Binding("Value", selectedEntrySource, "B", false, DataSourceUpdateMode.OnPropertyChanged));
			pNameTB.DataBindings.Add(new Binding("Text", bindingSource, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
		}

		private void SelectedEntrySource_CurrentItemChanged(object sender, EventArgs e)
		{
			currentColorP.BackColor = Color.FromArgb((int)pRUD.Value, (int)pGUD.Value, (int)pBUD.Value);
			gradientP.Invalidate();
		}

		private void sendB_Click(object sender, EventArgs e)
		{
			byte opCode;
			if (Byte.TryParse(opCodeTB.Text, out opCode))
			{
				FormCommand comm = new FormCommand(parametersTB.Text, opCode);
				commDispatch.Dispatch(comm);
			}

		}

		private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			var serialPort = commDispatch.SerialPort;
			while (serialPort.BytesToRead > 0)
			{
				string receivedMessage = serialPort.ReadLine();
				if (consoleTB.InvokeRequired)
				{
					consoleTB.Invoke(new MethodInvoker(delegate
					{
						consoleTB.Text += $"<{DateTime.Now.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.SortableDateTimePattern)}> {receivedMessage}\r\n";
						ScrollToEnd(consoleTB);
					}));
				}
				else
				{
					consoleTB.Text += $"<{DateTime.Now.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.SortableDateTimePattern)}> {receivedMessage}\r\n";
					ScrollToEnd(consoleTB);
				}
			}
		}

		private void ScrollToEnd(TextBox tb)
		{
			tb.Select(tb.Text.Length - 1, 0);
			tb.ScrollToCaret();
		}

		private void Send_Click(object sender, EventArgs e)
		{
			commDispatch.SerialPort.Write(rawCommandTB.Text);
		}

		private void echoB_Click(object sender, EventArgs e)
		{
			EchoCommand comm = new EchoCommand()
			{
				Message = echoTB.Text
			};
			commDispatch.Dispatch(comm);
		}

		private void servoB_Click(object sender, EventArgs e)
		{
			byte servoNum = Convert.ToByte(servoNumTB.Text);
			byte position = Convert.ToByte(servoPosTB.Text);

			ServoCommand comm = new ServoCommand()
			{
				ServoNum = servoNum,
				Position = position
			};
			commDispatch.Dispatch(comm);
		}

		private void ledB_Click(object sender, EventArgs e)
		{
			byte mode = Convert.ToByte(ledModeCB.SelectedIndex);
			byte delay = Convert.ToByte(ledSpeedUD.Value);
			ushort palette = Convert.ToUInt16(ledPaletteCB.SelectedIndex);

			LedCustomCommand comm = new LedCustomCommand()
			{
				Mode = mode,
				Delay = delay,
				Palette = ((FormPalette)ledPaletteCB.SelectedItem).Entries.ToArray()

			};

			commDispatch.Dispatch(comm);
		}

		private void ledOnB_Click(object sender, EventArgs e)
		{
			commDispatch.Dispatch(new LedPowerCommand() { IsPowered = true });
		}

		private void ledOffB_Click(object sender, EventArgs e)
		{
			commDispatch.Dispatch(new LedPowerCommand() { IsPowered = false });
		}

		private void addColorB_Click(object sender, EventArgs e)
		{
			((FormPalette)ledPaletteCB.SelectedItem).Entries.Add(new PaletteEntry());
		}

		private void savePaletteB_Click(object sender, EventArgs e)
		{
			var p = new FormPalette();
			Palettes.Add(p);
			//ledPaletteCB.SelectedItem = p;
		}

		private void ledColorSelectB_Click(object sender, EventArgs e)
		{
			var result = ledColorPicker.ShowDialog();
			if(result == DialogResult.OK || result == DialogResult.Yes)
			{
				var color = ledColorPicker.Color;
				/*PaletteEntry selEntry = (PaletteEntry)SelectedEntrySource.Current;
				selEntry.R = color.R;
				selEntry.G = color.G;
				selEntry.B = color.B;*/
				pRUD.Value = color.R;
				pGUD.Value = color.G;
				pBUD.Value = color.B;
			}
		}

		private void gradientP_Paint(object sender, PaintEventArgs e)
		{
			FormPalette currPalette = (FormPalette)PaletteBindingSource.Current;

			LinearGradientBrush gradBrush = /*new LinearGradientBrush(new Point(0, 0), new Point(1f, 0), Color.Black, Color.Black);//*/ new LinearGradientBrush(e.ClipRectangle, Color.Black, Color.White, 0, false);

			gradBrush.InterpolationColors = new ColorBlend()
			{
				Positions = currPalette.Entries.Select((PaletteEntry entry, int i) => { return entry.Step / 255f; }).ToArray(),
				Colors = currPalette.Entries.Select((PaletteEntry entry) => { return entry.Color; }).ToArray()
			};

			e.Graphics.FillRectangle(gradBrush, e.ClipRectangle);
			//e.Graphics.DrawLine(new Pen(Color.Azure), 0, 0, 500, 64);
		}
	}

	public class FormCommand : Command
	{
		private string parameters;

		public FormCommand(string parameters, byte opCode) : base(opCode) { this.parameters = parameters; }
		public override byte[] ProvideParametersForDispatch()
		{
			return this.parameters.Select((char character) => (byte)character).ToArray();
		}
	}

	public class FormPalette
	{
		public string Name { get; set; }
		public BindingList<PaletteEntry> Entries { get; set; }

		public FormPalette()
		{
			Entries = new BindingList<PaletteEntry>();
			Name = "";
		}
	}
}
