namespace SmartphoneShop.Migrations
{
    using SmartphoneShop.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SmartphoneShop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SmartphoneShop.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Shops.AddOrUpdate(x => x.Id,
                new Shop() { Id = 1, Name = "Mobile world", City = "Novi Sad", Adress = "Bulevar Oslobodjenja", Postcode = 21000, Email = "mobileshop@gmail.com", Telephone = "0605006000" }
                );

            context.Smartphones.AddOrUpdate(x => x.Id,
                new Smartphone()
                {
                    Id = 1,
                    Brand = "HTC",
                    Model = "10",
                    Chipset = "Qualcomm 820",
                    OS = "Android 8.0",
                    Ram = 4,
                    ScreenDiagonal = 5.2m,
                    BatteryCapacity = 3000,
                    BackCamera = 12,
                    FrontCamera = 5,
                    Price = 250,
                    ShopId = 1

                },
                new Smartphone()
                {
                    Id = 2,
                    Brand = "HTC",
                    Model = "M8",
                    Chipset = "Qualcomm 800",
                    OS = "Android 6.0",
                    Ram = 3,
                    ScreenDiagonal = 5,
                    BatteryCapacity = 2600,
                    BackCamera = 4.3m,
                    FrontCamera = 5,
                    Price = 120,
                    ShopId = 1
                },
                new Smartphone()
                {
                    Id = 3,
                    Brand = "Samsung",
                    Model = "S8",
                    Chipset = "Exynos 8895",
                    OS = "Android 8.0",
                    Ram = 4,
                    ScreenDiagonal = 5.8m,
                    BatteryCapacity = 3000,
                    BackCamera = 12,
                    FrontCamera = 8,
                    Price = 380,
                    ShopId = 1
                },
                new Smartphone()
                {
                    Id = 4,
                    Brand = "Samsung",
                    Model = "S9",
                    Chipset = "Exynos 8895",
                    OS = "Android 8.0",
                    Ram = 4,
                    ScreenDiagonal = 5.8m,
                    BatteryCapacity = 3000,
                    BackCamera = 12,
                    FrontCamera = 5,
                    Price = 500,
                    ShopId = 1
                },
                new Smartphone()
                {
                    Id = 5,
                    Brand = "Huawei",
                    Model = "Mate 20 Pro",
                    Chipset = "HiSilicon Kirin 980",
                    OS = "Android 9.0",
                    Ram = 8,
                    ScreenDiagonal = 6.39m,
                    BatteryCapacity = 4200,
                    BackCamera = 40,
                    FrontCamera = 24,
                    Price = 880,
                    ShopId = 1
                },
                new Smartphone()
                {
                    Id = 6,
                    Brand = "Honor",
                    Model = "Play",
                    Chipset = "HiSilicon Kirin 970",
                    OS = "Android 8.0",
                    Ram = 4,
                    ScreenDiagonal = 6.3m,
                    BatteryCapacity = 3750,
                    BackCamera = 16,
                    FrontCamera = 16,
                    Price = 300,
                    ShopId = 1
                },
                new Smartphone()
                {
                    Id = 7,
                    Brand = "Honor",
                    Model = "10",
                    Chipset = "HiSilicon Kirin 970",
                    OS = "Android 8.0",
                    Ram = 3,
                    ScreenDiagonal = 5,
                    BatteryCapacity = 3400,
                    BackCamera = 24,
                    FrontCamera = 24,
                    Price = 320,
                    ShopId = 1
                },
                new Smartphone()
                {
                    Id = 8,
                    Brand = "Apple",
                    Model = "iPhone X",
                    Chipset = "Apple A11 Bionic",
                    OS = "iOS 13",
                    Ram = 3,
                    ScreenDiagonal = 5.8m,
                    BatteryCapacity = 2716,
                    BackCamera = 12,
                    FrontCamera = 7,
                    Price = 1000,
                    ShopId = 1
                });
        }
    }
}
