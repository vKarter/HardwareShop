namespace HardwareShop.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<HardwareShop.Database.HSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HSDbContext context)
        {
            context.Customers.AddOrUpdate(x => x.Id,
                new Entities.Customer()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Karol",
                    LastName = "Kowalski",
                    Email = "karol.kow@gmail.com"
                },
                new Entities.Customer()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Maciek",
                    LastName = "Nowarski",
                    Email = "maciek.nowa@gmail.com"
                },
                new Entities.Customer()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Marta",
                    LastName = "Sora",
                    Email = "marta.sor@gmail.com"
                });

            context.OrderStatuses.AddOrUpdate(x => x.Name,
                new Entities.OrderStatus() { Name = "Nowy" },
                new Entities.OrderStatus() { Name = "W trakcie realizacji" },
                new Entities.OrderStatus() { Name = "Dostarczony" },
                new Entities.OrderStatus() { Name = "Zrealizowany" }
                );

            context.Products.AddOrUpdate(x => x.Name,
                new Entities.Product() { Name = "Dell Inspiron 5570", Type = "Laptop", Description = "Tw�j nowy komputer powinien pozosta� Twoim ulubionym przez wiele lat. Dlatego firma Dell przetestowa�a niezawodno�� dzia�ania ka�dego notebooka Inspiron nie tylko w typowych miejscach, ale te� w bardziej wymagaj�cym otoczeniu." },
                new Entities.Product() { Name = "MSI GP72MVR", Type = "Laptop", Description = "Stw�rz idealne �rodowisko do mocnego gamingu i przyjemnej rozrywki multimedialnej. Matrix Display wspiera 2 zewn�trzne monitory, mog�ce pracowa� jednocze�nie z ekranem notebooka. Dzi�ki temu rozszerzysz obraz w grze i zwi�kszysz pole widzenia, co prze�o�y si� na o wiele lepsze wra�enia podczas rozgrywki." },
                new Entities.Product() { Name = "iiyama X2483HSU", Type = "Monitor", Description = "ProLite X2483HSU-B2 to 24-calowy monitor FullHD (1920x1080 pikseli) z pod�wietlaniem LED wyposa�ony w matryc� AMVA oferuj�c� doskona�e odwzorowanie kolor�w (24-bit True Colour). Wyj�tkowo szerokie k�ty widzenia - 178 stopni w pionie i w poziomie oraz bardzo wysokie wsp�czynniki kontrastu 3000:1 (kontrast typowy) i 12 000 000 : 1 (kontrast dynamiczny ACR) w po��czeniu z szybkim, czasem reakcji i wysok� jasno�ci� zapewniaj� mu znakomit� wydajno�� w takich zastosowaniach jak fotografia i obr�bka graficzna." },
                new Entities.Product() { Name = "TP-Link Neffos X1", Type = "Smartphone", Description = "Szary TP-Link Neffos X1 Lite wyr�nia si� wyj�tkowo lekk� i dopracowan� konstrukcj�. Smuk�y profil u�atwia obs�ug� jedn� r�k�, a profilowane szk�o ekranu 5 nadaje smartfonowi eleganckiego wygl�du.Neffos X1 Lite zachwyci Ci� r�wnie� szybko�ci� dzia�ania, doskona�ym aparatem 13 Mpix oraz wielofunkcyjnym czytnikiem linii papilarnych." },
                new Entities.Product() { Name = "Navman 5000", Type = "GPS", Description = "Navman 5000 LM oferuje bezterminow� aktualizacj� map, tak aby� nigdy wi�cej nie musia� martwi� si� o nowe drogi i mapy. Nowe ulice, nowe adresy? Navman 5000 LM poprowadzi Ci� do celu." },
                new Entities.Product() { Name = "Microsoft Xbox One S 500GB", Type = "Konsola", Description = "estaw Xbox One S Forza Horizon 3 Hot Wheels (500GB) z pe�n� wersj� ulubionej przez graczy gry wy�cigowej Forza Horizon 3 wraz z najlepiej sprzedaj�cym si� dodatkiem Hot Wheels oraz bezprzewodowym kontrolerem Xbox. Prowad� ponad 350 modeli najlepszych aut, odkrywaj tereny Australii oraz �cigaj si� z innymi graczami. Poznaj najlepiej ocenian� i najlepiej sprzedaj�c� si� seri� gier tej generacji12 na jedynej konsoli z odtwarzaczem Blu-ray 4K, przesy�aniem strumieniowym w jako�ci 4K oraz technologi� High Dynamic Range." },
                new Entities.Product() { Name = "Creative Live! Cam Sync HD", Type = "Kamery", Description = "unkcja �Plug & Chat� pozwala na prowadzenie rozm�w bez konieczno�ci instalacji program�w z p�yty CD. Nagrywaj i udost�pniaj wideo w rozdzielczo�ci HD 720p w serwisach Facebook i YouTube dzi�ki oprogramowaniu Live! Central 3 Lite" }
                );

        }
    }
}
