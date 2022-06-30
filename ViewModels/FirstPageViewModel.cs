using MauiTry.Models;
using MauiTry.Services;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace MauiTry.ViewModels
{
    public class FirstPageViewModel {
        public ReactiveProperty<Person> Person { get; }
        public ReactiveCommand LotteryCommand { get; }
        public ReactiveCommand NextPageNavigationCommand { get; }
        public FirstPageViewModel(INavigationService navigationService, Lottery lottery) {
            this.Person = lottery.ObserveProperty(x => x.Person).ToReactiveProperty();
            LotteryCommand = new ReactiveCommand();
            LotteryCommand.Subscribe(_ => lottery.Execution());
            NextPageNavigationCommand = new ReactiveCommand();
            NextPageNavigationCommand.Subscribe(async _ => await navigationService.NavigateToSecondPage());
        }
    }
}
