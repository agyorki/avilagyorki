public class CheckingAccount extends BankAccount {

private static final double fee = 0.15;

public CheckingAccount(String name, double initialAmt) {

super(name, initialAmt);

setAccountNumber(getAccountNumber() + "-10");

}

public boolean withdraw(double amt) {

amt += fee;

return super.withdraw(amt);

}

}