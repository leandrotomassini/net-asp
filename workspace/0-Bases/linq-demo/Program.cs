
LinqQueries queries = new LinqQueries();

ImprimirValores(queries.TodaLaColeccion());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine(
        "{0, -70}, {1,7}, {2,11}",
        "Titulo", "N. Páginas", "Fecha publiación"
    );

    foreach (var item in listadelibros)
    {
        Console.WriteLine(
            "{0, -70}, {1,7}, {2,11}",
            item.Title, item.PageCount, item.PublishedDate
        );
    }
}