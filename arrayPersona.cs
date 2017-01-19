private string [] nomi= {"Luca","Giovanni","Giacomo","Mario"}													
private string [] cognomi= {"Rossi","Becchi","Davoli","Sambuchi"}
private Persona generateRandomPersona()
{
	Random rnd = new Random();
	return new Persona(nomi[rnd.next(?)],cognomi[rnd.next(?)],16);
}