namespace LciViewer
{
	using System.Windows;
	using System.Windows.Threading;

	using Ecng.Localization;

	using StockSharp.Localization;

	public partial class App
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			LocalizedStrings.ActiveLanguage = Languages.Russian;
			base.OnStartup(e);
		}

		private void ApplicationDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			MessageBox.Show(MainWindow, e.Exception.ToString());
			e.Handled = true;
		}
	}
}