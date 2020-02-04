//the purpose of this class is to model a television
//Avila Gyorki 1/22/2020

public class Television {

   private String manufacturer;
   private int screenSize;
   private boolean powerOn;
   private int volume;
   private int channel;

   public Television() {

   }

   public Television(String manufacturer, int screenSize) {
       this.manufacturer = manufacturer;
       this.screenSize = screenSize;
       volume = 20;
       powerOn = false;
       channel = 2;
   }

   public void setChannel(int channel) {
       this.channel = channel;
   }

   public void power() {
       this.powerOn = true;
   }

   void increaseVolume() {
       // Assuming max volume is 100
       if (volume != 100) {
           volume++;
       }
   }

   void decreaseVolume() {
       // if volume is zero it can't be turned down
       if (volume != 0) {
           volume--;
       }
   }

   public int getChannel() {
       return channel;
   }

   public int getVolume() {
       return volume;
   }

   public String getManufacturer() {
       return manufacturer;
   }

   public int getScreenSize() {
       return screenSize;
   }

}