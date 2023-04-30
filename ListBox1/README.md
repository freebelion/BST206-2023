# ListBox1

Bu projede listeleyici kontrollerin
en basit olan **ListBox**
(Liste Kutusu) kontrolü ile
denemeler yapacağız.

## Yerleşim Düzeni Hakkında

Bu projede uygulama penceresini dolduran kafes paneli
(**Grid**) beş dikey bölmeye ayırdık.

Beş panel sütunlarının her birine kenarlık renkleri farklı olan
çerçeve paneller (**Border**) koyduk.
Onların içlerine de birer bir liste kutusu (**ListBox**) 
kontrolü yerleştirdik.
Bunlar ile elemanların görünümlerini belirleyen
özellik, şablon ve stilleri karşılaştıracağız.

## listbox1

`listbox1` adını verdiğimiz ilk liste kutusunda listeletmek
istediğimiz sözcükleri doğrudan liste kutusunun XAML bloku
içine yazdık:
```
    <ListBox x:Name="listbox1">
        Recai
        Sezai
        Mesai
        Nevai
        Dubai
    </ListBox>
```

Denedik, gördük: Bu sözcükler tek bir eleman oluşturmuş gibi
yan yana sıralanmışlardı.

## listbox2

`listbox2` için işin doğrusunu yapıp,
her bir sözcüğü bir "liste kutusu elemanı"
(**ListBoxItem**) olarak tanımladık:

```
    <ListBox x:Name="listbox2">
        <ListBoxItem>Recai</ListBoxItem>
        <ListBoxItem>Sezai</ListBoxItem>
        <ListBoxItem>Mesai</ListBoxItem>
        <ListBoxItem>Nevai</ListBoxItem>
        <ListBoxItem>Dubai</ListBoxItem>
    </ListBox>
```
## listbox3

`listbox3` için elemanları kodlarla ekleme yoluna gittik.
Uygulama penceresinin ekrana gelmeye hazır olduğunu
bildiren **Loaded** olayını yanıtlayan fonksiyon içinden
**ListBox3Yukle()** adlı fonksiyonu çağırdık.
Liste yükleyen bu fonksiyonun komutlarında
kontrolün eleman listesi Items koleksiyonuna
listelenecek sözcükleri eklettik:

```
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        ListBox3Yukle();
    }

    private void ListBox3Yukle()
    {
        listbox3.Items.Add("Recai");
        listbox3.Items.Add("Sezai");
        listbox3.Items.Add("Mesai");
        listbox3.Items.Add("Masai");
        listbox3.Items.Add("Kasai");
    }
```

Önceki liste kutuları için XAML kodlarında eklediğimiz
elemanlar pencere tasarım görünümünde görünüyorlardı;
kodlarla eklediğimiz bu elemanlar ancak uygulamayı çalıştırınca
gözüktüler.

> *Bu vesileyle şunu not edelim:<br>
   İçeriğini veya görünümünü kodlarla değiştirecekseniz,
   ancak o zaman WPF kontrollerine isim vermeniz gerekir.*

## listbox4

Dördüncü liste kutusunun eleman listesini kodlarla oluşturduk,
ama elemanları tek tek eklemek yerine, eleman listesini
**ItemsSource** özelliğiyle atadık:

```
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        ListBox3Yukle();
        ListBox4Yukle();
    }

    ...

    private void ListBox4Yukle()
    {
        List<string> elemanlar =
            new List<string>() { "Recai", "Sezai", "Mesai", "Envai", "Rubai"};

        listbox4.ItemsSource = elemanlar;
    }
```

## listbox5

Bu liste kutusuna yazılı metinler değil, resimler yükledik.

Aslında kodlarla resim dosyalarının isimlerini
(adresleriyle) yüklemiştik:

```
    private void ListBox5Yukle()
    {
        listbox5.Items.Add("Images/elma.png");
        listbox5.Items.Add("Images/kayisi.png");
        listbox5.Items.Add("Images/lahana.png");
        listbox5.Items.Add("Images/muz.png");
        listbox5.Items.Add("Images/ananas.png");
    }
```

Ama liste kutusunun XAML bloku içinde eleman şablonunu
resim öğesi gösterecek şekilde değiştirdik:

```
    <ListBox x:Name="listbox5">
        <ListBox.ItemTemplate>
            <DataTemplate>
                <Image Source="{Binding}"/>
            </DataTemplate>
        </ListBox.ItemTemplate>
    </ListBox>
```

Resim öğesi (**Image**) kaynağını belirleyen **Source**
özelliğindeki **Binding** ifadesi ile her bir resim
öğesinin kaynağını ait olduğu elemana bağlamıştık.
Dolayısıyla, her bir öğe gördüğü adresteki dosyayı
kaynak resim olarak gördü.

Çalıştırıp denedik ve yazılı dosya isimleri yerine
resimlerin alt alta gözüktüklerini gördük.
