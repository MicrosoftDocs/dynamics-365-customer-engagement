---
title: "Manage your customers using accounts and contacts"
description: "Use accounts to store information about companies that you do business with and contacts to store information about people that you work with."
keywords: ""
ms.date: 11/17/2021
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

## Managing accounts 

- [Create an account](#create-an-account)
- [View opportunities associated with an account](#view-opportunities-associated-with-an-account)
- [View invoices associated with an account](#view-invoices-associated-with-an-account)
- [View invoices associated with an account](#view-invoices-associated-with-an-account)


### Create an account 

1. In the Sales Hub site map, select **Accounts**.

1. Specify the details that you know about the company and save the changes. 

### Add contacts to an account

1. In the Sales Hub site map, select **Accounts**.

1. Select an account. In the **Summary** tab, go to the **Contacts** pane, and select the **More commands**  :::image type="icon" source="media/more-commands-icon.png" border="false":::  icon.
1. Select **New Contact** or **Add Existing Contact**.
    > [!NOTE]
    > You can associate a contact with only one account. If you select a contact who is already added to an account, you'll get an error message. 

### View opportunities associated with an account

1. In the Sales Hub site map, select **Accounts**.

1. Select an account. In the **Summary** tab, go to the **Contacts** pane, and select the **Recent Opportunities** :::image type="icon" source="media/recent-opportunities.png" border="false"::: icon.
    The pane lists the recent opportunities associated with the account.     


### View invoices associated with an account

1. In the Sales Hub site map, select **Accounts**.

1. Select an account. In the **Summary** tab, go to the **Contacts** pane, and select the **Recent Invoices** :::image type="icon" source="media/recent-invoices.png" border="false"::: icon.
    The pane lists the recent opportunities associated with the account.     

## Managing contacts

- [Create a contact](#create-a-contact)
- [View opportunities associated with a contact](#view-opportunities-associated-with-a-contact)
- [View invoices associated with a contact](#view-invoices-associated-with-a-contact)

### Create a contact

1. In the Sales Hub site map, select **Contacts**.

1. Specify the details that you know about the contact. 
1. (Optional) Specify the account that the contact belongs to.
    Associating a contact with an account helps in reaching out to the right people to work with an account. 
    > [!NOTE]
    > Alternatively, you can add contacts to an account. See [Add contacts to an account](#add-contacts-to-an-account).
1. Save the changes.

### View opportunities associated with a contact

1. In the Sales Hub site map, select **Contacts**.

1. Select a contact. In the **Summary** tab, go to the **Recent Opportunities** pane to view the recent opportunities associated with the contact.  


### View invoices associated with a contact

1. In the Sales Hub site map, select **Contacts**.

1. Select a contact. In the **Summary** tab, go to the **Recent Opportunities** pane, and select the **Recent Invoices** :::image type="icon" source="media/recent-invoices.png" border="false"::: icon.
    The pane lists the recent opportunities associated with the contact.    

## Import accounts or contacts from Excel, CSV, XML Files

You can import accounts and contacts from excel, CSV, or XML files. For detailed steps, see [How to import data](/powerapps/user/import-data?context=/dynamics365/context/sales-context).
  

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



