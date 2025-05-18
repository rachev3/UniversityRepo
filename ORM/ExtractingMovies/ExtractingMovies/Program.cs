using ExcelDataReader;
using ExtractingMovies;
using System.Data;
using System.Globalization;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var movies = new List<Movie>();
var genres = new List<Genre>();
var directors = new List<Director>();
var casts = new List<Cast>();

using var stream = File.Open("imdb_top_2000_movies.csv", FileMode.Open, FileAccess.Read);
using var reader = ExcelReaderFactory.CreateCsvReader(stream, new ExcelReaderConfiguration()
{
    FallbackEncoding = Encoding.UTF8,
    AutodetectSeparators = new[] { ',', ';' }
});

var result = reader.AsDataSet();
var table = result.Tables[0];

for (int i = 1; i < table.Rows.Count; i++)
{
    var row = table.Rows[i];

    string rawGenres = row[6]?.ToString()?.Trim();
    string rawDirector = row[7]?.ToString()?.Trim();
    string rawCast = row[8]?.ToString()?.Trim();


    AddDirector(rawDirector, directors);
    AddCast(rawCast, casts);
    AddGenres(rawGenres, genres);
    AddMovie(row, movies);


}

//sorting by rating
var sorted = movies
    .Where(m => m.Rating.HasValue)
    .OrderByDescending(m => m.Rating)
    .ToList();

//sum for year
Console.WriteLine("Year:");
string yearInput = Console.ReadLine();
if (int.TryParse(yearInput, out var releaseYear))
{
    var yearMovies = movies.Where(m => m.ReleaseDate.HasValue && m.ReleaseDate.Value.Year == releaseYear);
    var sum = yearMovies.Sum(m => m.Gross ?? 0);

    Console.WriteLine($"Total gross for movies released in {releaseYear}: ${sum:N0}");
}
else
{
    Console.WriteLine("Invalid year input.");
}


void AddMovie(DataRow row, List<Movie> movieList)
{

    string rawGross = row[9]?.ToString()?.Trim();
    double? gross = null;
    if (!string.IsNullOrWhiteSpace(rawGross) && rawGross.EndsWith("M"))
    {
        var cleaned = rawGross.Replace("$", "").Replace("M", "");
        if (double.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsed))
        {
            gross = parsed * 1000000;
        }
    }
    movies.Add(new Movie
    {
        MovieName = row[0]?.ToString(),

        ReleaseDate = int.TryParse(row[1]?.ToString(), out var year)
    ? new DateTime(year, 1, 1)
    : null,

        Duration = int.TryParse(row[2]?.ToString(), out var duration) ? duration : null,
        Rating = double.TryParse(row[3]?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var rating) ? rating : null,
        MetaScore = double.TryParse(row[4]?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var meta) ? meta : null,
        Votes = int.TryParse(row[5]?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var votes) ? votes : null,
        Gross = gross


    });
}
void AddGenres(string rawGenres, List<Genre> genreList)
{
    if (string.IsNullOrWhiteSpace(rawGenres)) return;

    var genres = rawGenres.Split(',')
                           .Select(g => g.Trim())
                           .Where(g => !string.IsNullOrEmpty(g));

    foreach (var genreName in genres)
    {
        if (!genreList.Any(g => g.GenreName.Equals(genreName, StringComparison.OrdinalIgnoreCase)))
        {
            genreList.Add(new Genre { GenreName = genreName });
        }
    }
}

void AddCast(string rawCast, List<Cast> castList)
{
    if (string.IsNullOrWhiteSpace(rawCast)) return;
    if (!castList.Any(c => c.ActorName.Equals(rawCast, StringComparison.OrdinalIgnoreCase)))
    {
        castList.Add(new Cast { ActorName = rawCast });
    }
}

void AddDirector(string rawDirector, List<Director> directorList)
{
    if (string.IsNullOrWhiteSpace(rawDirector)) return;
    if (!directorList.Any(c => c.DirectorName.Equals(rawDirector, StringComparison.OrdinalIgnoreCase)))
    {
        directorList.Add(new Director { DirectorName = rawDirector });
    }
}
