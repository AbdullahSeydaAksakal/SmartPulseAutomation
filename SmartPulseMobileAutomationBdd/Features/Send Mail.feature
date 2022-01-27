Feature: Send Mail


@mytag
Scenario: 05 04 2020 Tarihine ait PTF ortalamasını seç ve 'analyst.team@smartpulse.io' adresine mail at 
	Given Epias uygulamasini ac
	And Yukarıdaki PTF/SMF simgesinin sagindaki ok dugmesine tıkla
	And Epias logosunun altındaki Takvim butonuna bas
	And Takvim ekranında takvimi '05.04.2020' olacak sekilde ayarla
	And Tamam Düğmesine Tıkla
	And Ekranin ortasindaki dugmeye bas
	And PTF paylasim dugmesine bas.
	And Gmaili Sec
	And Gonderen kismina 'aseydaaksakal@gmail.com' yaz
	When Gonder dugmesine bas 
	Then Mailin basarili bir sekilde gönderildigini ve Ana Sayfaya dustugunu gor