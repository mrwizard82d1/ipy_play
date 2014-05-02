# import clr
# clr.AddReferenceToFileAndPath('Atm.dll')
import Atm

__author__ = 'l.jones'


def create_account(account_number, opening_balance):
    """Create an account from account_number and opening_balance."""
    return Atm.Account(account_number, opening_balance)

