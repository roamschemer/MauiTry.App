using MauiTry.Extends;
using MauiTry.Models;
using MauiTry.Services;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace MauiTry.ViewModels
{
    public class FirstPageViewModel {
        public ReactiveProperty<string> Name { get; }
        public ReactiveCommand LotteryCommand { get; }
        public ReactiveCommand NextPageNavigationCommand { get; }
        public FirstPageViewModel(INavigationService navigationService, Person person) {
            this.Name = person.ObserveProperty(x => x.Name).ToReactiveProperty();
            LotteryCommand = new ReactiveCommand();
            LotteryCommand.Subscribe(_ => person.Lottery());
            NextPageNavigationCommand = new ReactiveCommand();
            NextPageNavigationCommand.Subscribe(async _ => await navigationService.NavigateToSecondPage());
        }
    }
}
