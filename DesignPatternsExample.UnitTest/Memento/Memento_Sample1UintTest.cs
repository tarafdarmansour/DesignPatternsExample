using DesignPatternsExample.Composite.Sample1;
using DesignPatternsExample.Memento;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Memento
{
    public class Memento_Sample1UintTest
    {
        [Fact]
        public void WhenICreateBankAccountWithBalance_ItShouldHaveSameBalance()
        {
            var bankAccount = new BankAccount(100);
            bankAccount.GetBalance().Should().Be(100);
        }

        [Fact]
        public void WhenICreateBankAccountWithSomeDeposit_ItShouldHaveSumOfAllDepositAndFirstBalance()
        {
            var bankAccount = new BankAccount(100);
            bankAccount.Deposit(5000);
            bankAccount.Deposit(1000);
            bankAccount.GetBalance().Should().Be(6100);
        }

        [Fact]
        public void WhenICreateBankAccountWithSomeDepositAddUndo_ItShouldSubtractLastBalance()
        {
            var bankAccount = new BankAccount(100);
            bankAccount.Deposit(1000);

            bankAccount.GetBalance().Should().Be(1100);
            bankAccount.Undo();
            
            bankAccount.GetBalance().Should().Be(100);
        }

    }
}