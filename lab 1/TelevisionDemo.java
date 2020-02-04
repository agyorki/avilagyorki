import java.util.Scanner;

/**
* This class demonstrates the Television class.
*/

public class TelevisionDemo {
   public static void main(String[] args) {
       // Create a Scanner object to read from the keyboard
       Scanner keyboard = new Scanner(System.in);

       // Declare variables
       int station; // The user's channel choice

       // Declare and instantiate a television object
       Television bigScreen = new Television("Toshiba", 55);

       // Turn the power on
       bigScreen.power();

       // Display the state of the television
       System.out.println("A " + bigScreen.getScreenSize() + " inch "
               + bigScreen.getManufacturer() + " has been turned on.");

       // Prompt the user for input and store into station
       System.out.print("What channel do you want? ");
       station = keyboard.nextInt();

       // Change the channel on the television
       bigScreen.setChannel(station);
       // Increase the volume of the television
       bigScreen.increaseVolume();

       // Display the the current channel and
       // volume of the television
       System.out.println("Channel: " + bigScreen.getChannel() + " Volume: "
               + bigScreen.getVolume());
       System.out.println("Too loud! Lowering the volume.");

       // Decrease the volume of the television
       bigScreen.decreaseVolume();
       bigScreen.decreaseVolume();
       bigScreen.decreaseVolume();
       bigScreen.decreaseVolume();
       bigScreen.decreaseVolume();
       bigScreen.decreaseVolume();

       // Display the the current channel and
       // volume of the television
       System.out.println("Channel: " + bigScreen.getChannel() + " Volume: "
               + bigScreen.getVolume());

       System.out.println(); // For a blank line

       // HERE IS WHERE YOU DO TASK #5
       // declare a Sharp 19 inch television.
       Television television = new Television("Sharp", 19);

       // call the method to turn the tv power on.
       television.power();
       // call methods to print what the tv was set to
       System.out.println("A " + television.getScreenSize() + " inch "
               + television.getManufacturer() + " has been turned on.");
       // call methods to change the to the user’s selection and decrease volume by 2
       television.decreaseVolume();
       television.decreaseVolume();

       // call methods to print the changed settings
       // ask the user for input and store it in the station
       System.out.print("What channel do you want? ");
       station = keyboard.nextInt();

       // Change the channel on the tv
       television.setChannel(station);
       // show the the current channel and volume
       System.out.println("Channel: " + television.getChannel() + " Volume: "
               + television.getVolume());

   }
}