using aa = Android.App;
using ac = Android.Content;
using ao = Android.OS;
using ar = Android.Runtime;
using av = Android.Views;
using aw = Android.Widget;
using ag = Android.Graphics;

namespace Eto.Android.Drawing
{
	public abstract class BrushHandler
	{
		public abstract ag.Paint GetPaint(Brush brush);
	}
}