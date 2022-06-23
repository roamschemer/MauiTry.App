using MauiTry.Services;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTry.ViewModels {
    public class SecondPageViewModel {
        public ReactiveCommand NavigateBackCommand { get; }
        public SecondPageViewModel(INavigationService navigationService) {
            NavigateBackCommand = new ReactiveCommand();
            NavigateBackCommand.Subscribe(async _ => await navigationService.NavigateBack());
        }
    }
}
