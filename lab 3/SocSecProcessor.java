import java.util.Scanner;

public class SocSecProcessor
{

   public static void main (String [] args)
   {
   Scanner keyboard = new Scanner (System.in);
   String name;
   String socNum;
   String response;
   char answer = 'Y';

 while (Character.toUpperCase(answer) == 'Y'){
 try
   {
       System.out.print("Name?");
       name = keyboard.nextLine();
       System.out.print("SSN?");
       socNum = keyboard.nextLine();
       if(isValid(socNum)){
           System.out.println(name + " " + socNum + "is Valid");
       }
  }
   catch (SocSecException e) // To do: catch the SocSecException
   {
   System.out.println(e.getMessage());
   }
   System.out.print("Continue? ");
   response = keyboard.nextLine();
   answer = response.charAt(0);
   }
   }
 
   private static boolean isValid(String number)throws SocSecException
   {
   boolean valid = true;
   int index = 0;
   if (number.length() != 11)
   {
   throw new SocSecException("wrong number of characters ");
   }
   for( index=0;index<number.length();++index){
       if(index==3 || index==6){
           if (number.charAt(index) != '-'){
               throw new SocSecException("dashes at wrong positions");
           }
       }else if (!Character.isDigit(number.charAt(index))){
           throw new SocSecException("contains a character that is not a digit");
       }
   }
   return valid;
   }
}