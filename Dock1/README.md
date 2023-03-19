## Dock1
Bu proje aslında içerik açısından
**StackWrap1** projesiyle aynı.
Yine sıralama düzenleri farklı olan
iki **StackPanel** ve bir **WrapPanel**,
ve onların da içlerinde metin blok
(**TextBlock**) kontrolleri var.
Hatta, bunların yerleşim düzenleri bile
neredeyse aynı.

Ama önceki projeden farklı olarak,
bu projedeki uygulama penceresinin
içerik sunucusu bir kafes panel
(**Grid**) değil. Onun yerine, içerdiği
görsel öğeleri belli kenarlara sabitlemek
için bir **DockPanel** kullandık.

Bundan başka, **StackPanel** ve **WrapPanel**
içerik sunucularının her birini "Çerçeve
Paneli" diyebileceğimiz **Border** içine koyduk.
Şimdi bunlar hakkında önemli bir kaç noktayı
özetleyelim:

+ Üstteki **StackPanel**'i barındıran 
  ilk çerçeve paneli **Border** için
  `DockPanel.Dock = Top` özelliği
  onu **DockPanel**'in üstüne sabitliyor.

+ Soldaki **StackPanel**'i barındıran 
  ikinci çerçeve paneli **Border** için
  `DockPanel.Dock = Left` özelliği
  onu **DockPanel**'in soluna sabitliyor,
  ama ilk tanımlanan **Border** üst kenarı
  kaptığı için, bu ikincisi altta kalan
  bölümün soluna sabitleniyor.

+ **WrapPanel**'i barındıran son **Border**
  için sabitleyici bir özellik ataması yok;
  dolayısıyla, bu sonuncu eleman
  **DockPanel**'in geri kalan boşluğunu
  serbetçe dolduruyor.


+ **DockPanel.Dock** özellik atamaları
  **DockPanel**'in "çocukları" için
  yerleşim düzenini belirler, ama onların
  boyutları hakkında hiç bir sınırlama
  getirmez.

+ Çerçeveli **Border** panelleri de
  yalnızca içerikleri etrafında bir çerçeve
  eklerler; onlar da içerdikleri panel
  veya kontrol için boyut sınırlaması getirmezler.

+ Bu durumda, boyut veya konum belirleyecek
  başka özelliklerin yokluğunda, üstteki
  **StackPanel** üst kenara sabitlendiği
  için, pencereyi kapsayan **DockPanel**
  genişliğini tam dolduruyor.
  Ama bu **StackPanel**'in yüksekliği
  yalnızca içeriğinin gerektirdiği kadar.
  İçindeki metin blokları içlerindeki yazının
  yüksekliği kadar oluyor, dolayısıyla
  onları barındıran **StackPanel** yüksekliği de
  metin bloklarının sığacağı kadar oluyor.

+ Alt bölümün solunu dolduran **StackPanel**
  ise alt bölümün tüm yükseliğini dolduruyor,
  ama yalnızca içerdiği metin bloklarının
  sığacağı kadar bir genişliğe sahip.
  Metin bloklarının genişliği de içlerindeki
  yazıları sığdıracak kadar.

+ Sona kalan **WrapPanel** önceki iki
  **StackPanel**'den kalan boşluğu serbestçe
  dolduruyor. Bu panelin içerdiği metin
  bloklarının hem genişlikleri, hem de
  yükseklikleri içlerindeki yazıların
  sığacağı kadar oluyor.

