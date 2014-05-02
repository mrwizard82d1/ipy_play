import clr
clr.AddReferenceToFileAndPath('Atm.dll')
from Atm import AccountNumber

__author__ = 'l.jones'


def create_account(account_number_text):
    """Create an account from account_number_text."""
    is_parsed, account_number = AccountNumber.TryParse(account_number_text)
    return is_parsed, account_number


