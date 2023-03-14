# BST206-2023
Bu proje grubunda C# programlama diliyle
WPF tabanlı görsel uygulamalar geliştirecek
olan öğrencilere örnekler sunuyoruz.<br>
Umarız konuyla ilgilenen başka kişilerin de
bir şeyler öğrenmesine katkısı olacaktır.

## Grid1
Bu başlangıç örneğinde C# programlama diliyle
boş bir WPF masaüstü uygulaması oluşturuyoruz.
Visual Studio geliştirme ortamındaki proje
oluştururken şablon (*template*) seçimini
aşağıdaki gibi yaptık:
![](Resimler/Resim1.png)

Bu şablon seçimi aşamasında "WPF App" (WPF Uygulaması)
etiketli iki seçenek olduğunu görüyorsunuz.
Bizim tercih ettiğimiz ilk seçenek Windows dışındaki
işletim sistemlerinde de kullanılan .NET Core
tabanlı uygulama şablonudur.
Bu seçenek göreceli olarak daha yeni olandır.
Visual Studio eski sürümlerinde tek seçenek olan
"WPF App (.Net Framework)" seçeneğini tercih ederseniz
uygulamanız yalnızca Windows işletim sisteminde
çalışacaktır.
Bu örnekleri izlerken hangisini seçtiğiniz
pek de fark etmez.
Ciddi kodlar yazmaya başlayacağımız ileri örneklerde,
belki referans değişkenleri kullanan bazı komutlarda
küçük farklar görebilirsiniz.

Devam edelim: Şablon seçinden sonraki aşamada proje adını veriyoruz ve
projeyi oluşturacak sonraki aşamaya geçiyoruz:
![](Resimler/Resim2.png)

En son aşamada hangi .NET sürümünü kullanacaksınız
diye bir tercih formu daha çıkabilir.
Biz bu notları yazarken varsayılan seçenek
.NET 6.0 sürümüydü ama en son sürüm olan 7.0 da
tercih edebiliyorduk.
Biz varsayılan sürümü yeterli gördük.
Siz kendi tercihinizi yapabilirsiniz.
Tüm bu aşamaları geçip projeyi oluşturduk.
Karşımıza uygulama penceresinin tasarım görünümü
ve onun altında bu pencerenin görünümünü düzenleyen
XAML kodları çıktı:
```
<Window x:Class="Grid1.MainWindow"
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markupcompatibility/2006"
xmlns:local="clr-namespace:Grid1"
mc:Ignorable="d"
Title="MainWindow" Height="450" Width="800">
    <Grid>
    </Grid>
</Window>
```
Projenin **MainWindow.xaml** adlı dosyadında yer alan
bu kodların HTML kodları gibi göründüğünü fark etmişsinizdir.
XAML aslında tıpkı HTML gibi, <> etiketleriyle başlayıp
</> etiketleriyle kapanan tanım blokları kullanan bir dildir.
Örneğin, başlangıçtaki kalabalık tanım ile bir pencere
(**Window**) oluşturulmuştur.
Bu tanımın başlangıç etiketi (**tag**) ve bitişi arasında
ise pencere içerisinde yer alacak görsel öğelerin tanımları
vardır.
Bildiğimiz sade metin olarak yazılmış bu dosyayı okuyan
derleyici tanımları yapılan görsel öğelerin belirtilen
özelliklerle oluşturulmasını ve belirtilen şekilde
düzenlenmesini sağlayacaktır.
> Günümüzde web uygulamaları veya mobil uygulamalardaki
görsel arayüzleri oluşturmakta kullanılan
yöntemler de benzer olduğu için, görsel uygulamaları
geliştirmeye bu yoldan başlamak daha kolaylık
sağlayacaktır.

Bizim proje şablonu olarak "WPF Uygulaması" seçmemizin
nedeni de budur aslında:<br>
XAML yalnızca uygulama penceresinin görsel özelliklerini
belirler ve görünüm düzenini oluşturur.
Kullanıcının bu öğelerle etkileşmesini sağlayan ve
bu etkileşimlere göre eylemler gerçekleştiren
uygulama kodları ise ayrı bir dosyada,
projeyi ilk oluşturduğunuzda XAML dosyası ile
birlikte açılan **MainWindow.xaml.cs** 
dosyasında yeralmaktadır:

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Grid1
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
       public MainWindow()
       {
          InitializeComponent();
       }
   }
}
```

Bu iki dosya aslında uygulamanın ana penceresinin
(`MainWindow`) iki ayrı yüzü sayılırlar.<br>
Proje organizasyonu görünümünde de birlikte yer alırlar:
![](Resimler/Resim3.png)

Uygulama kodlarını içeren bu dosyayı kapatıp geçebilirsiniz.
Bu ilk denememizde yalnızca uygulama penceresinin
görsel özellikleri ve görünüm düzeni ile uğraşacağız.

Bu özellikleri veya düzeni değiştirmek için XAML
dosyasındaki kodları elledeğiştirmek yeterli olacaktır.
Bu ilk deneme için elle değiştireceğimiz özellikleri
sarı renkle belli ettik.
Pencere başlığını (`Title`) "Ana Pencere",
genişlik (`Width`) değerini "1000",
yükseklik (`Height`) değerini de "650" olarak değiştirdik.<br>
Siz de o özellikleri kendi istediğiniz şekillerde
değiştirmeyi deneyin; yaptığınız değişikliklerin
pencere tasarım görünümünü hemen değiştirdiğini
göreceksiniz.

Dilerseniz F5 kısayol tuşu ile *Debug* (hata ayıklama)
modunda, dilerseniz de CTRL+F5 tuş kombinezonuyla
*Release* (kullanıma hazır) modunda uygulamayı
çalıştırabilirsiniz.
Uygulama penceresi belirlediğiniz özelliklerle ekrana
gelecektir.

Hiçbir kod içermediği için henüz bir şey yapmayacaktır,
ama alıştığınız başka görsel uygulamalardaki gibi
uygulama penceresini küçültüp büyültebilecek
veya kenarlıklarından tutup çekerek boyutlarını
değiştirebileceksiniz.

## Grid2
İlk proje örneklerimizde WPF masaüstü uygulama
pencerelerinde standart olan kafes paneli (`Grid`)
tanıtmak istiyoruz.
Ama yeni başlayanlar proje geliştirme aşamalarını
daha iyi izlesinler diye,
tanıtımı tek bir proje ile yapmayacağız.
Onun yerine, önemli aşamaları ayrı projeler olarak
ekleyeceğiz.
Bu belgede de her aşamanın önemli yanlarını
ayrı ayrı anlatacağız.

İlk projemiz **Grid1**'in bir kopyasını oluşturup
**Grid2** diye yeniden adlandırdık.
Bu uygulamanın ana penceresinin görünümünü belirleyen
XAML dosyasını açtık.
Pencerenin içerik sunucusu
(*container*) olan kafes panelin XAML bloku
```
   <Grid>
   </Grid>
```
içinde herhangi bir yerde tıklayınca,
tasarım görünümünde pencere içindeki panel
sol ve üst kenarlarında kesikli çizgilerle
gösterilen bantlar varmış gibi gözüktü.

Sol kenar bandının belli bir yerinde tıklayınca,
kafes paneli iki yatay bölmeye ayırmış olduk:
![](Resimler/Resim4.png)

```
   <Grid.RowDefinitions>
   </Grid.RowDefinitions>
```
bloku içinde panel bölmelerinin yükseklik oranlarını
gösteren yeni tanımlar oluştuğunu görüyorsunuz.

"Kafes Panel" dediğimiz `Grid` türü içerik sunucuyu
(**container**) standart yapan şey
işte bu bölünme özelliğidir.

Birçok görsel uygulamada menü seçeneklerinin,
listeleyici kontrollerin, tıkladığınız düğmelerin,
içine yazı yazdığınız metin kutularının, vb.,
yanyana ve alt alta, bölmeli bir paneldeki gibi
yerleştiklerini hatırlarsınız.
Siz uygulama penceresini büyültüp küçülttükçe
bu panel bölmelerinin de orantılı olarak
büyüyüp küçülmesi bazı durumlarda kullanışlılık sağlayan
bir görsel etki oluşturacaktır.

Kafes panel bölmelerini ciddi bir uygulamada
kullanmadan önce, üst panel bölmesine bir
kontrol yerleştirelim.
Sonra da görünümünü ve konumunu belirleyen
özelliklerle oynayalım.

Öncelikle, yatay bölmelerin boyut orantısını
daha iyi fark edelim diye uygulama penceresini
biraz daralltık.
Genişliğini (`Width`) 400 piksel yaptık.
"Piksel" demişken, aslında pek de doğru bir şey yazmadık.
Normalde bilgisayarlarla bütünleşik veya ayrı kullanılan
ekran boyutlarına göre, gerçek piksel
(Türkçe olarak "görüntü noktacığı" mı desek?)
boyutları her biri için aynı değildir.

Bu nedenle, WPF için "piksel" dediğimiz şey,
aslında gerçek piksel boyutu değil,
standart kabul edilmiş özel bir boyut birimidir.
1 inç (2.54 cm) uzunluğun 1/96'sına eşittir.
Bu birim bazı kaynaklarda "*Device Independent Unit*"
(DIU) diye adlandırılır.

Araç Kutusunu (*Toolbox*) açıp,
orada listelenen kontrollerden metin bloğu
(`TextBlock`) kontrolünü seçtik,
ve sürükleyerek kafes panelin üst bölmesine yerleştirdik:
![](Resimler/Resim5.png)

> Bu kontrol içinde bir metin görüntüler,
ama yalnızca görüntüler.
Belki daha alışkın olduğunuz "Metin Kutusu" (`TextBox`)
kontrolünden farklı olarak,
metin girişine veya değişikliğine izin vermez.

Her neyse, bu metin bloğu kafes panelin
XAML kod bloğunda aşağıdaki gibi görünüyordu:
```
<Grid>
   <Grid.RowDefinitions>
      <RowDefinition Height="51*"/>
      <RowDefinition Height="266*"/>
   </Grid.RowDefinitions>

   <TextBlock HorizontalAlignment="Left"
              VerticalAlignment="Top"
              Margin="49,32,0,0"
              TextWrapping="Wrap"
              Text="TextBlock" />
</Grid>
```

Sizin denemenizdeki sonuç tam böyle olmayabilir.
Biz metin bloğu kontrolünün XAML tanımındaki
özellikleri okunur olsun diye satırlara ayırdık,
satırların sırasını değiştirdik ve bazılarını hizaladık.
Siz kontrolü çekip bıraktığınızda
farklı bir yere koymuşsanız,
konum özellikleri de farklı olmuştur.

Kontrolün en son özelliğinden başlayalım:<br>
`Text` özelliği bloğun görüntülediği karakter dizgisidir.
Biz buraya "Metin Blok Kontrol" yazıp geçtik.
Siz istediğiniz başka bir sözcük veya cümle yazın.

Başka değişiklikler yapmadan önce de uygulamayı çalıştırıp
denedik:
![](Resimler/Resim6.png)

Gördüğünüz gibi, yeni belirlediğimiz metin gözüküyordu,
ama hem kutunun içindeki yazı biraz küçüktü,
hem de kutunun nerede başlayıp nerede bittiği
belli olmuyordu.

WPF uygulamalarında hazır kullandığımız
pencere ve kontrol gibi görsel öğeler için standart
özellikler geçerlidir.

Yazı boyutuyla ilgili bir özellik görmemiştik
ama geri planda onun da bir ayarı vardı.
Bu ayarı değiştirmek için `TextBlock` kontrolünün
XAML tanımına `FontSize` (Yazı Tipi Boyutu) özelliğini
ekleyip farklı bir değer atayalım.

Bir de kutunun boyutları belli olsun diye,
`Background` özelliğiyle ona farklı bir
geri plan rengi verelim:
```
<TextBlock HorizontalAlignment="Left"
           VerticalAlignment="Top"
           Margin="49,32,0,0"
           TextWrapping="Wrap"
           Background="Beige"
           FontSize="24"
           Text="Metin Blok Kontrol" />
```
Şimdiki görünümü daha belirgindir:
![](Resimler/Resim7.png)

Peki bu kontrolün boyutlarını belirleyen özellikler nerede?
Bu XAML tanımında genişlik (`Width`)
ve yükselik (`Height`) özelliklerini görmüyoruz.

Görmüyoruz, çünkü onlar yazı boyutuna göre
otomatik belirlenmiştir.
Kontrol genişliği kutu içindeki metnin sığacağı kadardır.
Yüksekliği de -üst ve altta biraz paylar bırakarak-
karakter yükseliğine göre belirlenmiştir.

Kontrolün konumunu belirleyen özelliklere gelince,
belki Windows Forms gibi başka görsel programlama
platformlarındaki gibi
sol konum (`Left`) veya üst konum (`Top`)
için ayrı özellikler yoktur.
> En azından, kafes panel (`Grid`) için
böyle özellikler yoktur.
Ne demek istediğimizi daha sonra açıklarız.

Kafes panel (`Grid`) bölmeleri içine yerleştirilen
kontroller kendileri bölme kenarlarına göre hizalarlar.
Konumu belirleyen ölçü de bölme kenarları ile
kontrol kutusu arasında kalan boşluklardır.
Yani, bu örnekteki `TextBlock` kontrolü
konumunu belirleyen özellik
`Margin` (Kenar Boşluğu) özelliğidir.

Bu özellikte dört sayısal değer görüyoruz.
Bunlardan ilki sol kenar boşluğu (*left margin*),
ikincisi de üst kenar boşluğudur (*top margin*).
Biz kontrolü elle yerleştirince atanan ilk
değerler yerine:
```
Margin="10,10,0,0"
```
yazın.

Artık blok kontrolün üst bölme kenarlarına
daha yakın olduğunu ve siz uygulamayı çalıştırıp
pencere boyutlarını değiştirseniz de bu boşlukların
korunduğunu göreceksiniz.

Bu arada, şu soru aklınıza takılmıştır belki de:
`Margin` özelliğindeki son iki değer neyin nesi acaba?

Üçüncü değer sağ marjin (*right margin*)
ve son değer de alt marjindir (*bottom margin*).

Evet, bu iki değer sıfırdır, ama blok kontrolü
ne sağa yapışmıştır, ne de alta.

Bunun nedeni kontrolün hizalanma şeklidir.
Yatay hizalama şeklini belirleyen
`HorizontalAlignment` özelliği "Left" değerini taşıyor.
Yani kontrol sola hizalanmıştır.
Bu nedenle de, sağ marjin değeri 0 olsun,
ya da başka bir değer olsun, dikkate alınmıyor.

Ama `HorizontalAlignment="Right"` şeklinde
bir değişiklik yaparsanız, kontrolün üst bölmenin
sağ kenarına yapıştığını göreceksiniz.

Benzer olarak, alt marjin değeri de dikkate alınmıyordu,
çünkü dikey hizalama (`VerticalAlignment`)
üst kenarı ("Top") esas alıyordu.<br>
`VerticalAlignment="Bottom"` şeklinde bir
değişiklik yaparsanız,
kontrol kutusu kafes panelin üst bölmenin
alt kenarına yapışacaktır.

Peki hizalama özelliklerini devre dışı bıraksak ne olurdu?
Bunu görmek için `HorizontalAlignment` ve
`VerticalAlignment` özelliklerini sildik.
O zaman `Margin` özelliğinin dört değerinin de
etkin olduğunu gördük:
![](Resimler/Resim8.png)

Sol ve üstten on birim boşluk varken,
kutu sağ ve alt kenarlara yapışıktı.
`Margin` için dört değil de tek bir değer verince,
onu da "10" yaptık,
kontrolün üst bölmeye göre her taraftan 10 birim
boşluk kalacak şekilde yerleştiğini gördük.

`Margin` özelliğini de iptal edince,
artık kontrol üst bölmeyi tamamiyle dolduruyordu.
Genişliği de artık metin uzunluğuna bağlı değildi.
Yüksekliği de yazı boyutundan bağımsızdı.

Bu durumdayken deneme amaçlı çalıştırdık
ve uygulama penceresini büyültüp küçülttüğümüzde
blok kontrolün de pencereyle orantılı boyutlandığını gördük;
genişliği pencere iç genişliği ile aynı kalırken,
yüksekliği üst bölmenin pencereye orantısıyla değişiyordu.
![](Resimler/Resim9.png)

Sağ altta resmini gösterdiğimiz son denemede
`TextBlock` kontrolünün `TextWrapping` özelliğinin
ne işe yaradığını fark ettik:
Bu özelliğin şimdiki değeri **"Wrap"** olduğu için
kutu içeriğindeki metni gerekince "alta sarıyordu"
(*wrapping*).
Metin uzunluğu kutu genişliğine sığmayınca
kontrol adı da bölünmüş ve bir kısmı alta kaymıştı.

Artık bu uygulama penceresindeki kafes panelin (Grid) yatay bölmelerinin boyut oranlarına
bakmalıyız:
```
   <Grid.RowDefinitions>
      <RowDefinition Height="51*"/>
      <RowDefinition Height="266*"/>
   </Grid.RowDefinitions>
```

Yukarıdaki `RowDefinitions` bloğu kafes panelin
yatay bölme (yani "satır", row) tanımlarını içeriyor.

Satır tanımını yapan her iki `RowDefinition` öğesindeki
`Height` özelliği de o satırın, yani yatay bölmenin
yüksekliğini veriyor.

Ama bu yükseklikler sabit değerler değil,
aslında orantılı boyutlardır.
Örneğin, üst bölme (ilk satır tanımı) için
yükseklik 51 birim, ama yanındaki yıldız
onun orantılı ya da göreceli bir ölçü
olduğunu gösteriyor.
Diğer bölme yüksekliği de yıldızlı verilmiş,
yani o da göreceli bir ölçü.

Kısacası, her iki yükseklik de aslında kafes panelin
(ki o da uygulama penceresinin iç bölgesini kaplıyor)
yüksekliğiyle orantılı oluyorlar.
Üst bölme yüksekliği kafes panel yüksekliğinin yaklaşık
%16'sı oluyor.
Bu oranı 51 değerini (51 + 266) toplamına bölerek
elde ettik.

Bu değerleri elle değiştirerek yatay bölme orantılarını
değiştirebiliriz.
Üst bölme için yüksekliği "50*" ,
alt bölme için de "250*" yapsak,
iki bölmenin yükseklik orantıları
(kafes panelyüksekliğine göre) 1/6 ve 5/6 olacaktır.
Önemli olan işte bu orantılardır.
Bu yükseklik ölçülerini "50*" yerine "1*",
"250*" yerine de "5*" yazsak,
yükseklik orantıları yine aynı olurdu.
Burada göstermedik, ama siz deneyip görün.

Ama `Grid` bölme tanımları için
yükseklik ölçüsünü yıldız sembolü olmadan yazarsak,
işte o zaman ilgili bölme yüksekliğini sabitlemiş oluruz.

Biz üst bölme yüksekliğini "50*" yerine
"50" diye değiştirip bir deneme yaptık.
Uygulamayı çalıştırdığımızda, pencere yüksekliğini
değiştirsek bile `TextBlock` kontrolünün
yüksekliğinin aynı kaldığını gördük.

## Grid3
Bu denememizde iç içe kafes paneller (Grid) yerleştireceğiz.
Bu paneller içinde hem yatay bölmeler,
hem de dikey bölmeler oluşturmayı da göstereceğiz.

Bunun için çözüm grubuna yeni bir WPF uygulaması
projesi ekledik.
Uygulama penceresinin boyutlarını 400x350 yaptık
(`Width="400"`, `Height="350"`).

Bu uygulama penceresini (tuşlu, elektronik tipten)
bir hesap makinesi gibi düzenleyeceğiz.
> Büyükbabanızdan kalan çalışma masasında
öyle bir şey görmüş olabilirsiniz.

Tuşları temsil edecek olan düğme (`Button`)
kontrolleri bir şey yapmayacaklar,
ama en azından onları nasıl yerleştirdiğimizi göreceksiniz.

Uygulama penceresini iki yatay bölmeye ayırmakla
işe başlayacağız. Üst panelde hesap makinesi ekranını
temsil eden bir metin blok (`TextBlock`) kontrolü olacak.

Bu projedeki değişiklikleri bölme işini tasarım görünümünde
değil, penceredeki kafes panelin XAML tanım blokunda
yapacağız.
Örneğin, önceki denememizde gördüğümüz yatay bölme
tanımlarını (`RowDefinitions`) elle ekleyeceğiz:
![](Resimler/Resim10.png)

Bu ekran resmindeki gibi, "akıllı tamamlayıcı"
(*Intellisense*) kafes panelin XAML bloku içine
konabilecek kodların bir listesini getirirken,
en olası iki seçeneği yıldızlı olarak
listenin başına koymuştu.

Biz satır (yatay bölme) tanımları oluşturmak için
`Grid.RowDefinitions` seçeneğini tercih edip ekledik.
> *Intellisense* kod yazarken yardımcı olacaktır,
ama her zaman bu şekilde çalışmayabilir;
yani, hazıra konmaya çok da alışmayın.

Ekran temsil edecek kontrolü yerleştireceğimiz
üst bölmenin yüksekliği sabit (75 DIU) olsun,
alt bölme de geri kalan yüksekliği tümden alsın istemiştik.
Bunun için yatay bölmelerin XAML tanımlarını
aşağıdaki gibi, elle yazdık:
```
<Grid>
   <Grid.RowDefinitions>
      <RowDefinition Height="75"/>
      <RowDefinition Height="*"/>
   </Grid.RowDefinitions>
</Grid>
```
Şimdi üst bölmeye ekranı temsil edecek kontrolün
XAML tanımını kafes panelin (Grid) XAML bloku içine,
ama satır tanımlarının dışına koymalıyız:
```
<Grid>
   <Grid.RowDefinitions>
      <RowDefinition Height="75"/>
      <RowDefinition Height="*"/>
   </Grid.RowDefinitions>

   <TextBlock Text="Ekran" Background="Beige"/>
</Grid>
```
Kontrolün içine geçici bir metin koyduk
ve ayırt edebilmemiz için bir de renk uydurduk.
Uygulamayı çalıştırıp nasıl göründüğüne bakabilirsiniz.
> Kutu içindeki temsili metin "Ekran" fazla küçük;
bunu kabul ediyoruz, ama çözümü size bırakıyoruz.

Şimdi, bu ekran kutusunun altında rakam ve işlem tuşları
olacak. Bizim niyetimiz alt bölmeyi iki dikey bölmeye
ayırmak. Sol bölmede rakam tuşları, sağ bölmede de
işlem tuşları olsun istiyoruz.

Peki, bu ikinci bölme işlemini nasıl yapacağız?
Bunun bir yolu, uygulama penceresindeki asıl kafes
paneli gerektiği kadar yatay ve dikey bölmelere
ayırmak olabilirdi.
En son aşamada ekranı temsil edecek TextBlock kontroünü
üst tarafı tek başına dolduracak şekilde yayardık.

Onun yerine, ana panelin alt bölmesine
ikinci bir kafes panel, daha doğrusu,
bir iç panel yerleştireceğiz:
```
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="75"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>

    <TextBlock Text="Ekran" Background="Beige"/>

    <Grid Background="Aqua">
    </Grid>
</Grid>
```
Bu ikinci kafes paneli kendi içinde dikey bölmelere
ayıracağız; o bölme tanımlarını da bu iç panelin
XAML tanım bloku içine yerleştireceğiz.
Fakat, sorun şu ki, bu iç panel doğru bölmede değil.
Bunu ayırt edici renginden anlıyoruz.
Alt bölmeye değil de, üst bölmeye yerleşmiş
ve daha önce eklediğimiz ekran kutusunun üstünü kaplamış.

Bunun nedeni kafes panel içindeki öğelerin
-farklı bir seçim yapılmadığı durumda-
hepsinin ilk (sol üst) bölmeye yerleşmesidir.
Birden fazla bölme varsa, her öğeyi ait olduğu
bölmeye yerleştirmek için satır ve sütun
numaralarını vermemiz gerekir.
Bu iç panelin alt bölmeye yerleşmesini için şu
düzenlemeyi yaparız:
```
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="75"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>

    <TextBlock Grid.Row="0" Text="Ekran" Background="Beige"/>
    
    <Grid Grid.Row="1" Background="Aqua">
    </Grid>
</Grid>
```
yatay bölme numarasını `Grid.Row` özelliğiyle belirledik,
ama bu özellik panel içindeki öğeye ait bir özellik olduğu
için, kontrolün kendisine ait XAML tanımına yerleştirdik.

Normalde bu özellik değerinin 0 olacağı varsayılır;
dolayısıyla biz o özelliği kullanmıyorken,
her iki öğe de (hem `TextBlock` kontrolü,
hem de ikinci `Grid` panel) üst bölmeye yerleşmişti.

İç kafes panel için bu değeri 1 diye değiştirdik.
Elimiz değmişken, `TextBlock` kontrolü için de
üst bölmede olduğunu belli edecek özellik atamasını ekledik.

İç kafes panelin dikey bölmelerini de onun
kendi XAML tanım bloku içine yerleştirdik:
```
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="75"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>

    <TextBlock Grid.Row="0" Text="Ekran" Background="Beige"/>
    
    <Grid Grid.Row="1" Background="Aqua">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="3*"/>
            <ColumnDefinition Width="2*"/>
        </Grid.ColumnDefinitions>
    </Grid>
</Grid>
```
Bütün bu değişiklikleri yaparken, ne kafes panellerine,
ne de metin blok kontrolüne isim vermedik.
Naşka bazı görsel programlama platformlarında
böyle yapamazdık.
Belki siz de bunu kötü bir alışkanlık diye düşündünüz.

Bu konuda şöyle bir açıklama getirebiliriz:
WPF uygulamalarında kontroller isim gerektirmezler,
çünkü bazı uygulamalarda önceden tanımlanmış şablonlar
aracılığıyla otomatik oluşturulacaklardır.
> Kontrol içeriklerini ve özellliklerini
kodlar aracılığıyla değiştireceğimiz zaman
onlara isim vermemiz gerekir.
Bunu gelecek örneklerde göstereceğiz.

Bu iç panelin sol bölmesinde rakam düğmeleri,
sağ bölmesinde ise işlem düğmeleri olacak.

Bu düğmelerin de grup olarak alt alta veya yan yana
düzenlenmeleri gerekecek.
Demek ki iç kafesin iki dikey bölme içine de
birer kafes panel (`Grid`) yerleştireceğiz:
```
    <!--Rakam düğmelerini barındıran kafes panel-->
    <Grid Grid.Column="0">
    </Grid>
    <!--İşlem düğmelerini barındıran kafes panel-->
    <Grid Grid.Column="1">
    </Grid>
```
Bu en iç panellerin yerlerini ve boyutlarını
ayırt etmeniz için renk kullanmadık,
ama amaçlarını belli edecek (HTML tarzı)
açıklamalar ekledik.
Sağ panelde alt alta gözükecek işlem düğmeleri için
eşit yükseliğe sahip dört yatay bölme yeterlidir:
```
    <!--İşlem düğmeleri yatay bölmelerde gözükecek.-->
    <Grid.RowDefinitions>
    <!--Yüksekliği belirtilmeyen bu yatay bölmeler eşit yüksekliğe
    sahip olacak.-->
        <RowDefinition/>
        <RowDefinition/>
        <RowDefinition/>
        <RowDefinition/>
    </Grid.RowDefinitions>
```
İşlem sembolleri taşıyan düğmeleri yatay bölme numaralarıyla bu panel içine
yerleştiriyoruz:
```
    <Button Content="+" Grid.Row="0"/>
    <Button Content="-" Grid.Row="1"/>
    <Button Content="*" Grid.Row="2"/>
    <Button Content="/" Grid.Row="3"/>
```
İç panelin sol bölmesinde de yine eşit yüksekliğe
sahip yatay ve bölmeler, ama onların yanında da
eşit genişliğe sahip dikey bölmeler koyduk.

Rakam etiketli düğmeler de o panele yerleştirdik.
Sonuçları github projesinde inceleyebilirsiniz.
Ya da geri kalan adımlarını kendiniz tamamlarsınız.

Bir şekilde uygulama penceresini son haline getirip
uygulamayı çalıştırmayıdenerseniz,
siz pencereyi büyültüp küçülttükçe
düğme boyutlarının pencere boyutlarıyla
orantılı değiştiğini göreceksiniz.

Boyutları veya konumlarıyla ilgili hiç bir özellik
belirlemediğimiz için, düğmeler ait oldukları
panel bölmelerini tam dolduruyordu.
Yani, aslında boyut orantıları kafes panel bölmelerinin
yerleşim düzeninin sonucuydu.

Tamam, ama düğmelerin bu şekilde büyüyüp küçülürken
birbirlerine yapışık kalmaları belki size hoş gelmemiştir.

Hepsinin de etraflarında kenar boşluğu
olsun isterseniz, her birinin XAML tanımına
`Margin` özelliği ekleyip, diyelim 5 DIU (standart piksel)
gibi değer atamak isteyebilirsiniz.

İşte bunun kolay bir yolu var:
Hani XAML kodları bir çok açıdan HTML gibi yazılıyordu ya,
tıpkı HTML sayfalarındaki `<style></style>`
stil tanım blokları gibi,
XAML kodlarında da görünümü belirleyecek
stil tanımları yazabiliriz.

Bunun için görsel öğelerin XAML tanım bloklarından önce,
pencerenin görsel kaynaklarının tanımlanacağı
ayrı bir XAML bloğu açarız:
```
<!--Bu blokta pencerenin kullandığı görsel kaynaklar olacak.-->
<Window.Resources>
</Window.Resources>
```
Buraya da standartlaştıracağımız özellik değerlerini
belirleyen`Style` (stil) tanımları koyarız.

Düğmeler için kenar boşluğu standart olsun istiyorduk.
Bunun için stil tanımının hedef türünü (`TargetType`)
`Button` diye belirleriz:
```
<!--Örnek olarak, bu penceredeki tüm düğmelere uygulanacak bir stil tanımı koyduk.-->
<Style TargetType="Button">
    <Setter Property="Margin" Value="5"/>
</Style>
```
Böyle bir stil tanım bloku içinde standart olarak
uygulansın, istediğimiz özellik değer atamalarını
`Setter` tanımları olarak ekleriz.
Bu tanımlarda özelik adı `Property` olarak gözükür;
atanacak standart değer de Value olarak gözükür.

Bu değişiklikleri de yapıp deneyin;
artık sözde hesap makinesinin düğmeleri
etraflarında 5'er DIU boşluk kalacak şekilde
yerleşmiş olacaktır.