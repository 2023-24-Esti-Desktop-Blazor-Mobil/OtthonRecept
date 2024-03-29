using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System.Collections.Generic;

namespace BackEnd.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Guid KepzettsegId1 = Guid.NewGuid();
            Guid KepzettsegId2 = Guid.NewGuid();
            Guid KepzettsegId3 = Guid.NewGuid();
            Guid KepzettsegId4 = Guid.NewGuid();
            Guid SzemelyId1 = Guid.NewGuid();
            Guid SzemelyId2 = Guid.NewGuid();
            Guid SzemelyId3 = Guid.NewGuid();
            Guid SzemelyId4 = Guid.NewGuid();
            Guid SzemelyId5 = Guid.NewGuid();
            Guid MeasurementId1 = Guid.NewGuid();
            Guid MeasurementId2 = Guid.NewGuid();
            Guid MeasurementId3 = Guid.NewGuid();
            Guid MeasurementId4 = Guid.NewGuid();
            Guid IngredientId1 = Guid.NewGuid();
            Guid IngredientId2 = Guid.NewGuid();
            Guid IngredientId3 = Guid.NewGuid();
            Guid IngredientId4 = Guid.NewGuid();
            Guid CikkId1= Guid.NewGuid();
            Guid CikkId2= Guid.NewGuid();
            Guid CikkId3 = Guid.NewGuid();
            Guid CikkId4 = Guid.NewGuid();
            Guid CikkId5 = Guid.NewGuid();
            Guid ReceptId1 = Guid.NewGuid();
            Guid ReceptId2 = Guid.NewGuid();
            Guid ReceptId3 = Guid.NewGuid();
            Guid ReceptId4 = Guid.NewGuid();
            Guid ReceptId5 = Guid.NewGuid();

            List<Kepzettseg> kepzettsegek = new()
            {
                new Kepzettseg
                {
                    Id=KepzettsegId1,
                    SzemelyKepzettseg="Kezdő",
                },
                new Kepzettseg
                {
                    Id=KepzettsegId2,
                    SzemelyKepzettseg="Haladó",
                 },
                new Kepzettseg
                {
                    Id=KepzettsegId3,
                    SzemelyKepzettseg="Profi",
                 },
                 new Kepzettseg
                {
                    Id=KepzettsegId4,
                    SzemelyKepzettseg="Mester Szakács",
                 }

            };


            List<Szemely> szemelyek = new ()
            {
                new Szemely
                {
                    Id=SzemelyId1,
                    FirstName="János",
                    LastName="Bácsi",
                    Age=42,
                    KepzettsegId=KepzettsegId1,
                    
                },
                new Szemely
                {
                    Id=SzemelyId2,
                    FirstName="Peti",
                    LastName="Süti",
                    Age=20,
                    KepzettsegId=KepzettsegId2,
                },
                new Szemely
                {
                    Id=SzemelyId3,
                    FirstName="Réka",
                    LastName="Béka",
                    Age=22,
                    KepzettsegId=KepzettsegId2,
                },
                new Szemely
                {
                    Id=SzemelyId4,
                    FirstName="Zsóka",
                    LastName="Móka",
                    Age=35,
                    KepzettsegId=KepzettsegId4,
                },

                new Szemely
                {
                    Id=SzemelyId5,
                    FirstName="Géza",
                    LastName="Bácsi",
                    Age=60,
                    KepzettsegId=KepzettsegId3,
                } };
                List<Cikk> cikks = new ()
            {
                new Cikk
                {
                    Id= CikkId1,
                    Name="Kutyákról",
                    Description="Ez egy kuty",
                    FeltoltoId=SzemelyId1,
                    Idopont=new DateTime(2022,10,10),
                },
                new Cikk
                {
                    Id= CikkId2,
                    Name="Macskákról",
                    Description="Süti",
                    FeltoltoId=SzemelyId2,
                    Idopont=new DateTime(2023,10,10),
                },
                new Cikk
                {
                    Id=CikkId3,
                    Name="halételekről",
                    Description="ez egy étel",
                    FeltoltoId=SzemelyId2,
                    Idopont=new DateTime(2023,11,15),
                },
                new Cikk
                {
                    Id=CikkId4,
                    Name="Bálnákról",
                    Description="Móka",
                    FeltoltoId=SzemelyId2,
                    Idopont=new DateTime(2023,12,17),
                },

                new Cikk
                {
                    Id=CikkId5,
                    Name="Géza",
                    Description="Bácsi",
                    FeltoltoId=SzemelyId3,
                    Idopont=new DateTime(2024,01,10),
                }
                };
            List<Measurements> measurements = new()
            {
                new Measurements
                {
                    Id= MeasurementId1,
                    IngredientsMeasurements="kiló",

                },
                new Measurements
                {
                    Id= MeasurementId2,
                    IngredientsMeasurements="liter",
                },
                new Measurements
                {
                    Id= MeasurementId3,
                    IngredientsMeasurements="darab",
                },
                new Measurements
                {
                    Id= MeasurementId4,
                    IngredientsMeasurements="kanál",
                },
            };

            List<Ingredient> ingredients = new()
            {
                new Ingredient
                {
                    Id= IngredientId1,
                    Quantity=1,
                    IngredientName = "krumpli",
                    MeasurementsId= MeasurementId1,
                },
                new Ingredient
                {
                    Id= IngredientId2,
                    Quantity=3,
                    IngredientName = "tej",
                    MeasurementsId= MeasurementId2,
                },
                new Ingredient
                {
                    Id= IngredientId3,
                    Quantity=3,
                    IngredientName = "tojás",
                    MeasurementsId= MeasurementId3,
                },
                new Ingredient
                {
                    Id= IngredientId4,
                    Quantity=3,
                    IngredientName = "víz",
                    MeasurementsId= MeasurementId2,
                },
            };
                List<Recept> Receptek = new ()
            {
                new Recept
                {
                    Id= ReceptId1,
                    Name="FranciaKrémes",
                    Description="Végy egy franciát és kend meg krémmel",
                    FeltoltoId=SzemelyId1,
                    Idopont=new DateTime(2022,10,10),
                },
                new Recept
                {
                    Id= ReceptId2,
                    Name="OroszKrémTorta",
                    Description="Süssed sokáig",
                    FeltoltoId=SzemelyId1,
                    Idopont=new DateTime(2023,10,10),
                },
                new Recept
                {
                    Id=ReceptId3,
                    Name="halászlé",
                    Description="ez egy étel sok vizzel",
                    FeltoltoId=SzemelyId2,
                    Idopont=new DateTime(2023,11,15),
                },
                new Recept
                {
                    Id=ReceptId4,
                    Name="Birkaprökölt",
                    Description="Fogd meg a birkát",
                    FeltoltoId=SzemelyId2,
                    Idopont=new DateTime(2023,12,17),
                },

                new Recept
                {
                    Id=ReceptId5,
                    Name="Rántottvelő",
                    Description="Szerezz velőt",
                    FeltoltoId=SzemelyId3,
                    Idopont=new DateTime(2024,01,10),
                }

                };

                modelBuilder.Entity<Szemely>().HasData(szemelyek);
                modelBuilder.Entity<Cikk>().HasData(cikks);
                modelBuilder.Entity<Kepzettseg>().HasData(kepzettsegek);
                modelBuilder.Entity<Measurements>().HasData(measurements);
                modelBuilder.Entity<Ingredient>().HasData(ingredients);
                modelBuilder.Entity<Recept>().HasData(Receptek);

        }// Ide kerülnek a tesztadatok
        }
    }

