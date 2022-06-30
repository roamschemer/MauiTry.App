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

        //使用するクラスを外部から渡す(Dependency Injection)
        public SecondPageViewModel(INavigationService navigationService) {
            //View層のコマンド変更を感知して前ページへ戻る
            NavigateBackCommand = new ReactiveCommand();
            NavigateBackCommand.Subscribe(async _ => await navigationService.NavigateBack());
        }
    }
}
