/*
 * Project08.java
 * 
 *   A program that converts decimal numbers to Roman numerals.
 *   Used to practice breaking code up into methods. 
 * 
 * @author Avila Gyorki
 * @version 20160306
 * 
 */

import java.util.Scanner;


public class Project08 {

	public static void main(String[] args) {
		
		Scanner in = new Scanner(System.in);
			int userInfo=promptUserForNumber(in);
				while(userInfo!= 0){
				String romanFinal = convertNumberToNumeral(userInfo);
				System.out.println("The number " + userInfo + " is the Roman numeral " + romanFinal);
				userInfo= promptUserForNumber(in);
				}
			
			
			
			
			

			
			System.out.println("Goodbye!");
		
	}

	
	
	
	
	
	private static int promptUserForNumber(Scanner inScanner) {
		System.out.println("Enter a number between 1 and 3999 (0 to quit): ");
		int userNumber = inScanner.nextInt();
		
		while( (userNumber < 1 || userNumber > 3999) && userNumber!=0){
			System.out.println("ERROR!  Number must be between 1 and 3999.");
			System.out.println("Enter a number between 1 and 3999 (0 to quit): ");
			userNumber = inScanner.nextInt();     }
		
		return userNumber;
		
		}
	
	
	
	
	
	
	
	private static String convertNumberToNumeral(int number) {
		
		
		
		String onesPlaceRoman = "";
		String tensPlaceRoman = "";
		String hunPlaceRoman = "";
		String thousandPlaceRoman = "";
	
		int place = 0;
		if (place==0){

			int divisionOnes = number%10;
			number = number/10;
			
			
			 onesPlaceRoman = convertDigitToNumeral(divisionOnes, 'I', 'V', 'X') + onesPlaceRoman;
			 		
		}
			if(number>0){
				int divisionTens = number%10;
				number = number/10;
				
				tensPlaceRoman = convertDigitToNumeral(divisionTens, 'X', 'L', 'C') + tensPlaceRoman;}
					
					
			if(number>0){
				int divisionHundreds = number%10;
				number = number/10;
				
				hunPlaceRoman = convertDigitToNumeral(divisionHundreds, 'C', 'D', 'M') + hunPlaceRoman;}
				
				
			if(number>0){
				int divisionThousands = number%10;
				number = number/10;
			
				thousandPlaceRoman = convertDigitToNumeral(divisionThousands, 'M', 'M', 'M') + thousandPlaceRoman;}
			
			String roman = thousandPlaceRoman  + hunPlaceRoman + tensPlaceRoman + onesPlaceRoman;
			return roman;
			
		}

	
	
	
	
	
	
	private static String convertDigitToNumeral(int digit, char one, char five, char ten) {
		
		String romanNumeral = "";
		
		if(digit == 1){
		romanNumeral= one+"";}
		else if (digit == 2){
		romanNumeral=one+(one+"");}
		else if (digit == 3){
			romanNumeral= one + (one+(one+""));}
		else if (digit == 4){
			romanNumeral=(one+"") + five;}
		else if (digit == 5){
			romanNumeral=five + "";}
		else if (digit == 6){
			romanNumeral=five + (one+"");}
		else if (digit == 7){
			romanNumeral=five + (one+(one+""));}
		else if (digit == 8){
			romanNumeral=five + (one + (one + (one+"")));}
		else if (digit == 9){
			romanNumeral=(one+"") + ten ;}
	
		
		
	return romanNumeral;
		}

		
	}
	
	

	
