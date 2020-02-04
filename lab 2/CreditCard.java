
public class CreditCard {

/** Create the CreditCard class according to the UML diagram. It should have
data fields that include an owner of type Person, a balance of type Money,
and a creditLimit of type Money */

// 1. 
private Person owner;
private Money creditLimit;
private Money balance;

public CreditCard(Person owner, Money creditLimit){
this.owner = owner;
this.creditLimit=new Money(creditLimit);
this.balance=new Money(0);
}

public String getCreditLimit(){
Money climit=new Money(this.creditLimit);
return climit.toString();
}

public String getPersonals(){
return this.owner.toString();
}

public void charge(Money money){
int state = (money.add(this.balance)).compareTo(this.creditLimit);
if(state == -1){
this.balance=this.balance.add(money);
} else
System.out.println("Exceeds credit limit");
}

public void payment(Money money){
this.balance=this.balance.subtract(money);
}

public String getBalance(){
Money r = new Money(this.balance);
return r.toString();
}
}