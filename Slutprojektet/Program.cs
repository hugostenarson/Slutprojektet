Console.WriteLine("Välkommen till Hide N' Seek! En entitet gömmer sig bakom ett slumpmässigt nummer från 1 till 10. Du har tre försök att gissa det rätta numret. Om du gissar rätt nummer kommer entiteten fram och du måste slåss mot den för att överleva. Misslyckas du att gissa rätt nummer på tre försök kastar sig entiteten över dig och äter upp dig. Lycka till.");

numGame num = new();

// num.enterUserGuess();
Console.WriteLine($"Entitetens gömmer sig bakom {num.entityNum}.");
num.startGuessing();


Console.ReadLine();

