using MauiTry.Extends;
using MauiTry.Services;

namespace MauiTry.Models {
    public class Lottery : BindableBase {
        
        private readonly IDataService _dataService;

        public Person Person {
            get => _person;
            set => SetProperty(ref _person, value); //変更通知
        }
        private Person _person;

        //使用するクラスを外部から渡す(Dependency Injection)
        public Lottery(IDataService dataService) => _dataService = dataService;

        //抽選するロジック。必ず戻り値は無しにする事。
        public void Execution() {
            var rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            var persons = _dataService.ReadPersons(); //人物リストを取得
            var index = rnd.Next(0, persons.Count); //ランダムで抽選
            Person = persons[index]; //プロパティに代入
        }
    }
}
