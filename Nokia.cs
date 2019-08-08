 using System;
 public class Nokia : Phone, IRingable {
     public Nokia (string versionNumber, int batteryPercentage, string carrier, string ringTone) 
     : base(versionNumber,batteryPercentage,carrier,ringTone){
     }
     public string Ring(){
        return _ringTone;
     }
     public string Unlock(){
         string unlock = "Nokia was unlock";
         return unlock;
     }
     public override void DisplayInfo(){
         Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
         Console.WriteLine($"Nokia: {_versionNumber}, Battery Percenteage: {_batteryPercentage}, Carrier: {_carrier}, Ringtone: {_ringTone}");
         Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
     }
 }