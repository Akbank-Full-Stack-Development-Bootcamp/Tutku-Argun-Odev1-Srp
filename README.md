# Tutku-Argun-Odev1-Srp
Bu projede ; Windows Form Uygulaması yapılarak single responsibility princible örneği verilmeye çalışılmışır.
Açılan form ekranından kullanıcıdan vize ve final notlarının girilmesi istenmekte ve kullanıcının bunları girdikten sonra,
3 değişik işlem yapma hakkı bulunmaktadır. Form ekranının amacı sadece kullanıcıdan notları almak, 
hesaplaması için hesaplama sınıfına göndermek ve sonucu kullanıcıya göstermektir. Bu yüzden hesaplama işi için ayrı bir class oluşturulmuştur.
Diğer bir işlem Notları veritabanına kaydetme işlemidir. Bunun için veritabanı işlemlerinin yapıldığı bir class daha oluşturulmuştur.
Kayıt işlemleri de ayrı bir (SaveNotes) classta yapılmıştır. 
Son seçenek de kayıtları form ekranında listelemek ve bunları bir .txt dosyası olarak kaydetme işlemidir.
Yeni bir form ekranı ve bu işlemleri yapacak yeni bir (FormNotlar) class eklenmiştir. 
Bu classın içinde kayıtlı notları form ekranında göstermekten sorumlu bir metot bulunmaktadır. 
