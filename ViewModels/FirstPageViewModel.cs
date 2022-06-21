using MauiTry.Extends;
using MauiTry.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace MauiTry.ViewModels
{
    internal class FirstPageViewModel
    {
        public ReactiveProperty<string> Name { get; }
        public ReactiveCommand LotteryCommand { get; }

        public FirstPageViewModel(INavigation navigation, Person person)
        {
            this.Name = person.ObserveProperty(x => x.Name).ToReactiveProperty();
            LotteryCommand = new ReactiveCommand();
            LotteryCommand.Subscribe(_ => person.Lottery());
        }
    }
}
