using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cosmic Cinema",
                            Logo = "https://images.unsplash.com/photo-1706706588488-7f1ed39abe18?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "A gateway to a universe of cinematic wonders."
                        },
                        new Cinema()
                        {
                            Name = "RetroVue",
                            Logo = "https://images.unsplash.com/photo-1706559579717-2ad5712a1654?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "Classic films in a nostalgic setting."
                        },
                        new Cinema()
                        {
                            Name = "IndieFlicks Hub",
                            Logo = "https://images.unsplash.com/photo-1706983469467-03b9ebd5d40e?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "Celebrating independent cinema."
                        },
                        new Cinema()
                        {
                            Name = "Thriller Villa",
                            Logo = "https://images.unsplash.com/photo-1706955279426-9924ebe60002?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "Heart-stopping thrillers and mysteries."
                        },
                        new Cinema()
                        {
                            Name = "Fantasia",
                            Logo = "https://images.unsplash.com/photo-1706766957895-65376015bbee?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "Embark on epic adventures and fantasy."
                        },
                    });
                    context.SaveChanges();
                }

                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Maxwell Sterling",
                            Bio = "An acclaimed actor known for dynamic roles in theater and film.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1539571696357-5a69c17a67c6?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Actor()
                        {
                            FullName = "Julia East",
                            Bio = "A versatile actress with a passion for indie films.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1513956589380-bad6acb9b9d4?q=80&w=1536&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Actor()
                        {
                            FullName = "Sam Rivera",
                            Bio = "Rising star known for captivating performances in drama and action.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1499996860823-5214fcc65f8f?q=80&w=1966&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Actor()
                        {
                            FullName = "Elena Gomez",
                            Bio = "A critically acclaimed actress with numerous awards in dramatic roles.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1506794778202-cad84cf45f1d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Actor()
                        {
                            FullName = "Chris Norman",
                            Bio = "A charismatic actor with a flair for comedy and dramatic roles.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1519085360753-af0119f7cbe7?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        }
                    });
                    context.SaveChanges();
                }

                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Liam Scott",
                            Bio = "A visionary producer who has brought to life some of the most memorable cinematic experiences.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1534528741775-53994a69daeb?q=80&w=1964&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Producer()
                        {
                            FullName = "Sophie Turner",
                            Bio = "Known for producing critically acclaimed indie gems.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1531746020798-e6953c6e8e04?q=80&w=1964&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Producer()
                        {
                            FullName = "Evan Peters",
                            Bio = "A producer with a keen eye for groundbreaking narratives.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1526510747491-58f928ec870f?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Producer()
                        {
                            FullName = "Nora Zehetner",
                            Bio = "Renowned for her innovative approach to storytelling and film production.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1520090651682-088bf846fafe?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new Producer()
                        {
                            FullName = "Derek Cianfrance",
                            Bio = "An acclaimed filmmaker and producer known for his intense and emotional storytelling.",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1532171875345-9712d9d4f65a?q=80&w=2030&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        }
                    });
                    context.SaveChanges();
                }

                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Eternal Vistas",
                            Description = "An epic journey through time and space.",
                            Price = 45.99,
                            ImageURL = "https://images.unsplash.com/photo-1706550631672-15f4502b7527?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            StartDate = DateTime.Now.AddDays(-30),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.SciFi
                        },
                        new Movie()
                        {
                            Name = "The Quiet Echo",
                            Description = "A haunting tale of love and loss.",
                            Price = 50.00,
                            ImageURL = "https://images.unsplash.com/photo-1706993886447-0ab59e333c86?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Adventures Beyond",
                            Description = "A family's thrilling journey to discover the unknown.",
                            Price = 55.50,
                            ImageURL = "https://images.unsplash.com/photo-1676578145272-750d8e72287a?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Adventure
                        },
                        new Movie()
                        {
                            Name = "The Last Stand",
                            Description = "A gripping story of survival and resilience.",
                            Price = 60.00,
                            ImageURL = "https://images.unsplash.com/photo-1702352860159-262e4ed291e2?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Mysteries Unfold",
                            Description = "A detective's quest to solve an ancient mystery.",
                            Price = 40.00,
                            ImageURL = "https://plus.unsplash.com/premium_photo-1670491584909-fad9d3a4f66d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(5),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Mystery
                        },
                          new Movie()
                        {
                            Name = "Scary film 1",
                            Description = "Lets play a game",
                            Price = 20.00,
                            ImageURL = "https://plus.unsplash.com/premium_photo-1667608386999-bc20b98ef329?q=80&w=1972&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(6),
                            CinemaId = 5,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Horror
                        }

                    });
                    context.SaveChanges();
                }
                if (!context.Actors_Movies.Any())
                {
                    var movies = context.Movies.ToList();
                    var actors = context.Actors.ToList();
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
            {
                new Actor_Movie() { ActorId = actors[0].Id, MovieId = movies[0].Id }, 
                new Actor_Movie() { ActorId = actors[1].Id, MovieId = movies[0].Id }, 
                new Actor_Movie() { ActorId = actors[2].Id, MovieId = movies[1].Id }, 
                new Actor_Movie() { ActorId = actors[3].Id, MovieId = movies[2].Id }, 
                new Actor_Movie() { ActorId = actors[0].Id, MovieId = movies[3].Id }, 
                new Actor_Movie() { ActorId = actors[1].Id, MovieId = movies[4].Id }, 
                new Actor_Movie() { ActorId = actors[2].Id, MovieId = movies[5].Id }, 
                new Actor_Movie() { ActorId = actors[3].Id, MovieId = movies[5].Id }, 
                                                                                      

            });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                // Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                // Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@example.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Super Admin",
                        UserName = "superadmin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "SecurePassword123!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@example.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "General User",
                        UserName = "generaluser",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "SecurePassword123!");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
