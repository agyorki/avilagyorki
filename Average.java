import java.util.Scanner;

public class Average
{
private int [] data;
private int total = 0;
private double mean;

public Average(){
data = new int [5];
Scanner key = new Scanner(System.in);
for (int i = 0; i<data.length;i++){
System.out.print("Score number " + (i+1)+": ");
data[i] = key.nextInt();
}
//call selectionsort and calculatemean methods
this.selectionSort();
this.calculateMean();
}

//method for calculating mean
public void calculateMean(){
int i = 0;
int x = 0;

for(i=0;i<data.length;i++){
x=x+data[i];
}
mean = (double)x/(data.length);
}

//method for sorting
public void selectionSort(){
int maxIndex, maxVal;

for(int y=0;y<data.length-1;y++){
maxIndex = y;
maxVal=data[y];

for(int index= y+1;index<data.length;index++){
if(data[index]>maxVal){
maxVal=data[index];
maxIndex=index;
}
}
data[maxIndex]=data[y];
data[y]=maxVal;
}
}

//method to turn input to string
public String toString(){
String out;
out = "Scores from highest to lowest are \n";
for (int i=0;i<data.length;i++){
out=out+data[i]+" ";
}
out=out+"\nScore average is: "+mean;
return out;
}
}




