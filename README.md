# 6.Hafta-Lab-Sorular
Bu repo,Nesne Yönelimli Programlama dersinin 6. hafta laboratuvar çalışmaları kapsamında verilen soruların çözümlerini içermektedir.Sorular içeriğine göre Enum, Overloading, Struct ve Tek-Çift boyutlu indeksler şeklinde 4 farklı kategoriye ayrılmış olup,soruların detayları ve ilgili çözümler aşağıda açıklanmıştır.

### 1.⁠ ⁠Trafik Işığı Durumu

	•	Konu: Trafik ışıklarının (Red, Yellow, Green) durumlarını temsil eden bir enum oluşturulması.
	•	Gereklilikler:
	•	Trafik ışığı durumlarını temsil eden bir enum oluşturun.
	•	Enum değerine göre yapılması gereken işlemi döndüren bir metot yazın.
	•	Red → “Durun!”
	•	Yellow → “Hazırlanın!”
	•	Green → “Geçin!”

### 2.⁠ ⁠Hava Durumu Tahmini

	•	Konu: Hava durumu tiplerini temsil eden bir enum oluşturulması.
	•	Gereklilikler:
	•	Hava durumu tiplerini (Sunny, Rainy, Cloudy, Stormy) temsil eden bir enum oluşturun.
	•	Enum değerine göre hava durumu tavsiyesi veren bir metot yazın.
	•	Sunny → “Güneş gözlüğü takın.”
	•	Rainy → “Şemsiye alın.”
	•	Cloudy → “Hafif bir ceket giyebilirsiniz.”
	•	Stormy → “Evde kalmanız tavsiye edilir.”

### 3.⁠ ⁠Çalışan Rolleri ve Maaş Hesaplama

	•	Konu: Çalışan rolleri için bir enum oluşturulması ve maaş hesaplama.
	•	Gereklilikler:
	•	Çalışan rolleri (Manager, Developer, Designer, Tester) için bir enum oluşturun.
	•	Enum’a göre maaşı döndüren bir metot yazın.
	•	Manager → 15000 TL
	•	Developer → 12000 TL
	•	Designer → 10000 TL
	•	Tester → 9000 TL

### 4.⁠ ⁠Zaman İşlemleri

	•	Konu: Saat ve dakika bilgilerini tutan bir struct oluşturulması.
	•	Gereklilikler:
	•	Saat ve dakikayı temsil eden bir struct oluşturun (Hour ve Minute özellikleri).
	•	Eğer saat/dakika geçersiz girilirse, bu değerleri otomatik olarak 0 yapın.
	•	Aşağıdaki işlemleri gerçekleştiren metotlar ekleyin:
	•	Toplam dakika değerini hesaplayan bir metot.
	•	İki zaman arasındaki farkı (dakika olarak) hesaplayan bir metot.

### 5.⁠ ⁠Karmaşık Sayı Hesaplama

	•	Konu: Karmaşık sayıları temsil eden bir struct oluşturulması.
	•	Gereklilikler:
	•	Karmaşık sayılar için Real ve Imaginary özellikleri olan bir struct oluşturun.
	•	Aşağıdaki işlemleri gerçekleştiren metotlar ekleyin:
	•	İki karmaşık sayıyı toplama.
	•	İki karmaşık sayıyı çıkarma.
	•	Sonucu a + bi formatında döndüren bir ToString() metodu ekleyin.

### 6.⁠ ⁠GPS Konum Mesafesi

	•	Konu: İki GPS konumu arasındaki mesafeyi hesaplayan bir struct oluşturulması.
	•	Gereklilikler:
	•	Enlem (Latitude) ve boylam (Longitude) bilgilerini tutan bir struct oluşturun.
	•	İki GPS konumu arasındaki mesafeyi kilometre cinsinden hesaplayan bir metot ekleyin.
	•	Mesafe hesaplama için Haversine Formülü kullanın.
 
### 7. Matematiksel İşlemler Fonksiyonu

	•	Konu: Matematiksel işlemleri çeşitlendiren bir fonksiyon tasarımı.
	•	Gereklilikler:
	•	Aynı adla ama farklı parametrelerle toplama işlemi yapılacak.
	•	Overloading kullanılarak metotlar oluşturulacak:
	•	İlk sürüm: İki tam sayıyı topla.
	•	İkinci sürüm: Üç tam sayıyı topla.
	•	Üçüncü sürüm: Bir dizi (array) tam sayıyı topla.

 

 ### 8. Farklı Şekillerin Alanını Hesaplayan Fonksiyon  

        • Konu: Farklı şekillerin alanını hesaplayan fonksiyon tasarımı.    
        • Gereklilikler:    
        • Aynı isimli bir metot, farklı parametre kombinasyonları ile farklı şekillerin alanını hesaplar.  
	• Hesaplama Fonksiyonları:  
        • Kare Alanı: Bir kenar uzunluğu verilerek karenin alanı hesaplanır.  
        • Dikdörtgen Alanı: İki kenar uzunluğu verilerek dikdörtgenin alanı hesaplanır.  
        • Daire Alanı: Yarıçap verilerek dairenin alanı hesaplanır.    

 
	
 ### 9. Zaman Farkını Farklı Formatlarda Hesaplayan Fonksiyon  

        • Konu: Zaman farkını farklı formatlarda hesaplayan fonksiyon tasarımı.  
        • Gereklilikler:  
        • Aynı ada sahip ancak farklı parametrelerle çalışan birden fazla fonksiyon yazılacaktır.  
        • İlk sürüm: İki tarih arasındaki gün farkını döndüren bir fonksiyon.  
        • İkinci sürüm: İki tarih arasındaki saat farkını döndüren bir fonksiyon.  
	• Üçüncü sürüm: İki tarih arasındaki yıl farkını döndüren bir fonksiyon.  

 
 
 ### 10. Özel Bir Kütüphane Yönetim Sistemi  

        •⁠ Konu: Kitap koleksiyonlarını temsil eden bir sınıf oluşturun.  

        •⁠ ⁠Gereklilikler:   
        • Kitap koleksiyonunu bir dizi aracılığıyla depolayınız.  
        • Kullanıcı, indeksleyici aracılığıyla kitap adı öğrenebilmeli veya değiştirebilmelidir.    
        • Kullanıcı geçersiz bir indeksle erişim yaparsa uygun bir hata mesajı döndürülmelidir.    

### 11. Bir Öğrenci Not Sistemi

       •⁠ ⁠Konu: Öğrencilerin aldığı derslerin notlarını temsil eden bir sınıf oluşturun.

       •⁠ Gereklilikler:
       • Derslerin adını ve notlarını depolayan bir yapı oluşturulmalıdır.  
       • Kullanıcı, indeksleyici aracılığıyla ders adına göre notlara erişebilmelidir.  
       • Ders bulunamadığında uygun bir hata mesajı döndürülmelidir.  

### 12. Bir Satranç Tahtası Durumu

      •⁠ Konu: Satranç tahtasındaki kareleri temsil eden bir sınıf oluşturun.

      •⁠ ⁠Gereklilikler:
      • 8x8 boyutunda bir satranç tahtası oluşturulmalıdır.  
      • Kullanıcı, indeksleyici aracılığıyla bir kareye taş koyabilmeli veya karedeki taşı öğrenebilmelidir.  
      • Geçersiz bir kareye erişimde uygun bir hata mesajı döndürülmelidir.  

### 13. Çok Katmanlı Bir Otopark Sistemi

     •⁠ ⁠Konu:Katlı otoparktaki park yerlerini temsil eden bir sınıf oluşturun.

     •⁠ ⁠Gereklilikler:
     • Her kat için bir dizi park yerini temsil eden bir yapı oluşturulmalıdır.  
     • Kullanıcı, indeksleyici aracılığıyla belirli bir kat ve park yerine erişebilmelidir.  
     • Park yeri boşsa "Empty", doluysa araç plakasını döndürmelidir.


