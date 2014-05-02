import clr
clr.AddReferenceToFileAndPath('Atm.dll')
from Atm import Atm, Account

__author__ = 'l.jones'


account_number = '125009'
account = None
cut = None
cash_dispensed = None


def create_account(opening_balance):
    """Create an account with opening_balance (in this module)."""
    global account
    account = Account(account_number, opening_balance)


def request_cash_withdrawal(amount):
    """Request a cash withdrawal of amount from account."""
    global account, cut, cash_dispensed
    cut = Atm()
    cash_dispensed = cut.WithdrawCash(account, amount)
