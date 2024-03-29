CREATE DATABASE kezbesito DEFAULT charset utf8 collate=utf8_hungarian_ci;

USE kezbesito;

SELECT lap.cim, lap.havi FROM lap WHERE lap.havi!=0 ORDER by lap.cim;

SELECT nev,utca,hazszam from elofizeto,elofizetes WHERE elofizeto.id=eloid GROUP by eloid HAVING COUNT(lapid);

SELECT SUM(lap.eves) as osszeg from lap,elofizeto,elofizetes WHERE lap.id=lapid AND eloid=elofizeto.id AND utca="Bodor utca" AND hazszam=13; 

SELECT cim, 12*havi-eves as kedvezmeny,havi,eves from lap ORDER by kedvezmeny DESC LIMIT 1;

SELECT DISTINCT l2.cim 
	from lap,elofizetes,lap as l2,elofizetes as e2 
	WHERE lap.id=elofizetes.lapid 
		AND lap.cim="Magyar Nemzet"
		and l2.id=e2.lapid
		and elofizetes.eloid=e2.eloid
		and l2.cim!="Magyar Nemzet";