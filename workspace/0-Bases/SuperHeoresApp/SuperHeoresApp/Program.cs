
using SuperHeoresApp.Models;
using System.Text;

var imprimirInfo = new ImprimirInfo();

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.NivelTres;


var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();

superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);

Console.WriteLine(superman == superman2);

SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent");
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
superman.SuperPoderes = poderesSuperman;
string resultadosSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultadosSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

imprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultadosSuperPoderesWolverine = wolverine.UsarSuperPoderes();
Console.WriteLine(resultadosSuperPoderesWolverine);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiHeroe);



enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}


public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);

