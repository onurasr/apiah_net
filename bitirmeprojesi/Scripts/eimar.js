form.addEventListener('submit', function (event) {
    event.preventDefault(); // Sayfanın yenilenmesini engelle

    // Alanları seç
    const il = document.querySelector('select[name="il"]');
    const ilce = document.querySelector('select[name="ilce"]');
    const mahalle = document.querySelector('select[name="mahalle"]');
    const ada = document.querySelector('input[name="ada"]');
    const parsel = document.querySelector('input[name="parsel"]');

    // Alanların doluluk kontrolü
    if (il.value === 'İl Seçiniz' || ilce.value === 'İlçe Seçiniz' || mahalle.value === 'Mahalle Seçiniz' || ada.value === '' || parsel.value === '') {
        // Eksik alan varsa hata mesajı göster
        alert('Lütfen tüm alanları doldurun!');
        return; // Form gönderimini durdur
    }

    // Eğer eksik alan yoksa formu gönder veya diğer işlemleri yap
});
