namespace DesignPatternsExample.Memento
{
    public class BankAccount //originator
    {
        private int _balance;
        private List<AccountHistory> _history = new();
        private int _current = 0;
        public BankAccount(int balance)
        {
            _balance = balance;
            _history.Add(new AccountHistory(_balance));
        }

        public AccountHistory Deposit(int amount)
        {
            _balance += amount;
            var history = new AccountHistory(_balance);
            _history.Add(history);
            _current++;
            return history;
        }

        public void Restore(AccountHistory history)
        {
            _balance = history.Balance;
            _history.Add(history);
            _current = _history.Count - 1;
        }
        
        public int GetBalance() { return _balance; }

        public AccountHistory Undo()
        {
            if (_current > 0)
            {
                var history = _history[--_current];
                _balance = history.Balance;
                return history;
            }
            return null;
        }

        public AccountHistory Redo()
        {
            if (_current + 1 < _history.Count)
            {
                var history = _history[++_current];
                _balance = history.Balance;
                return history;
            }

            return null;
        }
    }
}
