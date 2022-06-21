using MauiTry.Extends;

namespace MauiTry.Models
{
    public class Person : BindableBase
    {
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _name;

        private readonly string[] _nameList = new string[] { "放浪軍師", "夏狂乱", "赤猫お夏", "太照天昼子", "淀ノ蛇麻呂" };

        public void Lottery()
        {
            var rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            var index = rnd.Next(0, _nameList.Length);
            Name = _nameList[index];
        }
    }
}
