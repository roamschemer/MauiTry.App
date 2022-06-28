﻿using MauiTry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTry.Services {

    public interface IDataService {
        public List<Person> ReadPersons();
    }

    public class DataService : IDataService {
        public List<Person> ReadPersons() => 
            new() {
                new () { Name = "放浪軍師", Job = "エンジニア"},
                new () { Name = "夏狂乱", Job = "VAppler"},
                new () { Name = "赤猫お夏", Job = "神"},
                new () { Name = "太照天昼子", Job = "神"},
                new () { Name = "淀ノ蛇麻呂", Job = "神"},
            };
    }
}