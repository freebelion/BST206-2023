# Canvas1
Bu uygulama projesinde konuma göre yerleştirme yapan
**Canvas** panelini tanıtıyoruz.
Bu içerik sunucu iki boyutlu bir grafik yüzeyi gibidir.
"Çocuklarını", yani barındırdığı görsel öğeleri
koordinatlarına göre yerleştirir.

Çizgi veya şekil gibi basit çizim öğelerini görüntülemek
için genellikle onları bir **Canvas** panel içine yerleştiririz.
Bu proje örneğinde de bu türden şekillerin bir **Canvas**
üzerinde nasıl yerleştirileceğini gösterdik.

+ `<Line></Line>` XAML bloku ile bir çizgi oluşturduk.
  - `X1` özelliği çizgi başlangıç noktasının
     yatay (X) koordinatını belirlemek içindir.
  - `Y1` özelliği çizgi başlangıç noktasının
     dikey (Y) koordinatını belirlemek içindir.
  - `X2` özelliği çizgi bitiş noktasının
     yatay (X) koordinatını belirlemek içindir.
  - `Y2` özelliği çizgi bitiş noktasının
     dikey (Y) koordinatını belirlemek içindir.
  - `Stroke` özelliği çizgi rengini belirlemek içindir.
  - `StrokeThickness` özelliği çizgi kalınlığını belirler.

+ `<Rectangle>` öğesi bir dikdörtgen şekil oluşturur.
  - `Width` özelliği dikdörtgen genişliğini belirler.
  - `Height` özelliği dikdörtgen yüksekliğini belirler.
    - Genişliğe ve yüksekliğe aynı değeri vermek
      bir kare şekil oluşturur.
  - `Canvas.Left` ile `Canvas.Top` özellikleri dikdörtgenin
    **Canvas** üzerindeki sol üst köşe koordinatını belirlemek
    içindir.<br>
    (*Başka kapalı şekillerin koordinatlarını da
     aynı adlı özelliklerle belirleriz.*)
  - `Stroke` özelliği kenarlık rengini belirlemek içindir.<br>
    (*Başka kapalı şekillerin kenarlık rengini de
     aynı adlı özellikle belirleriz.*)

+ `<Ellipse>` öğesi bir elips (oval) şekil oluşturur.
  - `Width` özelliği elips genişliğini belirler.
  - `Height` özelliği elips yüksekliğini belirler.
    - Genişliğe ve yüksekliğe aynı değeri vermek
      bir daire şekli oluşturur. 
  - `Canvas.Left` ile `Canvas.Top` özellikleri elips şekli
    çevreleyen dörtgenin sol üst köşe koordinatını belirlemek
    içindir.
  - `Fill` özelliği iç dolgu rengini belirlemek içindir.<br>
    (*Başka kapalı şekillerin dolgu rengini de
     aynı adlı özellikle belirleriz.*)

+ `<Polygon>` ile atış hedefi olarak kullanabileceğiniz
  çok noktalı bir kapalı şekil oluşturabilirsiniz.<br>
  `Points` özelliğine atayacağınız karakter dizgisi içide
  köşe noktalarının X,Y koordinat çiftlerini sıralarsınız.
