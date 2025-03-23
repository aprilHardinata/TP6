// See https://aka.ms/new-console-template for more information
class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
        {
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter");
        }

        Random random = new Random();

        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void increasePlayCount(int jumlah)
    {
        if (jumlah < 0 || jumlah > 10000000)
        {
            throw new ArgumentException("Jumlah harus antara 0 dan 10.000.000");
        }

        this.playCount += jumlah;
    }

    public void printVideoDetails()
    {
        Console.WriteLine($"ID :{id}");
        Console.WriteLine($"Judul :{title}");
        Console.WriteLine($"PlayCount :{playCount}");
    }
}

class program
{
    static void Main()
    {
        string? v = Console.ReadLine();
        string nama = v;

        SayaTubeVideo video = new SayaTubeVideo($"Tutorial Design By Contract – {nama}");

        video.increasePlayCount(10);

        video.printVideoDetails();
    }
}