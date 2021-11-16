---
title: "Work with accounts and contacts"
description: "Use accounts to store information about companies that you do business with and contacts to store information about people that you work with."
keywords: ""
ms.date: 11/10/2021
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Work with accounts and contacts

Account and contact records store much of the information that you and your team collect from your customers. You store data about companies you do business with in accounts. Similar to Microsoft Office Outlook or other email programs, you store data about the people you know and work with in contacts.

Usually, an account has more than one contact associated with it, especially when you're working with a larger company with many departments or locations and you deal with several people to manage the account.

You can create accounts and contacts manually or import them from a spreadsheet or other supported files. 

## Create an account or contact

**To create an account:**

1. In the Sales Hub site map, select **Accounts**.

1. Specify the details that you know about the company and save the changes. 

**To create a contact:**

1. In the Sales Hub site map, select **Contacts**.

1. Specify the details that you know about the contact. 
1. (Optional) Specify the account that the contact belongs to.
    Associating a contact with an account helps in reaching out to the right people to work with an account.  
1. Save the changes.

## Import accounts or contacts from Excel, CSV, XML Files

You can import accounts and contacts from excel, CSV, or XML files. For detailed steps, see [How to import data](/powerapps/user/import-data?context=/dynamics365/context/sales-context).

In addition, contacts can be imported from Exchange.  

## Import contacts from Exchange

If you’ve been keeping track of all your contacts in Microsoft Exchange, you can quickly get all your contacts into Dynamics 365 Sales so you have all your data in one place.

### Prerequisites

To be able to import from Exchange:

-   You must have a valid Exchange subscription and license.

-    Your mailbox must be tested and enabled. Talk to your administrator if you receive an error.

1.   Select **Contacts** from the site map. On the command bar, select **Import
    from Excel** \> **Import from Exchange**.

    ![Import from Exchange option.](media/import-from-exchange-option.png "Import from Exchange option") 

    The **Track data from Exchange** dialog box opens.

    ![Track data from Exchange dialog box.](media/track-data-from-exchange-dialog-box.png "Track data from Exchange dialog box")

4. Select **Track**.

    All the contacts from Exchange will start importing to Dynamics 365 Sales. Any changes that you make to contacts in your Exchange mailbox are automatically updated in the contact records in Dynamics 365 Sales.

>[!IMPORTANT]
>You won’t be able to remove or untrack a contact from Dynamics 365 Sales. Use the Dynamics 365 App for Outlook to do this.



