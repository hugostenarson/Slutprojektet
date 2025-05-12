
Console.WriteLine("Välkommen till Hide N' Seek! En entitet gömmer sig bakom ett slumpmässigt nummer mellan 1 och 10. Du har fem försök att gissa det rätta numret. Om du gissar rätt nummer kommer entiteten fram och du måste slåss mot den för att överleva. Misslyckas du att gissa rätt nummer på fem försök kastar sig entiteten över dig och dödar dig. Lycka till.");
NumGame num = new();
Entity entity = new();
Console.WriteLine($"Entiteten gömmer sig bakom {num.entityNum}.");
num.ChosenEntity();
bool correctguess = num.StartGuessing();
if (correctguess)
{
    
    num.Fight();
}



