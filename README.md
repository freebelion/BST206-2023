# BST206-2023
Bu proje grubunda C# programlama diliyle
WPF tabanlı görsel uygulamalar geliştirecek
olan öğrencilere örnekler sunuyoruz.<br>
Umarız konuyla ilgilenen başka kişilerin de
bir şeyler öğrenmesine katkısı olacaktır.

Her projenin geliştirme adımlarını
projeye ait README dosyasında gösterdik.
Projelerin hangisinin neyle ilgili
olduğunu göstermek için de burada
başlıklarını ve ilk paragraflarını
listeledik.

## Grid1
Bu başlangıç örneğinde C# programlama diliyle
boş bir WPF masaüstü uygulaması oluşturuyoruz.

## Grid2
İlk proje örneklerimizde WPF masaüstü uygulama
pencerelerinde standart olan kafes paneli (`Grid`)
tanıyoruz.

## Grid3
Bu denememizde iç içe kafes paneller (Grid) yerleştireceğiz.
Bu paneller içinde hem yatay bölmeler,
hem de dikey bölmeler oluşturmayı da göstereceğiz.

## StackWrap1
Bu projeyi iki farklı içerik sunucuyu,
**StackPanel** (yığın panel)
ve **WrapPanel** (sarıcı panel)
tanıtmak için oluşturduk.

## Dock1
Bu proje aslında içerik açısından
**StackWrap1** projesiyle aynı.
Ama önceki projeden farklı olarak,
bu projedeki uygulama penceresinin
içerik sunucusu bir kafes panel
(**Grid**) değil. Onun yerine, içerdiği
görsel öğeleri belli kenarlara sabitlemek
için bir **DockPanel** kullandık.

## Canvas1
Bu uygulama projesinde konuma göre
yerleştirme yapan çizim panelini
(**Canvas**) tanıtıyoruz.
Bu içerik sunucu iki boyutlu
bir grafik yüzeyi gibidir.
"Çocuklarını", yani barındırdığı
görsel öğeleri koordinatlarına
göre yerleştirir.

## StyleTemplate1

Bu projede WPF masaüstü uygulamalarında kullanabileceğimiz
kontrollerin içeriklerini veya görünümlerini değiştirmek
için stil (**Style**) ve şablon (**Template**) tanımlamayı
öğreneceğiz.

## ListBox1

Bu projede listeleyici kontrollerin
en basit olan **ListBox**
(Liste Kutusu) kontrolü ile
denemeler yapacağız.

## Binding1
Bu projede bir liste kutusu
(**ListBox**) kontrolünün eleman listesini
`{Binding}` ile dinamik değişen
bir listeye bağlıyoruz.

## ItemsControl1
Bu projeyle liste kutusu (**ListBox**) kontrolünün
"atası" diyebileceğimiz, genel amaçlı listeleyici
kontrolü, **ItemControl** tanıtıyoruz.