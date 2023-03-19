## StackWrap1
Bu projeyi iki farklı içerik sunucuyu,
**StackPanel** (yığın panel?)
ve **WrapPanel** (sarıcı panel?)
tanıtmak için oluşturduk.

Uygulama penceresinin dış çerçevesini
oluşturan kafes panelin (**Grid**) 
dört bölmesi var;
iki yatay bölme için iki `RowDefinition`,
iki dikey bölme için de iki
`ColumnDefinition` var.<br>
Bu bölmeler kafes panelin genişliğini de,
yüksekliğini de, %30-%70 oranlarında
paylaşıyorlar.

Bu bölmelere koyduğumuz yeni paneller
içine de uluslararası döviz kısaltmalarını
içeren metin blok (**TextBlock**) kontrollerini
yerleştirdik.
Tek amacımız bu sunucuların *containers*
görünümünü ve düzenini belirleyen
önemli özellikleri göstermek.

+ Kafes panelin üst bölmesine koyduğumuz
  **StackPanel** iki sütuna da yayılsın
  diye, XAML tanım başlığına
  **`Grid.ColumnSpan = "2"`** atamasını ekledik.

+ Alt sol bölmeye koyduğumuz **StackPanel**
  içindeki metin blokları alt alta sıralanmış.
  **StackPanel** için normal sıralama budur.
  > Çünkü **StackPanel** için sıralama yönünü
    belirleyen `Orientation` özelliğinin
    varsayılan değeri `Vertical` (Dikey).

+  Ama üst bölmeyi dolduran **StackPanel** için
  `Orientation` (Yön) özelliğine `"Horizontal"`
   (Yatay) değerini atadık. Böylece üstteki
   yığın paneldeki bloklar yan yana sıralandılar.

+ Sıralama yönü yatay olan üstteki
  **StackPanel** içindeki metin bloklarının
  dar olduklarına dikkat edin;
  bunların genişlikleri içlerindeki yazıların
  sığacağı kadardır.<br>
  Ama yüksekliklerini belirleyecek başka özellik
  olmadığı için, her birinin yüksekliği
  onları barındıran **StackPanel** yüksekliği
  ile aynıdır.

+ Öte yandan, sol alttaki **StackPanel** içindeki
  metin bloklarının yükseklikleri içlerindeki
  yazıları sığdıracak kadar, ama genişlikleri
  **StackPanel** genişliğini tam dolduruyor,
  çünkü genişliklerini sınırlayacak başka
  özellikler yok.

+ Her iki **StackPanel** içindeki kontrollere
  boyutlarını belirleyecek başka özellikler
  (`Margin`, `Width`, `Height`, vb.)
  eklerseniz, o zaman boyutları onları
  barındıran **StackPanel** sunucularının
  boyutlarına bağlı olmayacaktır.
  > Deneyin, görün.

+ Sağ alt bölmeye yerleştirdiğimiz diğer
  içerik sunucu **WrapPanel** için de
  sıralama yönünü `Orientation` özelliği
  belirler, ama bu panel içindeki kontroller
  tek bir sırayla sınırlı değildir.<br>
  Bu örnekte biz sıralama yönünü yatay
  olarak belirledik (`Orientation = "Horizontal`),
  ama yatay sıralanan kontroller satır bittiğinde
  bir alt satıra geçip yatay sıralanmaya devam
  ettiler.
  > Bu yüzden bu tür panele *sarıcı panel* dedik.

