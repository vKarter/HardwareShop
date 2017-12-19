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
                new Entities.Product() { Name = "Dell Inspiron 5570", Type = "Laptop", Description = "Twój nowy komputer powinien pozostaæ Twoim ulubionym przez wiele lat. Dlatego firma Dell przetestowa³a niezawodnoœæ dzia³ania ka¿dego notebooka Inspiron nie tylko w typowych miejscach, ale te¿ w bardziej wymagaj¹cym otoczeniu." },
                new Entities.Product() { Name = "MSI GP72MVR", Type = "Laptop", Description = "Stwórz idealne œrodowisko do mocnego gamingu i przyjemnej rozrywki multimedialnej. Matrix Display wspiera 2 zewnêtrzne monitory, mog¹ce pracowaæ jednoczeœnie z ekranem notebooka. Dziêki temu rozszerzysz obraz w grze i zwiêkszysz pole widzenia, co prze³o¿y siê na o wiele lepsze wra¿enia podczas rozgrywki." },
                new Entities.Product() { Name = "iiyama X2483HSU", Type = "Monitor", Description = "ProLite X2483HSU-B2 to 24-calowy monitor FullHD (1920x1080 pikseli) z podœwietlaniem LED wyposa¿ony w matrycê AMVA oferuj¹c¹ doskona³e odwzorowanie kolorów (24-bit True Colour). Wyj¹tkowo szerokie k¹ty widzenia - 178 stopni w pionie i w poziomie oraz bardzo wysokie wspó³czynniki kontrastu 3000:1 (kontrast typowy) i 12 000 000 : 1 (kontrast dynamiczny ACR) w po³¹czeniu z szybkim, czasem reakcji i wysok¹ jasnoœci¹ zapewniaj¹ mu znakomit¹ wydajnoœæ w takich zastosowaniach jak fotografia i obróbka graficzna." },
                new Entities.Product() { Name = "TP-Link Neffos X1", Type = "Smartphone", Description = "Szary TP-Link Neffos X1 Lite wyró¿nia siê wyj¹tkowo lekk¹ i dopracowan¹ konstrukcj¹. Smuk³y profil u³atwia obs³ugê jedn¹ rêk¹, a profilowane szk³o ekranu 5 nadaje smartfonowi eleganckiego wygl¹du.Neffos X1 Lite zachwyci Ciê równie¿ szybkoœci¹ dzia³ania, doskona³ym aparatem 13 Mpix oraz wielofunkcyjnym czytnikiem linii papilarnych." },
                new Entities.Product() { Name = "Navman 5000", Type = "GPS", Description = "Navman 5000 LM oferuje bezterminow¹ aktualizacjê map, tak abyœ nigdy wiêcej nie musia³ martwiæ siê o nowe drogi i mapy. Nowe ulice, nowe adresy? Navman 5000 LM poprowadzi Ciê do celu." },
                new Entities.Product() { Name = "Microsoft Xbox One S 500GB", Type = "Konsola", Description = "estaw Xbox One S Forza Horizon 3 Hot Wheels (500GB) z pe³n¹ wersj¹ ulubionej przez graczy gry wyœcigowej Forza Horizon 3 wraz z najlepiej sprzedaj¹cym siê dodatkiem Hot Wheels oraz bezprzewodowym kontrolerem Xbox. ProwadŸ ponad 350 modeli najlepszych aut, odkrywaj tereny Australii oraz œcigaj siê z innymi graczami. Poznaj najlepiej ocenian¹ i najlepiej sprzedaj¹c¹ siê seriê gier tej generacji12 na jedynej konsoli z odtwarzaczem Blu-ray 4K, przesy³aniem strumieniowym w jakoœci 4K oraz technologi¹ High Dynamic Range." },
                new Entities.Product() { Name = "Creative Live! Cam Sync HD", Type = "Kamery", Description = "unkcja „Plug & Chat” pozwala na prowadzenie rozmów bez koniecznoœci instalacji programów z p³yty CD. Nagrywaj i udostêpniaj wideo w rozdzielczoœci HD 720p w serwisach Facebook i YouTube dziêki oprogramowaniu Live! Central 3 Lite" }
                );

        }
    }
}
