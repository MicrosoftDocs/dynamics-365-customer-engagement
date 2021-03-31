---
title: "Dynamics 365 Sales and GDPR | MicrosoftDocs"
description: "Know how Dynamics 365 Sales complies with GDPR regulations."
ms.date: 10/01/2019
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Dynamics 365 Sales and GDPR

To comply with GDPR, we’ve made it possible to edit read-only records in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)].

The following table shows the states in which the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] records become read-only. 

|  Entity  |  State  |
|  ------  |  -----  |
|  Quote   | Active/Closed |
|  Order   | Fulfilled/Canceled/Submitted/Invoiced |
|  Invoice | Paid/Canceled/Closed | 

A system administrator can export read-only quote, order, and invoice records, update them, and import the updated records back to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)].  

It is also possible to update the read-only records programmatically with the SDK for Dynamics 365 Sales.

## Update read-only records through export/import

1. In your sales app, go to the list of records. For example, go to **Sales** > **Quotes**.

2. Open the view that shows all the records regardless of their state. For example, open the **All Quotes** view.

3. Select the records that you want to export, and on the command bar, select **Export to Excel** > **Static Worksheet**. More information: [Export data to Excel](../basics/export-data-excel.md)

4. In the file that you exported, make the necessary changes.

5. To import the updated records back into [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)], in your sales app, in the list of records, select **Import Data**. More information: [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)


## Important points

- As a system administrator, you can edit any read-only field but changes will not reflect for the locked fields. 

- Non-admin users can't edit an active quote. However, an admin user can edit and save an active quote, although it is read-only for non-admin users.

- If configured, Plugins, Business processes and workflows will run on fields getting updated or becoming editable. 

- In case of Dynamics 365 Sales integration with any third-party system, there is a chance of GDPR requested changes to be overwritten if correct sequence of updates is not followed. It is the responsibility of the system administrator of Dynamics 365 Sales to follow the correct order. 

To know more about GDPR compliance, see [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/index).


[!INCLUDE[footer-include](../includes/footer-banner.md)]
