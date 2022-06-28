using MauiTry.Extends;
using MauiTry.Services;

namespace MauiTry.Models {
    public class Lottery : BindableBase {
        
        private readonly IDataService _dataService;

        public Person Person {
            get => _person;
            set => SetProperty(ref _person, value);
        }
        private Person _person;

        public Lottery(IDataService dataService) => _dataService = dataService;

        public void Execution() {
            var rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            var persons = _dataService.ReadPersons();
            var index = rnd.Next(0, persons.Count);
            Person = persons[index];
        }
    }
}
