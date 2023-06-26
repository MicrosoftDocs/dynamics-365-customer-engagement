---
title: Manage your customers using accounts and contacts
description: Use accounts to store information about companies that you do business with and contacts to store information about people that you work with.
ms.date: 06/26/2023
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Manage your customers using accounts and contacts

Use accounts to store information about companies that you do business with and contacts to store information about people that you work with.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Difference between accounts and contacts

Account and contact records store much of the information that you and your team collect from your customers. You store data about companies you do business with in accounts. Similar to Microsoft Office Outlook or other email programs, you store data about the people you know and work with in contacts.

Usually, an account has more than one contact associated with it, especially when you're working with a larger company with many departments or locations and you deal with several people to manage the account.

You can create accounts and contacts manually or import them from a spreadsheet or other supported files.

## Managing accounts 

- [Create an account](#create-an-account)
- [View opportunities associated with an account](#view-opportunities-associated-with-an-account)
- [View invoices associated with an account](#view-invoices-associated-with-an-account)
- [View invoices associated with an account](#view-invoices-associated-with-an-account)
- [View relationship analytics and KPIs for an account](relationship-analytics.md)

### Create an account 

1. In the site map, select **Accounts**.

1. Specify the details that you know about the company and save the changes. 

### Auto-populate address fields with address suggestions

Instead of typing the address manually, you can use the address suggestion feature to auto-populate the address fields in the contact, account, and lead forms.  

> [!NOTE]
> Your administrator must have enabled address suggestion for you to use this feature. See [Enable address suggestions](enable-address-suggestion.md) for more information.  

1. Open a contact, lead, or account form that has address fields.
1. Scroll down to the **Address** field and start typing the address.
1. Select an address from the list of suggestions provided by Bing Maps and press the **Enter** key.  
    The address fields are auto-populated with the details in the selected address and Bing Map is also updated to point to the selected address.

### Add contacts to an account

1. In the site map, select **Accounts**.

1. Select an account. In the **Summary** tab, go to the **Contacts** pane, and select the **More commands**  :::image type="icon" source="media/more-commands-icon.png" border="false":::  icon.
1. Select **New Contact** or **Add Existing Contact**.
    > [!NOTE]
    > You can associate a contact with only one account. If you select a contact who is already added to an account, you'll get an error message. 

### View opportunities associated with an account

1. In the site map, select **Accounts**.

1. Select an account. In the **Summary** tab, go to the **Contacts** pane, and select the **Recent Opportunities** :::image type="icon" source="media/recent-opportunities.png" border="false"::: icon.
    The pane lists the recent opportunities associated with the account.     


### View invoices associated with an account

1. In the site map, select **Accounts**.

1. Select an account. In the **Summary** tab, go to the **Contacts** pane, and select the **Recent Invoices** :::image type="icon" source="media/recent-invoices.png" border="false"::: icon.
    The pane lists the recent opportunities associated with the account.     

## Managing contacts

- [Create a contact](#create-a-contact)
- [View opportunities associated with a contact](#view-opportunities-associated-with-a-contact)
- [View invoices associated with a contact](#view-invoices-associated-with-a-contact)
- [Get introduced to a contact](who-knows-whom.md)
- [View relationship analytics and KPIs for a contact](relationship-analytics.md)

### Create a contact

1. In the site map, select **Contacts**.

1. Specify the details that you know about the contact. 
1. (Optional) Specify the account that the contact belongs to.
    Associating a contact with an account helps in reaching out to the right people to work with an account. 
    > [!NOTE]
    > Alternatively, you can add contacts to an account. See [Add contacts to an account](#add-contacts-to-an-account).
1. Save the changes.

### View opportunities associated with a contact

1. In the site map, select **Contacts**.

1. Select a contact. In the **Summary** tab, go to the **Recent Opportunities** pane to view the recent opportunities associated with the contact.  


### View invoices associated with a contact

1. In the site map, select **Contacts**.

1. Select a contact. In the **Summary** tab, go to the **Recent Opportunities** pane, and select the **Recent Invoices** :::image type="icon" source="media/recent-invoices.png" border="false"::: icon.
    The pane lists the recent opportunities associated with the contact.    

## Import accounts or contacts from Excel, CSV, XML Files

You can import accounts and contacts from excel, CSV, or XML files or from Exchange. For more information, see [Import data into Dynamics 365 Sales](import-data.md) 



