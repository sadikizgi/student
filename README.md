# student

NESNE YÖNELİMLİ (C# ) 
(Benzetim: Kaplumbağa ve Tavşan) İki yarışmacı da 70 tane karelik bir yolun ilk
karesinden yarışa başlayacaktır (Yolun solundan). Her kare yarış boyunca
yarışmacıların bulunabileceği yerleri ifade etmektedir. 70’inci kareye ilk varan ya
da geçen, yarışmayı kazanacaktır. Yarış kaygan bir zeminde olduğu için
yarışmacılar zaman zaman kayabilmektedir. Saniyede bir kere rastgele bir sayı
üretilerek yarışmacıların hangi hareketi gerçekleştireceği belirlenecektir.
Aşağıdaki şekilde yarışmacıların hangi hareketi yüzde kaç olasıkla
gerçekleştirdiği verilmiştir.
Eğer yarışmacılardan biri 1 karesinden (ilk kareden) geriye kayarsa onu yine
1 karesine alın (negatif değerli kareler kullanmayın. )
Örneğin Kaplumbağa için, üretilen sayı i; 1 <= i<=5 ise “hızlı yürüyüş” hareketi,
6<=i<=7 ise “kayma” hareketi, 8<=i<=10 için ise “yavaş yürüyüş” hareketi
gerçekleştirilecektir. Her saniyede, tavşan ve kaplumbağanın 70 parçalık yoldaki
yerleri T ve K harfleri ile gösterilmelidir. İkisi aynı kareye düşerse T ve K yerine
OUCH yazdırılmalıdır.
Yarış sonunda kaplumbağa kazanırsa “KAPLUMBAĞA KAZANDI!!! OLEY!!”
mesajı ekrana yazılmalıdır. Eğer tavşan kazanırsa “TAVŞAN KAZANDI . YUH”
mesajı, beraberlik olursa “BERABERE” mesajı ekrana yazdırılmalıdır
.
Hayvan Hareket Tipi Yüzdesi H areketin Kendisi
Kaplumbağa Hızlı Yürüyüş 50% 3 kare sağa
Kayma 20% 6 kare sola
Yavaş Yürüyüş 30% 1 kare sağa
Tavşan Uyuma 20% Hareketsiz
Büyük Sıçrama 20% 9 kare sağa
Büyük Kayma 10% 12 kare sola
Küçük Sıçrama 30% 1 kare sağa
Küçük Kayma 20% 2 kare sola
