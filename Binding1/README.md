# Binding1
Bu projede geliştirdiğimiz uygulama penceresinde
yine bir liste kutusu (**ListBox**) kontrolü var,
ama yalnızca bir tane var.

Bu denememizde liste kutusu kontrolüne kodlarla eleman eklemek yerine,
onu kodlarla oluşturduğumuz **sayilar** adlı listeye bağlayacağız.
```
public partial class MainWindow : Window
{
    private Random rnd = new Random();
    private List<int> Sayilar = new List<int>();

    public MainWindow()
    {
        InitializeComponent();

        SayilarOlustur();
    }

    private void SayilarOlustur()
    {
        for(int i=0, n = rnd.Next(5,16); i < n; i++)
        {
            Sayilar.Add(rnd.Next(10,100));
        }
    }
}
```
Yukarıda gördüğünüz gibi, `Sayilar` listesini oluşturan
fonksiyonu pencere sınıfının kodlarını yükleyen
kurucu fonksiyondan çağırıyoruz.

Listeye 5'den 15'e kadar rasgele sayida sayı ekliyoruz.
Sayılar da her biri 10'dan 100'e kadar (dahil değil)
iki rakamlı rasgele sayılar.

## {Binding} ile Liste Bağlantısı
**ListBox1** projesinde bir liste kutusunun elemanlar listesini
**ItemsSource** özelliği aracılığıyla böyle bir listeye bağlamıştık.
Ama o bağlantıyı kodlar aracılığıyla yapmıştık.

Aynı bağlantıyı liste kutusu kontrolünün XAML tanım başlığındaki
bir `{Binding}` ifadesiyle de yapabiliriz.
Tek yapmamız gereken şey eleman listesinin adını,
yani pencerenin kod dosyasındaki sayilar listesinin adını yazmaktır:
```
    <Grid>
        <ListBox ItemsSource="{Binding Sayilar}" />
    </Grid>
```

Bu adımları tekrarlar ve deneme için uygulamayı çalıştırırsanız,
liste kutusunda sayı filan görmeyeceksiniz.
Bunun iki neeni var:

1. Kontrolün bir özelliğini `{Binding}` ile bir değişkene
   bağlayamazsınız. Böyle bir bağlantıyı ancak dışarıdan
   erişime açık (**public**) bir özellik (*property*)
   tanımına bağlayabilirsiniz.
2. `{Binding}` ifadesinde adını verdiğiniz özelliğin
   kime ait olduğunu da belirleniz gerekir. 

Önce birinci sorunu çözelim:
Pencerenin kod dosyasındaki listeyi bir değişken olarak değil
bir otomatik özellik (*auto-property*) olarak tanımlamalıyız:

`public List<int> Sayilar { get; set; }`

İkinci sorunu çözmek için de veri bağlantıları için
kaynak nesneyi tanımlamalıyız.

```
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;

        Sayilar = new List<int>();
        SayilarOlustur();
    }
```

Henüz erken olduğu için fazla ayrıntıya girmiyoruz,
ama kısaca özetleyelim:
WPF uygulamalarında veri kaynağını belirleyen özellik
**DataContext**'dir. Yukarıdaki kurucu fonksiyonun
ikinci komutunda **this** referansı pencere nesnesinin
kendisine işaret etmektedir, yani pencere içeriğindeki
veri bağlantıları için kaynak olarak kendisini göstermektedir.

Bu atama sayesinde, **ListBox** kontrolü
**ItemsSource** özelliği için kurduğumuz
`{Binding}` bağlantısındaki `Sayilar` listesinin
pencere nesnesine ait bir liste olduğunu bilecektir artık.

Artık uygulamayı çalıştırırsanız liste kutusunda sayıların
listelendiğini göreceksiniz.

## Dinamik Liste Oluşturulması

**ItemsSource** özelliğine atadığımız liste artık gözüküyor,
ama acaba liste içeriği değiştirsek,
yeni oluşturduğumuz liste de gözükecek mi?

Onu görmek için `Sayilar` listesini belli aralıklarla
değiştirmeyi deneyeceğiz.

Pencere kod dosyasının (**MainWindow.xaml.cs**)
başına gerekli olacak bir ad uzayı referansını ekleyelim:
`using System.Windows.Threading;`

Pencere sınıfındaki değişken tanımları arasında da
bir zamanlayıcı nesnesi (**DispatcherTimer**) tanımı ekleyelim:
`private DispatcherTimer zamanlayici = new DispatcherTimer();
`
> *DİKKAT: Zamanlayıcı nesnesinin türü **Timer** mı olmalıydı
   diye şüphelenmiş olabilirsiniz.
   Evet, öyle bir tür vardır,
   ama o türden bir zamanlayıcı sistemin genelinde çalışır.<br>
   Onu bir "dünya saati" diye düşünebilirsiniz.<br>
   Biz uygulamanın iş akışında çalışan bir zamanlayıcı tanımladık.
   Onu da "yerel saat" diye düşünebilirsiniz.<br>
   İşletim sistemi ve uygulamaların iş akışları (threads)
   konusuna girmeden, ancak bu kadar özetleyebiliriz.*

Her neyse, bu `zamanlayici` nesnesi
belli aralıklarla "tıklayacak" bir saat nesnesidir.
Kurucu fonksiyonda onun **Interval** özelliğiyle
tıklama aralığını belirleriz.
Her tıklamasında neler olacağını belirlemek
için de **Tick** olayını yanıtlayacak bir fonksiyon adı veririz:
```
    zamanlayici.Interval = TimeSpan.FromSeconds(5);
    zamanlayici.Tick += Zamanlayici_Tick;
```

Kurucu fonksiyonun bitimine de zamanlayıcıyı
çalıştıracak olan şu komutu ekleriz:<br>
`zamanlayici.Start();`


Beş saniyde bir gerçekleşecek tıklama olayını yanıtlayan
fonksiyon adı verirken akıllı tamamlayıcı (*Intellisense*)
otomatik olarak bir fonksiyon oluşturmuştu.
Biz onu sayılar listesini yeniden oluşturacak şekilde ayarladık:
```
    private void Zamanlayici_Tick(object? sender, EventArgs e)
    {
        Sayilar.Clear();
        SayilarOlustur();
    }
```
Bu adımları izledikten sonra uygulamayı çalıştırırsanız,
yine bir başlangıç listesi göreceksiniz,
ama listedeki sayılar hiç değişmeden kalacaktır.

Aslında listenin kendisi değişiyordu,
ama liste kutusu yalnızca ilk bağladığımız başlangıç halini görüyordu.
Gerçek anlamda "dinamik" bir liste oluşturmak
için "gözlenebilir koleksiyon" oluşturmalıyız.

Bunun için de pencere kod dosyasının başına
şu ad uzayı referansını ekleriz:
`using System.Collections.ObjectModel;`

`Sayilar` listesinin türünü de<br>
`ObservableCollection<int>`<br>
olarak değiştiririz.

Artık liste kutusu içeriğindeki rasgele sayılar listesi
beş saniyede bir değişecektir.
