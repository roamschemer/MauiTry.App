using MauiTry.Models;

namespace MauiTry.Services {

    public interface IDataService {
        public List<Person> ReadPersons();
    }

    //データクラス。本来ならデータベースとかファイルとかAPIとかから取得になるが今回は面倒なので直書き。
    public class DataService : IDataService {
        public List<Person> ReadPersons() => 
            new() {
                new () { Name = "放浪軍師", Job = "エンジニア"},
                new () { Name = "夏狂乱", Job = "VAppler"},
                new () { Name = "赤猫お夏", Job = "火神"},
                new () { Name = "太照天昼子", Job = "火神"},
                new () { Name = "淀ノ蛇麻呂", Job = "水神"},
            };
    }
}
