using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;
using ApiMarvel.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Infrastructure.Persistence;

    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            await context.Database.MigrateAsync();

            if (!await context.Comics.AnyAsync())
            {
                var comics = new List<Comic>
                {
                    new Comic
                     {
                        Id = Guid.Parse("1a227de1-39a1-4d7f-b6f7-d55f003f69b9"),
                        Title = "Vengadores vol 1 57:¡He aquí... la visión!",
                        ImageUrl = "https://static-wikia-nocookie-net.translate.goog/marveldatabase/images/3/31/Avengers_Vol_1_57.jpg/revision/latest?cb=20180909031043&_x_tr_sl=en&_x_tr_tl=es&_x_tr_hl=es&_x_tr_pto=tc",
                        Description = "La Visión entra en la sede de los Vengadores y se acerca a la Avispa, pero esta se cae y se derrumba. Goliat entra corriendo, preguntándose qué ha pasado, y encuentra a la Visión en un montón arrugado en el suelo. Mientras tanto, Hawkeye visita a Natasha y descubre que ha decidido convertirse de nuevo en la Viuda Negra. Recibe una llamada para volver a la mansión. Pantera Negra frustra un robo y también es llamada. Mientras examina a la Visión, vuelve a la vida y ataca de nuevo a los Vengadores. Se calma e informa a los Vengadores de que ha sido enviado por Ultron-5 para destruirlos. Lleva a los Vengadores de vuelta al escondite de Ultron hacia una trampa, pero la propia Visión desafía a Ultron y gana, salvando a los Vengadores.",
                        Author = "Stan Lee",
                        Reference = "WW01",
                        Pages = 210
                    },
                    new Comic
                    {
                        Id = Guid.Parse("2d876f27-bff7-4c85-b3f5-986eeafaf9ab"),
                        Title = "Spawn: Origins Volume 1",
                        ImageUrl = "https://sm.ign.com/t/ign_es/screenshot/b/bspawn-1bb/bspawn-1bbrbrbdrawn-byb-todd-mcfarlanebrbrspawn-1-was-truly_cnze.1080.jpg",
                        Description = "Featuring remastered cover art from creator TODD McFARLANE, SPAWN: ORIGINS, VOL. 1 reprints the stories and artwork that laid the groundwork for the most successful independent comic book ever published, including the introduction Spawn himself, and a number of other memorable and menacing characters. Collects SPAWN #1-6.",
                        Author = "Stan Lee",
                        Reference = "TWD01",
                        Pages = 250
                    },
                    new Comic
                    {
                        Id = Guid.Parse("3b2f2c2b-bb7a-4312-b99e-122b7f2bd503"),
                        Title = "Crisis on Infinite Earths",
                        ImageUrl = "https://sm.ign.com/t/ign_es/screenshot/b/bcrisis-on/bcrisis-on-infinite-earths-7bbrbrbdrawn-byb-george-perezbrbr_brz1.1080.jpg",
                        Description = "Overlooking the universes of the five Earths on a floating asteroid, Alex and Lyla are joined by Pariah, who asks what part the Monitor could have intended him to play in the Crisis. Lyla responds that she has been told the Monitor's plan and knows what part he'll play in the conclusion, representatives of six Earths most these plans: Earth-Two Superman; Earth-One Superman; Uncle Sam from Earth-X; Captain Marvel from Earth-S; and Blue Beetle from Earth-Four. Pariah obliges Lyla by taking them to the merged Earths.",
                        Author = "Marv Wolfman",
                        Reference = "BAT01",
                        Pages = 144
                    },
                    new Comic
                    {
                        Id = Guid.Parse("4d07e8b4-051f-4207-b302-0281b8c7358e"),
                        Title = "TALES OF THE NEW GODS",
                        ImageUrl = "https://static.dc.com/dc/files/default_images/8550_400x600.jpg?w=400",
                        Description = "Don't miss this new volume featuring the greatest New Gods stories by a Who's Who of all-star creators! Recognized as one of Jack Kirby's greatest creations, the New Gods now play an integral role in the DC Universe. Rediscover the classic tales of young Scott Free, Darkseid, Orion and more in this softcover collecting stories from Mister Miracle Special, Jack Kirby's Fourth World #2-20, and Orion #3-4, #6-8, #10, #12, #15, #18-19! Plus, a never-before-published short story by writer Mark Millar with art by Steve Ditko and Mick Gray!",
                        Author = "Jason Aaron",
                        Reference = "THOR01",
                        Pages = 200
                    },
                    new Comic
                    {
                        Id = Guid.Parse("5a7e8b2c-5d9f-4a4a-9b8d-2e6c9d3a1f74"),
                        Title = "Spawn: Renacimiento",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjsIE_hxTMAKsEB6fjvAyV-E6Evq3dsgGmegScql1t67eAp_pIKr8fuTMYbM0UfUB9F9d8Nl9XUphdEaKVVZOyr1fRnCGP-cbANxCh2q3rxUUqcSiGl6zLpe7B41nOV2QWcVFhveeBHXZR4ATR0WuYtTBwk_jFLjavREW28pxlKPS2ASOSITCi_T39xwFU/s617/Violator%20vs%20Badrock%20(0).jpg",
                        Description = "Al Simmons regresa del infierno para convertirse en Spawn y enfrentarse a sus enemigos sobrenaturales.",
                        Author = "Todd McFarlane",
                        Reference = "SPW01",
                        Pages = 240
                    },
                    new Comic
                    {
                        Id = Guid.Parse("7e3b9d2c-8a6f-4f5a-b2c7-d8f9e7a3c1b4"),
                        Title = "Watchmen",
                        ImageUrl = "http://www.untebeoconotronombre.com/images/2009/nick_fury4.jpg",
                        Description = "Una historia oscura y compleja sobre superhéroes en una sociedad al borde de la guerra nuclear.",
                        Author = "Stan Lee",
                        Reference = "WM01",
                        Pages = 416
                    },
                    new Comic
                    {
                        Id = Guid.Parse("7f8db6a3-9f7b-4b8f-a2b0-9c8f9c7dbef5"),
                        Title = "Silver Surfer Vol 1 4: ¡El bueno, el misterioso y el malo!",
                        ImageUrl = "https://i1.whakoom.com/large/30/19/c3f0fedc78054ae6b73f8089b95fecf1.jpg?_gl=1*1ol3eu4*_ga*NTM4OTI1NTc3LjE3Mzk5NDg0OTM.*_ga_7TE1PVSLNM*MTczOTk0ODQ5Mi4xLjAuMTczOTk0ODQ5Mi42MC4wLjA.",
                        Description = "En la lejana y encantada Asgard, perdido en sus siniestros pensamientos, se encuentra Loki, que est\u00e1 enfadado porque Thor continua frustrando sus nefastos planes. \n\u00a0Mientras est\u00e1 all\u00ed, descubre a Silver Surfer y aprende sobre su pasado y su presente. Se da cuenta de que Silver Surfer es alguien a quien podr\u00eda enga\u00f1ar para que cumpla sus \u00f3rdenes. Ansioso por poner en marcha su plan, se apresura a atravesar Asgard y se cruza con los Tres Guerreros. Confiado en su inminente \u00e9xito, se regodea con los tres y les advierte que Thor pronto se ir\u00e1 para siempre. Los Tres Guerreros corren hacia Thor para advertirle, poni\u00e9ndolo en alerta y haciendo que se prepare para la guerra.",
                        Author = "Juan P\u00e9rez",
                        Reference = "REF12345",
                        Pages = 150
                    },
                    new Comic
                    {
                        Id = Guid.Parse("8d0d62f0-7a99-42b2-9b47-f24c7f8f327d"),
                        Title = "Vengadores: La guerra del infinito",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjUI3DGTQMlavlEoR0GDNTSCOsi22Tm6ROOKeMI6Txc6odplzmc7CxRmiWB1gQHNucrAWFfwknYQNk9X1JbuvwIbMinrdaApjEjWMzWohbpmRtJ2NSCrYVdclsVQvEXjUClMDqJdwEMkOZw/s1600/Flash+rebirth.jpg",
                        Description = "Los Vengadores se unen para detener a Thanos en su b\u00fasqueda por las Gemas del Infinito.",
                        Author = "Jim Starlin",
                        Reference = "AVNG01",
                        Pages = 320
                    },
                    new Comic
                    {
                        Id = Guid.Parse("8e2b9d3c-7a6f-4a5b-b2c8-d9f7e3a1c5b4"),
                        Title = "Thor: Dios del Trueno",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgC0PU0c8-fzW52OphKaB7kyDMqOZONGWvvWkLD3vtlcdu5URT839Up_8rev4cf8KJjWQGA1GFwoLxaREn_QXE33S6VxVwohajgcWyzPtRTK6rpDgMhzU_cuUXVE-GcKLb_FBVb8RJbOxWe/s1600/51727-3816-68550-1-superman.jpg",
                        Description = "Thor se enfrenta a Gorr, el Carnicero de Dioses, en una historia \u00e9pica sobre el tiempo y la venganza.",
                        Author = "Jason Aaron",
                        Reference = "TH01",
                        Pages = 224
                    },
                    new Comic
                    {
                        Id = Guid.Parse("9ad29069-bca7-4da2-b24f-32d94a5c5433"),
                        Title = "Flashpoint",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhVyl72LyHzPHiz7FuawLLu2BXHM8GBYYBkYE0wtgBtmdO51WKlfaeMcyxVusSdN8yHMKOhaFQok-N-MdydViYoDx1AL6ulG37EFKR_KDZwFPYLaFurblm-kZALxOEbao81FqdQFeFzy_U1/s1600/portada-91-aquaman.jpg",
                        Description = "Barry Allen, el hombre m\u00e1s r\u00e1pido del mundo, ve c\u00f3mo la realidad cambia cuando se despierta en un mundo alternativo.",
                        Author = "Geoff Johns",
                        Reference = "FLAS01",
                        Pages = 232
                    },
                    new Comic
                    {
                        Id = Guid.Parse("9bc3f4ea-2b39-4f67-a7e2-4f3c5e79d821"),
                        Title = "Daredevil: El hombre sin miedo",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEh85vo_0dJ4oZYClna5JJUuNUsEs7N_kFlpL756Do3tBJVJUVe0Jhk4-JXKiEfoDD-DpZviopPC6X5fB_sblNaVhTURHStizpi5nP3Truv5whw07Tiwi3kxmACuo6JCJizB80SgpTlSMlM7/s1600/2779408-www.jpg",
                        Description = "La historia de origen de Matt Murdock, el abogado ciego que lucha contra el crimen en Hell’s Kitchen.",
                        Author = "Frank Miller",
                        Reference = "DD01",
                        Pages = 192
                    },
                    new Comic
                    {
                        Id = Guid.Parse("a0c44739-b24a-4e74-a6b1-bf39b5679b96"),
                        Title = "Poderosos Vengadores",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgC0PU0c8-fzW52OphKaB7kyDMqOZONGWvvWkLD3vtlcdu5URT839Up_8rev4cf8KJjWQGA1GFwoLxaREn_QXE33S6VxVwohajgcWyzPtRTK6rpDgMhzU_cuUXVE-GcKLb_FBVb8RJbOxWe/s1600/51727-3816-68550-1-superman.jpg",
                        Description = "Thor, Iron Man y el Capit\u00e1n Am\u00e9rica se enfrentan a sus propios demonios y a un enemigo com\u00fan que amenaza el mundo.",
                        Author = "Kurt Busiek",
                        Reference = "PAV01",
                        Pages = 180
                    },
                    new Comic
                    {
                        Id = Guid.Parse("aa524ba2-2671-4a63-8fcb-d0a88e964ef9"),
                        Title = "Justice League: La guerra",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgLh-rkTWz0LDvGwlVe1VQxHTkzNUEi9fZgbpmpbs985TRZZ5XEImj2kZY0BSR895psvHcXZ0w02-YFDmIhT7dRIaMgdsqz6G4XRsxsRvgfHnYz_UcEZa2sf1Tw2gTs6IOZBDlnigof-5zK/s1600/2762802-000.jpg",
                        Description = "La Liga de la Justicia se enfrenta a su primer gran despu\u00e9s, luchando contra una amenaza de otro planeta.",
                        Author = "Geoff Johns",
                        Reference = "JL01",
                        Pages = 248
                    },
                    new Comic
                    {
                        Id = Guid.Parse("ab8f2c4d-7e9a-42b1-b3c7-9d5e3f8a6c21"),
                        Title = "Superman: Hijo Rojo",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgEIHhEWtzpZHOg4tD6Ic_yJAm1Pd1YqsQ3ipUseoREt9gOZ1KYkXREA7d0adLWJWFJovDVWuHhiYVCWcF9l0iHpNLhfdQUlC4LvCp2cBJwjQWv9Tq1cCWvVClXzPrKwjhFM9Zj834PhGZ-/w263-h400/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Una historia alternativa donde Superman aterriza en la Uni\u00f3n Sovi\u00e9tica en lugar de Kansas.",
                        Author = "Mark Millar",
                        Reference = "SUP01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("b66c283f-23ea-432d-a702-80c4206278ae"),
                        Title = "Los 4 Fant\u00e1sticos: El regreso de Galactus",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEg8GDULOA2-bVviviItOLLNTAWPPWf3b6jnXXdrZOHVs8zpXbvP0um_nxPjVqNT_7UW5UAeh1KWy4SPf5cUnG5Qb9zXqURsh1hX6VGWQxZJ8dNkoph7fKHlRVIpk5zK/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25281%2529.jpg",
                        Description = "El regreso de Galactus pone a prueba a los 4 Fantasticos, quienes deben enfrentarse a la amenaza cosmica la destrucci\u00f3n.",
                        Author = "Stan Lee",
                        Reference = "FF01",
                        Pages = 280
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c3a5f9b7-8d2c-42e9-a5f4-7b8c2e9d3f61"),
                        Title = "X-Men: D\u00edas del futuro pasado",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhWFeccvmYcHUsUsUASPjhwA90vgQfczznFXEtMmJNCA91gU2ymOaGJZFBaY6mhkFN9X8Os3qdwW8w7Nj80MNqGIvv4y3fPzy7yOOQAjpP00qY4orZGNRdypvYe6xq2qyW0QKS_3zNtuDo9/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25283%2529.jpg",
                        Description = "Los mutantes enfrentan un futuro devastador en el que deben luchar por sobrevivir contra los Centinelas.",
                        Author = "Chris Claremont",
                        Reference = "XM01",
                        Pages = 144
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9a3b8d7-4e5f-4a2b-9c6d-8f2e7a3c5b1f"),
                        Title = "The Flash: Renacimiento",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhf7XVHH0h9M2CIv-8ry7SKlersxLwPijsE3XsmOD9opaaGf3AWYYT1Yxulb1EtbkLiRtBtlnmRejjBoudZH_i-hLQYm_q2ZwNjcT7cI1OIiuohT9jIcqX-f__o4B_Jtt9mmd0lLMAmPMdhFfwg90ndeg9uegL1wNSTEZo0UbEAV94zL5Rs2n4hRMxj_PY/s621/Violator%20vs%20Badrock%20(0)a.jpg",
                        Description = "Barry Allen regresa de entre los muertos y debe enfrentar las consecuencias de su resurrecci\u00f3n.",
                        Author = "Geoff Johns",
                        Reference = "FL01",
                        Pages = 192
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9b6a963-feb0-44d4-a0b2-ffdcba531fbb"),
                        Title = "Iron Man: Extremis",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjFXT6J_6xXSeWDkqXOxNQGbqb1I09kOTDwlsZng4eUDAYhHJeBowmLCruu1bA5pEBHL3sAw_E1_1x-HkbP6lYblS2C5ptHRll7t6ASeWndaaZ-XvuenV7by30SFveDb_OMrqVAISLBtyz0SVuBcpFw05tGhzxS8Sh1x4hPsLNTVcSZK08BbvUGkJI4GFg/s1518/Youngblood%20%23%2010%20(0).jpg"
                        ,Description = "Tony Stark se enfrenta a la amenaza de Extremis, un virus biotecnol\u00f3gico que podr\u00eda destruirlo.",
                        Author = "Warren Ellis",
                        Reference = "IM01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("cb9f1206-b8c4-4c82-9b39-c0d604489d8b"),
                        Title = "Justice League: La guerra",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgLh-rkTWz0LDvGwlVe1VQxHTkzNUEi9fZgbpmpbs985TRZZ5XEImj2kZY0BSR895psvHcXZ0w02-YFDmIhT7dRIaMgdsqz6G4XRsxsRvgfHnYz_UcEZa2sf1Tw2gTs6IOZBDlnigof-5zK/s1600/2762802-000.jpg",
                        Description = "La Liga de la Justicia se enfrenta a su primer gran despu\u00e9s, luchando contra una amenaza de otro planeta.",
                        Author = "Geoff Johns",
                        Reference = "JL01",
                        Pages = 248
                    },
                    new Comic
                    {
                        Id = Guid.Parse("ab8f2c4d-7e9a-42b1-b3c7-9d5e3f8a6c21"),
                        Title = "Superman: Hijo Rojo",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgEIHhEWtzpZHOg4tD6Ic_yJAm1Pd1YqsQ3ipUseoREt9gOZ1KYkXREA7d0adLWJWFJovDVWuHhiYVCWcF9l0iHpNLhfdQUlC4LvCp2cBJwjQWv9Tq1cCWvVClXzPrKwjhFM9Zj834PhGZ-/w263-h400/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Una historia alternativa donde Superman aterriza en la Uni\u00f3n Sovi\u00e9tica en lugar de Kansas.",
                        Author = "Mark Millar",
                        Reference = "SUP01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("b66c283f-23ea-432d-a702-80c4206278ae"),
                        Title = "Los 4 Fant\u00e1sticos: El regreso de Galactus",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEg8GDULOA2-bVviviItOLLNTAWPPWf3b6jnXXdrZOHVs8zpXbvP0um_nxPjVqNT_7UW5UAeh1KWy4SPf5cUnG5Qb9zXqURsh1hX6VGWQxZJ8dNkoph7fKHlRVIpk5zK/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25281%2529.jpg",
                        Description = "El regreso de Galactus pone a prueba a los 4 Fant\u00e1sticos, quienes deben enfrentarse a la amenaza cosmica destrucci\u00f3n.",
                        Author = "Stan Lee",
                        Reference = "FF01",
                        Pages = 280
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c3a5f9b7-8d2c-42e9-a5f4-7b8c2e9d3f61"),
                        Title = "X-Men: D\u00edas del futuro pasado",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhWFeccvmYcHUsUsUASPjhwA90vgQfczznFXEtMmJNCA91gU2ymOaGJZFBaY6mhkFN9X8Os3qdwW8w7Nj80MNqGIvv4y3fPzy7yOOQAjpP00qY4orZGNRdypvYe6xq2qyW0QKS_3zNtuDo9/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25283%2529.jpg",
                        Description = "Los mutantes enfrentan un futuro devastador en el que deben luchar por sobrevivir contra los Centinelas.",
                        Author = "Chris Claremont",
                        Reference = "XM01",
                        Pages = 144
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9a3b8d7-4e5f-4a2b-9c6d-8f2e7a3c5b1f"),
                        Title = "The Flash: Renacimiento",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhf7XVHH0h9M2CIv-8ry7SKlersxLwPijsE3XsmOD9opaaGf3AWYYT1Yxulb1EtbkLiRtBtlnmRejjBoudZH_i-hLQYm_q2ZwNjcT7cI1OIiuohT9jIcqX-f__o4B_Jtt9mmd0lLMAmPMdhFfwg90ndeg9uegL1wNSTEZo0UbEAV94zL5Rs2n4hRMxj_PY/s621/Violator%20vs%20Badrock%20(0)a.jpg",
                        Description = "Barry Allen regresa de entre los muertos y debe enfrentar las consecuencias de su resurrecci\u00f3n.",
                        Author = "Geoff Johns",
                        Reference = "FL01",
                        Pages = 192
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9b6a963-feb0-44d4-a0b2-ffdcba531fbb"),
                        Title = "Iron Man: Extremis",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjFXT6J_6xXSeWDkqXOxNQGbqb1I09kOTDwlsZng4eUDAYhHJeBowmLCruu1bA5pEBHL3sAw_E1_1x-HkbP6lYblS2C5ptHRll7t6ASeWndaaZ-XvuenV7by30SFveDb_OMrqVAISLBtyz0SVuBcpFw05tGhzxS8Sh1x4hPsLNTVcSZK08BbvUGkJI4GFg/s1518/Youngblood%20%23%2010%20(0).jpg"
                        ,Description = "Tony Stark se enfrenta a la amenaza de Extremis, un virus biotecnol\u00f3gico que podr\u00eda destruirlo.",
                        Author = "Warren Ellis",
                        Reference = "IM01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("cb9f1206-b8c4-4c82-9b39-c0d604489d8b"),
                        Title = "Justice League: La guerra",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgLh-rkTWz0LDvGwlVe1VQxHTkzNUEi9fZgbpmpbs985TRZZ5XEImj2kZY0BSR895psvHcXZ0w02-YFDmIhT7dRIaMgdsqz6G4XRsxsRvgfHnYz_UcEZa2sf1Tw2gTs6IOZBDlnigof-5zK/s1600/2762802-000.jpg",
                        Description = "La Liga de la Justicia se enfrenta a su primer gran despu\u00e9s, luchando contra una amenaza de otro planeta.",
                        Author = "Geoff Johns",
                        Reference = "JL01",
                        Pages = 248
                    },
                    new Comic
                    {
                        Id = Guid.Parse("ab8f2c4d-7e9a-42b1-b3c7-9d5e3f8a6c21"),
                        Title = "Superman: Hijo Rojo",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgEIHhEWtzpZHOg4tD6Ic_yJAm1Pd1YqsQ3ipUseoREt9gOZ1KYkXREA7d0adLWJWFJovDVWuHhiYVCWcF9l0iHpNLhfdQUlC4LvCp2cBJwjQWv9Tq1cCWvVClXzPrKwjhFM9Zj834PhGZ-/w263-h400/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Una historia alternativa donde Superman aterriza en la Uni\u00f3n Sovi\u00e9tica en lugar de Kansas.",
                        Author = "Mark Millar",
                        Reference = "SUP01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("b66c283f-23ea-432d-a702-80c4206278ae"),
                        Title = "Los 4 Fantasticos: El regreso de Galactus",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEg8GDULOA2-bVviviItOLLNTAWPPWf3b6jnXXdrZOHVs8zpXbvP0um_nxPjVqNT_7UW5UAeh1KWy4SPf5cUnG5Qb9zXqURsh1hX6VGWQxZJ8dNkoph7fKHlRVIpk5zK/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25281%2529.jpg",
                        Description = "El regreso de Galactus pone a prueba a los 4 Fant\u00e1sticos, quienes deben enfrentarse a la amenaza cosmicos la destrucción.",
                        Author = "Stan Lee",
                        Reference = "FF01",
                        Pages = 280
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c3a5f9b7-8d2c-42e9-a5f4-7b8c2e9d3f61"),
                        Title = "X-Men: D\u00edas del futuro pasado",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhWFeccvmYcHUsUsUASPjhwA90vgQfczznFXEtMmJNCA91gU2ymOaGJZFBaY6mhkFN9X8Os3qdwW8w7Nj80MNqGIvv4y3fPzy7yOOQAjpP00qY4orZGNRdypvYe6xq2qyW0QKS_3zNtuDo9/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25283%2529.jpg",
                        Description = "Los mutantes enfrentan un futuro devastador en el que deben luchar por sobrevivir contra los Centinelas.",
                        Author = "Chris Claremont",
                        Reference = "XM01",
                        Pages = 144
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9a3b8d7-4e5f-4a2b-9c6d-8f2e7a3c5b1f"),
                        Title = "The Flash: Renacimiento",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhf7XVHH0h9M2CIv-8ry7SKlersxLwPijsE3XsmOD9opaaGf3AWYYT1Yxulb1EtbkLiRtBtlnmRejjBoudZH_i-hLQYm_q2ZwNjcT7cI1OIiuohT9jIcqX-f__o4B_Jtt9mmd0lLMAmPMdhFfwg90ndeg9uegL1wNSTEZo0UbEAV94zL5Rs2n4hRMxj_PY/s621/Violator%20vs%20Badrock%20(0)a.jpg",
                        Description = "Barry Allen regresa de entre los muertos y debe enfrentar las consecuencias de su resurrecci\u00f3n.",
                        Author = "Geoff Johns",
                        Reference = "FL01",
                        Pages = 192
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9b6a963-feb0-44d4-a0b2-ffdcba531fbb"),
                        Title = "Iron Man: Extremis",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjFXT6J_6xXSeWDkqXOxNQGbqb1I09kOTDwlsZng4eUDAYhHJeBowmLCruu1bA5pEBHL3sAw_E1_1x-HkbP6lYblS2C5ptHRll7t6ASeWndaaZ-XvuenV7by30SFveDb_OMrqVAISLBtyz0SVuBcpFw05tGhzxS8Sh1x4hPsLNTVcSZK08BbvUGkJI4GFg/s1518/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Tony Stark se enfrenta a la amenaza de Extremis, un virus biotecnol\u00f3gico que podr\u00eda destruirlo.",
                        Author = "Warren Ellis",
                        Reference = "IM01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("cb9f1206-b8c4-4c82-9b39-c0d604489d8b"),
                        Title = "Justice League: La guerra",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgLh-rkTWz0LDvGwlVe1VQxHTkzNUEi9fZgbpmpbs985TRZZ5XEImj2kZY0BSR895psvHcXZ0w02-YFDmIhT7dRIaMgdsqz6G4XRsxsRvgfHnYz_UcEZa2sf1Tw2gTs6IOZBDlnigof-5zK/s1600/2762802-000.jpg",
                        Description = "La Liga de la Justicia se enfrenta a su primer gran despu\u00e9s, luchando contra una amenaza de otro planeta.",
                        Author = "Geoff Johns",
                        Reference = "JL01",
                        Pages = 248
                    },
                    new Comic
                    {
                        Id = Guid.Parse("ab8f2c4d-7e9a-42b1-b3c7-9d5e3f8a6c21"),
                        Title = "Superman: Hijo Rojo",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgEIHhEWtzpZHOg4tD6Ic_yJAm1Pd1YqsQ3ipUseoREt9gOZ1KYkXREA7d0adLWJWFJovDVWuHhiYVCWcF9l0iHpNLhfdQUlC4LvCp2cBJwjQWv9Tq1cCWvVClXzPrKwjhFM9Zj834PhGZ-/w263-h400/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Una historia alternativa donde Superman aterriza en la Uni\u00f3n Sovi\u00e9tica en lugar de Kansas.",
                        Author = "Mark Millar",
                        Reference = "SUP01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("b66c283f-23ea-432d-a702-80c4206278ae"),
                        Title = "Los 4 Fant\u00e1sticos: El regreso de Galactus",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEg8GDULOA2-bVviviItOLLNTAWPPWf3b6jnXXdrZOHVs8zpXbvP0um_nxPjVqNT_7UW5UAeh1KWy4SPf5cUnG5Qb9zXqURsh1hX6VGWQxZJ8dNkoph7fKHlRVIpk5zK/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25281%2529.jpg",
                        Description = "El regreso de Galactus pone a prueba a los 4 Fant\u00e1sticos, quienes deben enfrentarse a la amenaza cosmica de la destruccion.",
                        Author = "Stan Lee",
                        Reference = "FF01",
                        Pages = 280
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c3a5f9b7-8d2c-42e9-a5f4-7b8c2e9d3f61"),
                        Title = "X-Men: D\u00edas del futuro pasado",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhWFeccvmYcHUsUsUASPjhwA90vgQfczznFXEtMmJNCA91gU2ymOaGJZFBaY6mhkFN9X8Os3qdwW8w7Nj80MNqGIvv4y3fPzy7yOOQAjpP00qY4orZGNRdypvYe6xq2qyW0QKS_3zNtuDo9/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25283%2529.jpg",
                        Description = "Los mutantes enfrentan un futuro devastador en el que deben luchar por sobrevivir contra los Centinelas.",
                        Author = "Chris Claremont",
                        Reference = "XM01",
                        Pages = 144
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9a3b8d7-4e5f-4a2b-9c6d-8f2e7a3c5b1f"),
                        Title = "The Flash: Renacimiento",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhf7XVHH0h9M2CIv-8ry7SKlersxLwPijsE3XsmOD9opaaGf3AWYYT1Yxulb1EtbkLiRtBtlnmRejjBoudZH_i-hLQYm_q2ZwNjcT7cI1OIiuohT9jIcqX-f__o4B_Jtt9mmd0lLMAmPMdhFfwg90ndeg9uegL1wNSTEZo0UbEAV94zL5Rs2n4hRMxj_PY/s621/Violator%20vs%20Badrock%20(0)a.jpg",
                        Description = "Barry Allen regresa de entre los muertos y debe enfrentar las consecuencias de su resurrecci\u00f3n.",
                        Author = "Geoff Johns",
                        Reference = "FL01",
                        Pages = 192
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9b6a963-feb0-44d4-a0b2-ffdcba531fbb"),
                        Title = "Iron Man: Extremis",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjFXT6J_6xXSeWDkqXOxNQGbqb1I09kOTDwlsZng4eUDAYhHJeBowmLCruu1bA5pEBHL3sAw_E1_1x-HkbP6lYblS2C5ptHRll7t6ASeWndaaZ-XvuenV7by30SFveDb_OMrqVAISLBtyz0SVuBcpFw05tGhzxS8Sh1x4hPsLNTVcSZK08BbvUGkJI4GFg/s1518/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Tony Stark se enfrenta a la amenaza de Extremis, un virus biotecnol\u00f3gico que podr\u00eda destruirlo.",
                        Author = "Warren Ellis",
                        Reference = "IM01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("cb9f1206-b8c4-4c82-9b39-c0d604489d8b"),
                        Title = "Justice League: La guerra",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgLh-rkTWz0LDvGwlVe1VQxHTkzNUEi9fZgbpmpbs985TRZZ5XEImj2kZY0BSR895psvHcXZ0w02-YFDmIhT7dRIaMgdsqz6G4XRsxsRvgfHnYz_UcEZa2sf1Tw2gTs6IOZBDlnigof-5zK/s1600/2762802-000.jpg",
                        Description = "La Liga de la Justicia se enfrenta a su primer gran despu\u00e9s, luchando contra una amenaza de otro planeta.",
                        Author = "Geoff Johns",
                        Reference = "JL01",
                        Pages = 248
                    },
                    new Comic
                    {
                        Id = Guid.Parse("ab8f2c4d-7e9a-42b1-b3c7-9d5e3f8a6c21"),
                        Title = "Superman: Hijo Rojo",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgEIHhEWtzpZHOg4tD6Ic_yJAm1Pd1YqsQ3ipUseoREt9gOZ1KYkXREA7d0adLWJWFJovDVWuHhiYVCWcF9l0iHpNLhfdQUlC4LvCp2cBJwjQWv9Tq1cCWvVClXzPrKwjhFM9Zj834PhGZ-/w263-h400/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Una historia alternativa donde Superman aterriza en la Uni\u00f3n Sovi\u00e9tica en lugar de Kansas.",
                        Author = "Mark Millar",
                        Reference = "SUP01",
                        Pages = 168
                    },
                    new Comic
                    {
                        Id = Guid.Parse("b66c283f-23ea-432d-a702-80c4206278ae"),
                        Title = "Los 4 Fantasticos: El regreso de Galactus",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEg8GDULOA2-bVviviItOLLNTAWPPWf3b6jnXXdrZOHVs8zpXbvP0um_nxPjVqNT_7UW5UAeh1KWy4SPf5cUnG5Qb9zXqURsh1hX6VGWQxZJ8dNkoph7fKHlRVIpk5zK/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25281%2529.jpg",
                        Description = "El regreso de Galactus pone a prueba a los 4 Fant\u00e1sticos, quienes deben enfrentarse a la amenaza cosmica de la destruccion.",
                        Author = "Stan Lee",
                        Reference = "FF01",
                        Pages = 280
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c3a5f9b7-8d2c-42e9-a5f4-7b8c2e9d3f61"),
                        Title = "X-Men: D\u00edas del futuro pasado",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhWFeccvmYcHUsUsUASPjhwA90vgQfczznFXEtMmJNCA91gU2ymOaGJZFBaY6mhkFN9X8Os3qdwW8w7Nj80MNqGIvv4y3fPzy7yOOQAjpP00qY4orZGNRdypvYe6xq2qyW0QKS_3zNtuDo9/s1600/Deadpool+-+La+guerra+de+Wade+Wilson+%25283%2529.jpg",
                        Description = "Los mutantes enfrentan un futuro devastador en el que deben luchar por sobrevivir contra los Centinelas.",
                        Author = "Chris Claremont",
                        Reference = "XM01",
                        Pages = 144
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9a3b8d7-4e5f-4a2b-9c6d-8f2e7a3c5b1f"),
                        Title = "The Flash: Renacimiento",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhf7XVHH0h9M2CIv-8ry7SKlersxLwPijsE3XsmOD9opaaGf3AWYYT1Yxulb1EtbkLiRtBtlnmRejjBoudZH_i-hLQYm_q2ZwNjcT7cI1OIiuohT9jIcqX-f__o4B_Jtt9mmd0lLMAmPMdhFfwg90ndeg9uegL1wNSTEZo0UbEAV94zL5Rs2n4hRMxj_PY/s621/Violator%20vs%20Badrock%20(0)a.jpg",
                        Description = "Barry Allen regresa de entre los muertos y debe enfrentar las consecuencias de su resurrecci\u00f3n.",
                        Author = "Geoff Johns",
                        Reference = "FL01",
                        Pages = 192
                    },
                    new Comic
                    {
                        Id = Guid.Parse("c9b6a963-feb0-44d4-a0b2-ffdcba531fbb"),
                        Title = "Iron Man: Extremis",
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjFXT6J_6xXSeWDkqXOxNQGbqb1I09kOTDwlsZng4eUDAYhHJeBowmLCruu1bA5pEBHL3sAw_E1_1x-HkbP6lYblS2C5ptHRll7t6ASeWndaaZ-XvuenV7by30SFveDb_OMrqVAISLBtyz0SVuBcpFw05tGhzxS8Sh1x4hPsLNTVcSZK08BbvUGkJI4GFg/s1518/Youngblood%20%23%2010%20(0).jpg",
                        Description = "Tony Stark se enfrenta a la amenaza de Extremis, un virus biotecnol\u00f3gico que podr\u00eda destruirlo.",
                        Author = "Warren Ellis",
                        Reference = "IM01",
                        Pages = 168
                    }
                };

            context.Comics.AddRange(comics);
                await context.SaveChangesAsync();
            }
        }
    }
