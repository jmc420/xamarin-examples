using Xamarin.Forms;
using System.Threading.Tasks;

namespace ExampleSocket
{
	public partial class ExampleSocketPage : ContentPage
	{
		private ExampleTcpServer exampleTcpServer;

		public ExampleSocketPage()
		{
			InitializeComponent();

			this.exampleTcpServer = new ExampleTcpServer();

			Task t = this.exampleTcpServer.initialise();

			t.Wait();

			this.label.Text = "Socket connected";
		}
	}
}
