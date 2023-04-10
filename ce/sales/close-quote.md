---
title: "Close a quote | MicrosoftDocs"
description: "A quote can be closed when it's lost, canceled, or revised."
ms.date: 10/25/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Close a quote in Dynamics 365 Sales

When you [create an order from a quote](create-edit-order-sales.md#create-an-order-from-a-quote), the quote is automatically closed as won. However, if the quote was not accepted, you can close it manually as Lost, Canceled, or Revised. 

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|



## Close a quote

1. In the sitemap, select **Quotes** to view all the quotes. Alternatively, you can open an opportunity and select the **Quotes** tab to view the quotes associated with the opportunity.
    > [!NOTE]
    > You can close a quote only when it's in the **Active** state. If you have quotes in **Draft** state, you can either delete them or activate and then close them.

1. Open the quote that you want to close and select **Close Quote** on the command bar. 

2. In the **Close Quote** dialog box, enter the following information:

   - **Status Reason:** Select the status of the item. The choices available by default are Lost, Canceled, and
Revised.
   - **Close Date:** Enter the date that the quote was closed. The current date is selected by default. 
   
   - **Description:** Enter details about why the quote is being closed. 
   
   - **Create a revised quote:** You may be closing the quote because you need to create a new, revised quote. If this is the
case, select **Yes**. If you don't want to revise the quote, set this field to **No**.  
    - **Close the associated opportunity:** This field appears only when you try to close the last quote associated with an opportunity. 

3. Select **OK**.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Create or edit quotes](create-edit-quote-sales.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)] 
