using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace AvaloniaApplication.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
		private string _greeting;

		public string Greeting
		{
			get { return _greeting; }
			set { this.RaiseAndSetIfChanged(ref _greeting, value); }
		}


	}
}
