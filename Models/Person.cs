using MauiTry.Extends;
using MauiTry.Services;

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

        public string Job {
            get => _job;
            set => SetProperty(ref _job, value);
        }
        private string _job;
    }
}
