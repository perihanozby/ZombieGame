PROJENİN AMACI:  

Bu oyunun temel unsurları arasında, bir ana karakterin varlığı, karmaşık bir hikaye örgüsü ve bu hikayeyi destekleyen dinamik zombi akınları bulunmaktadır.
Karakter, zombi saldırılarına karşı durarak hayatta kalmaya çalışacak ve her dalgayı bertaraf etmek için stratejik mücadeleler verecektir.Oyunun asıl hedefi,
zombi istilasının getirdiği tehlikelerle başa çıkmak ve nihayetinde kurtuluşa erişmektir. Bu bağlamda, oyuncunun beceri, strateji ve dayanıklılığı test 
edilerek zorlu bir hayatta kalma deneyimi sunulacaktır. 

 

PROJEDE YAPILANLAR AYRINTILI 

1) Gerekli Asset'lerin Kurulumu: 

Mixamo'dan karakter modelinin indirilmesi. 

Animasyonların indirilmesi. 

İndirilen varlıkların Unity3D'ye aktarılması. 

Karakterin texture sorunlarının düzeltilmesi. 

Karakter texture'larının giydirilmesi ve materyallerin çıkarılması. 


2) Karakterin Hareket Özellikleri: 

Karaktere hareket etme özelliği kazandırıldı. 

Hareket sırasında animasyonların da çalışması sağlandı. 

Fiziksel bileşenler eklenerek karakter kullanıma hazır hale getirildi. 


3) Kamera ve Kullanıcı Takip Sistemi: 

Karakteri takip edecek kameranın kullanıcıyı takip etmesi için kod yazıldı. 

Karakterin, kameranın baktığı yöne dönmesi ve nişan alması sağlandı. 


4) Zombilerin Eklenmesi: 

Oyunda öldüreceğimiz zombilere giriş yapıldı. 

Gerekli animasyonlar indirilip, zombilerin hasar alması ve ölmesi sağlandı. 

Karakterin ateş etme sistemi yapıldığında zombilerin öldüğünün test edilmesi sağlandı. 


5) Ateş Etme Sistemi: 

Karakterin ateş etmesi sağlandı. 

Karakter, ekranın ortasından (crosshair'dan) bir ışın yolluyor ve bu ışın zombiye değdiğinde zombiye hasar veriyor. 

Karakterin yürürken de ateş edebilmesi için layer mask ile karakter ortadan ikiye bölündü. 


6) Zombilerin Hedef Takip ve Saldırı Sistemi: 

Zombilerin hedefi takip etmesi ve saldırması için kodlar yazıldı. 

Kodlarla birlikte zombilere animasyonlar da eklendi. 

Karakterimizin canını azaltacak kodlar yazıldı. Zombiler vurduğunda karakterimizin canı azalıyor ve canı 0'ın altına düştüğünde karakter ölüyor. 


7) Ateş Etme ve Animasyon Entegrasyonu: 

Karakterin ateş etme olayını animasyon eventi ile bağladık, böylece her silah geri teptiğinde ateş edebilir hale geldik. 

Karaktere silah ve silaha ateş etme efekti (muzzle flash) eklendi. 

Kullanılan silaha mermi eklendi ve mermisi bittiğinde şarjörün değiştirilmesi sağlandı. Mermi olmadığında ateş edilemeyecek şekilde ayarlandı. 

İlgili animasyonlar da eklendi.


8) Kullanıcı Arayüzü Tasarımı: 

Oyunun kullanıcı arayüzü tasarlandı. 

Bu arayüz sayesinde karakterin canı ve kalan mermi miktarı görülebiliyor. 

ESC tuşuna basıldığında oyun duruyor. 


9) Ses Efektleri ve Müzik: 

Ateş etme ve mermi değiştirme sesleri eklendi. 

Arka planda müzik çalması sağlandı. 

Zombilerden sesler geliyor. 
