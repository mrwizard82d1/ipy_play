import clr
clr.AddReferenceToFileAndPath('Atm.dll')
from Atm import Account

__author__ = 'l.jones'


account_number = '125009'
cut = None


def create_account(opening_balance):
    """Create an account with opening_balance (in this module)."""
    global cut
    cut = Account(account_number, opening_balance)
    

