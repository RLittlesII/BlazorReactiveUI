using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace BlazorReactiveUI.Client.ViewModels
{
    public class IndexViewModel : ReactiveObject
    {
        private readonly ObservableAsPropertyHelper<long> _foo;
        private readonly ObservableAsPropertyHelper<long> _bar;

        public IndexViewModel()
        {
            _foo = Observable
                .Interval(new TimeSpan(0, 0, 1))
                .ToProperty(this, x => x.Foo, 0);

            _bar = Observable
                .Interval(new TimeSpan(0, 0, 3))
                .ToProperty(this, x => x.Bar, 0);
        }

        public long Foo => _foo.Value;
        
        public long Bar => _bar.Value;
    }
}
