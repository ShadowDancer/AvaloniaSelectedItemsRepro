using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaNoSelectedEventsRepro.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int counter;

        public int Counter { get => counter; set => this.RaiseAndSetIfChanged(ref counter, value); }
    }
}
