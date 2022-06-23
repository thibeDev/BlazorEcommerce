﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Retour vers le futur (Back to the Future) est un film de science-fiction américain réalisé par Robert Zemeckis, sorti en 1985.L'intrigue relate le voyage dans le passé d'un adolescent, Marty McFly, à bord d'une machine à voyager dans le temps fabriquée par le docteur Emmett Brown, à partir d'une voiture de modèle DeLorean DMC-12. Parti de l'année 1985 et propulsé le 5 novembre 1955, Marty, aidé du « Doc » de 1955, doit résoudre les paradoxes temporels provoqués par ses interventions dans le passé, et trouver le moyen de faire fonctionner la machine pour retourner à son époque d'origine.", "https://images-na.ssl-images-amazon.com/images/I/916W6HeeyzL.jpg", 9.99m, "Retour vers le futur" },
                    { 2, "Benoît Poelvoorde (/bə.nwa pul.vɔʁd/), né le 22 septembre 1964 à Namur, est un acteur et humoriste belge.Révélé durant les années 1990 par le film culte belge C'est arrivé près de chez vous (1992), la série humoristique Les Carnets de Monsieur Manatane (1997), il est la vedette de la comédie française Les Randonneurs (1997), qui fait plus de 1,5 millions d'entrées au cinéma.Il s'impose ensuite durant les années 2000 comme une valeur sûre du cinéma franco-belge.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Benoit_Poelvoorde_Cabourg_2018.jpg/220px-Benoit_Poelvoorde_Cabourg_2018.jpg", 7.99m, "Benoît Poelvoorde" },
                    { 3, "En 2045, le monde est en proie à de nombreux soucis : crise énergétique, désastres causés par le changement climatique, la famine, la pauvreté, la guerre, etc. Dans ce monde chaotique, l'Oasis est un système mondial de réalité virtuelle, accessible par l'intermédiaire de casques de réalité virtuelle et de dispositifs haptiques tels que des gants et des combinaisons. Conçu à l'origine comme un MMORPG, il est devenu au fil du temps une société virtuelle dont toute l'humanité se sert comme exutoire.", "https://fr.web.img4.acsta.net/pictures/18/02/14/09/15/3437390.jpg", 15.99m, "Ready Player One (film)" },
                    { 4, "La Reine du sud (La Reina del sur) est une telenovela américano-espagnole-colombienne.La première saison a été diffusée entre le 28 février 2011 et le 30 mai 2011 sur Telemundo aux États-Unis et à partir du 14 mars 2011 sur Antena 3 en Espagne.La deuxième saison a été diffusée entre le 22 avril 2019 et le 29 juillet 2019 sur Telemundo aux États-Unis.En France, la première saison a été diffusée à partir du 29 février 2012 sur France Ô1, puis disponible depuis l'automne 2016 sur 6play2 ; et au Québec à partir du 31 décembre 2012 sur Séries+.Le 11 mai 2017, Telemundo confirme que La Reine du sud est renouvelée pour une deuxième saison[réf. souhaitée] dont la diffusion était prévue pour l'année 2019 aux États-Unis.Le 16 juillet 2020, Kate del Castillo et la chaine Telemundo annonce que La Reine du sud est renouvelée pour une troisième saison dont la diffusion est prévue pour 2021 - 2022 aux États-Unis.", "https://fr.web.img6.acsta.net/pictures/16/04/19/11/23/421985.jpg", 5.99m, "La Reine du Sud" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
