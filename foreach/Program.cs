spor sports = new spor();
sports.sporAdi = "Yüzme";
sports.sporGiyim = "Mayo";
sports.sporFiyat = 250;

spor sports1 = new spor();
sports1.sporAdi = "Gym";
sports1.sporGiyim = "Spor Ayakkabı";
sports1.sporFiyat = 170;

spor sports2 = new spor();
sports2.sporAdi = "Tenis";
sports2.sporGiyim = "Şapka";
sports2.sporFiyat = 385;

spor[] spor1 = new spor[] {sports,sports1,sports2};

for (int i = 0; i < spor1.Length; i++)
{
    Console.WriteLine(spor1[i].sporAdi+" : "+spor1[i].sporGiyim+": "+" : "+spor1[i].sporFiyat);
}

//foreach (var spor in spor1)
//{
//    Console.WriteLine(spor.sporAdi + " : " + spor.sporGiyim + " : " + spor.sporFiyat);
//}

class spor
{
    public string sporAdi { get; set; }
    public string sporGiyim{ get; set; }
    public int sporFiyat { get; set; }
}