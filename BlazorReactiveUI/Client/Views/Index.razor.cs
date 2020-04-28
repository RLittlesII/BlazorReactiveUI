using BlazorReactiveUI.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace BlazorReactiveUI.Client.Views
{
    public partial class Index
    {
        public Index()
        {
            ViewModel = new IndexViewModel();

            Observable.Interval(TimeSpan.FromSeconds(10)).Subscribe(_ => ViewModel = new IndexViewModel());
        }
    }
}
