using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Sockets.Plugin;

namespace ExampleSocket
{
	public class ExampleTcpServer
	{
		private TcpSocketListener server;

		public ExampleTcpServer()
		{
			
		}

	 	public Task initialise()
		{
			return Task.Factory.StartNew(() => initialiseSocket());
		}

		private void initialiseSocket()
		{
			this.server = new TcpSocketListener();
			Task t = server.StartListeningAsync(1200);

			t.Wait();
			Debug.WriteLine("ExampleTcpServer started");
		}
	}
}
