CREATE DATABASE kezbesito DEFAULT charset utf8 collate=utf8_hungarian_ci;

USE kezbesito;

SELECT lap.cim, lap.havi FROM lap WHERE lap.havi!=0 ORDER by lap.cim;

SELECT nev,utca,hazszam from elofizeto,elofizetes WHERE elofizeto.id=eloid GROUP by eloid HAVING COUNT(lapid);

SELECT SUM(lap.eves) as osszeg from lap,elofizeto,elofizetes WHERE lap.id=lapid AND eloid=elofizeto.id AND utca="Bodor utca" AND hazszam=13; 