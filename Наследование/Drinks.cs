using System;
using System.Collections.Generic;
using System.Drawing;

namespace Наследование
{
    public  class Drink
    {
        public double volume = 0;
        public string name;
        public ushort cost;
        public virtual Image getImage()
        {
            return Properties.Resources.Juice;
        }
        public virtual string getLableText()
        {
            return "Привет, Братик!";
        }
        public virtual string getInfo()
        {
            string str = string.Format($"{volume}");
            return str;
        }
        public virtual Dictionary<string, string> InfoToField()
        {
            var info = new Dictionary<string, string>(5);
            info.Add("name", name);
            info.Add("volume", string.Format($"{volume}"));
            info.Add("cost", string.Format($"{cost}"));
            return info;
        }
        public static Random rnd = new Random();
    }
    public enum fruits
    {
        apple, orange, multifruts, tomatos
    }
    public class Juice : Drink
    {
        private readonly string[] juiceName = { "Добрый", "J7", "Сады придония" }; 
        public override Image getImage()
        {
            return Properties.Resources.Juice;
        }
        public override string getLableText()
        {
            return "Твой сок, Братик!";
        }
        public fruits fruit = fruits.apple;
        public bool pulp = false;
        public Juice()
        {
            int i = rnd.Next(0, juiceName.Length);
            name = juiceName[i];
            cost = (ushort)rnd.Next(0, 500);
            volume = ((500 + rnd.Next(1500)) / 1000.0);
            pulp = rnd.Next(2) == 0;
            fruit = (fruits)rnd.Next(4);
        }
        public Juice(double volume, fruits f, bool pulp, string name, ushort cost)
        {
            base.volume = volume / 1000;
            base.name = name;
            this.pulp = pulp;
            fruit = f;
            base.cost = cost;
        }
        public Juice(string name, string volume, string fruit, string pulp, string cost)
        {
            this.name = name;
            base.volume = Convert.ToDouble(volume.Replace(" л", ""));
            switch (fruit) {
                case "Яблоко":
                    this.fruit = fruits.apple;
                    break;
                case "Мультифрукт":
                    this.fruit = fruits.multifruts;
                    break;
                case "Апельсин":
                    this.fruit = fruits.orange;
                    break;
                case "Томат":
                    this.fruit = fruits.tomatos;
                    break;
            }
            this.pulp = pulp == "есть" ? true : false;
            base.cost = ushort.Parse(cost);
        }
        public override Dictionary<string, string> InfoToField()
        {
            var info = base.InfoToField();
            switch (fruit)
            {
                case fruits.apple:
                    info.Add("type", "Яблоко");
                    break;
                case fruits.multifruts:
                    info.Add("type", "Мультифрукт");
                    break;
                case fruits.orange:
                    info.Add("type", "Апельсин");
                    break;
                case fruits.tomatos:
                    info.Add("type", "Томат");
                    break;
            }
            if (pulp)
            {
                info.Add("pulp", "есть");
            }
            else
            {
                info.Add("pulp", "нет");
            }
            return info;
        }
        public override string getInfo()
        {
            var info = InfoToField();
            var str = $"Я {info["name"]}";
            str+= $"\nОбъем: {info["volume"]} л";
            str += $"\nТип: {info["type"]}";
            str += $"\nМякоть: {info["pulp"]}";
            str+= $"\nСтоимость: {info["cost"]}";
            return str;
        }
        public override bool Equals(object obj)
        {
            var that = obj as Juice;
            if (that == null)
            {
                return false;
            }
            if(this.name == that.name && this.pulp == that.pulp &&
                this.volume == that.volume && this.fruit == that.fruit &&
                this.cost == that.cost)
            {
                return true;
            }
            return false;
        }
    }
    public enum sodaType
    {
        tarragon, cocaCola, pepsi, fanta
    }
    public class Soda : Drink
    {
        private readonly string[] sodaName = { "Кока кола", "Дары сибири", "Лечебный" };
        public override Image getImage()
        {
            return Properties.Resources.Soda;
        }
        public override string getLableText()
        {
            return "Твоя газировка, Братик!";
        }
        public sodaType soda = sodaType.cocaCola;
        public int bubleCount = 0;
        public Soda()
        {
            int i = rnd.Next(0, sodaName.Length);
            name = sodaName[i];
            volume = ((500 + rnd.Next(1500)) / 1000.0);
            bubleCount = rnd.Next(10000);
            soda = (sodaType)rnd.Next(4);
            cost = (ushort)rnd.Next(0, 200);
        }
        public Soda(string name, string volume, string st, string bubleCount, string cost)
        {
            this.name = name;
            base.volume = Convert.ToDouble(volume.Replace(" л", ""));
            switch (st)
            {
                case "Кока-кола":
                    this.soda = sodaType.cocaCola;
                    break;
                case "Фанта":
                    this.soda = sodaType.fanta;
                    break;
                case "Пепси":
                    this.soda = sodaType.pepsi;
                    break;
                case "Тархун":
                    this.soda = sodaType.tarragon;
                    break;
            }
            this.bubleCount = int.Parse(bubleCount);
            base.cost = ushort.Parse(cost);
        }
        public Soda(double volume, int bubleCount, sodaType st, string name, ushort cost)
        {
            base.volume = volume/1000;
            base.name = name;
            this.bubleCount = bubleCount;
            soda = st;
            base.cost = cost;
        }
        public override Dictionary<string, string> InfoToField()
        {
            var info = base.InfoToField();
            switch (soda)
            {
                case sodaType.cocaCola:
                    info.Add("type", "Кока-кола");
                    break;
                case sodaType.fanta:
                    info.Add("type", "Фанта");
                    break;
                case sodaType.pepsi:
                    info.Add("type", "Пепси");
                    break;
                case sodaType.tarragon:
                    info.Add("type", "Тархун");
                    break;
            }
            info.Add("count", string.Format($"{bubleCount}"));
            return info;
        }
        public override string getInfo()
        {
            var info = InfoToField();
            var str = $"Я {info["name"]}";
            str += $"\nОбъем: { info["volume"]}";
            str += $"\nТип: {info["type"]}";
            str += $"\nКоличесво пузырков:{info["count"]}";
            str += $"\nСтоимость: {info["cost"]}";
            return str;
        }
        public override bool Equals(object obj)
        {
            var that = obj as Soda;
            if (that == null)
            {
                return false;
            }
            if (this.name == that.name && this.bubleCount == that.bubleCount &&
                this.volume == that.volume && this.soda == that.soda &&
                this.cost == that.cost)
            {
                return true;
            }
            return false;
        }
    }
    public enum alcoholType
    {
        whiskey, vodka, beer, gin
    }
    public class Alcohol : Drink
    {
        private readonly string[] nameAlcohol = { "Мягкая", "Балтика", "Green baboon" }; 
        public override Image getImage()
        {
            return Properties.Resources.Alcohol;
        }
        public override string getLableText()
        {
            return "Твой алкоголь, Братик!";
        }
        public int fortress = 0;
        public alcoholType type = alcoholType.beer;
        public Alcohol()
        {
            int i = rnd.Next(0, nameAlcohol.Length);
            name = nameAlcohol[i];
            volume = ((500 + rnd.Next(1500)) / 1000.0);
            fortress = rnd.Next(1,50);
            type = (alcoholType)rnd.Next(4);
            cost = (ushort)rnd.Next(0, 10000);
        }
        public Alcohol(double volume, int fortress, alcoholType at, string name, ushort cost)
        {
            base.volume = volume/1000;
            base.name = name;
            this.fortress = fortress;
            type = at;
            base.cost = cost;
        }
        public Alcohol(string name, string volume, string at, string fortress, string cost)
        {
            this.name = name;
            base.volume = Convert.ToDouble(volume.Replace(" л", ""));
            switch (at)
            {
                case "Пиво":
                    this.type = alcoholType.beer;
                    break;
                case "Джин":
                    this.type = alcoholType.gin;
                    break;
                case "Водка":
                    this.type = alcoholType.vodka;
                    break;
                case "Виски":
                    this.type = alcoholType.whiskey;
                    break;
            }
            this.fortress = int.Parse(fortress);
            base.cost = ushort.Parse(cost);
        }
        public override Dictionary<string, string> InfoToField()
        {
            var info = base.InfoToField();
            switch (type)
            {
                case alcoholType.beer:
                    info.Add("type", "Пиво");
                    break;
                case alcoholType.gin:
                    info.Add ("type", "Джин");
                    break;
                case alcoholType.vodka:
                    info.Add ("type", "Водка");
                    break;
                case alcoholType.whiskey:
                    info.Add("type", "Виски");
                    break;
            }
            info.Add ("fortress", $"{fortress}");
            return info;
        }
        public override string getInfo()
        {
            var info = InfoToField();
            var str = $"Я {info["name"]}";
            str += $"\nОбъем: { info["volume"]}";
            str += $"\nТип: {info["type"]}";
            str += $"\nКрепость: {info["fortress"]}";
            str += $"\nСтоимость: {info["cost"]}";
            return str;
        }
        public override bool Equals(object obj)
        {
            var that = obj as Alcohol;
            if (that == null)
            {
                return false;
            }
            if (this.name == that.name && this.fortress == that.fortress &&
                this.volume == that.volume && this.type == that.type &&
                this.cost == that.cost)
            {
                return true;
            }
            return false;
        }
    }
}