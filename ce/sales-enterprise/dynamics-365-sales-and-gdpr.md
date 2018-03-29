---
title: "Dynamics 365 for Sales and GDPR | MicrosoftDocs"
description: "Know how Dynamics 365 for Sales complies with GDPR regulations."
keywords: "Sales, GDPR"
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 722fa6d7-0d73-4fd0-a726-8148a8d55657
author: shubhadaj
ms.author: shujoshi
manager: amyla
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 
topic-status: Drafting
---

# Dynamics 365 for Sales and GDPR

To comply with GDPR, we’ve made it possible to edit read-only records in [!INCLUDE[pn-sales-enterprise-doc-name-shortest](../includes/pn-sales-enterprise-doc-name-shortest.md)].

The following table shows the states in which the [!INCLUDE[pn-sales-enterprise-doc-name-shortest](../includes/pn-sales-enterprise-doc-name-shortest.md)] records become read-only. 

|  Entity  |  State  |
|  ------  |  -----  |
|  Quote   | Active/Closed |
|  Order   | Fulfilled/Canceled/Submitted/Invoiced |
|  Invoice | Paid/Canceled/Closed | 

In case of orders and invoices, a system administrator can export read-only records, update them, and import back to [!INCLUDE[pn-sales-enterprise-doc-name-shortest](../includes/pn-sales-enterprise-doc-name-shortest.md)]. In case of quotes, both, a system administrator and a user, can export read-only records and import the updated records back into the system. 

It is also possible to update the read-only records programmatically with the SDK for [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] Customer Engagement.

## Update read-only records through export/import

1.  In your sales app, go to the list of records. For example, go to **Sales** > **Quotes**.

2.  Open the view that shows all the records regardless of their state. For example, open the **All Quotes** view.

3.  Select the records that you want to export, and on the command bar, select **Export to Excel** > **Static Worksheet**. More information: [Export data to Excel](../basics/export-data-excel.md)

4.  In the file that you exported, make the necessary changes.

5.  To import the updated records back into [!INCLUDE[pn-sales-enterprise-doc-name-shortest](../includes/pn-sales-enterprise-doc-name-shortest.md)], in your sales app, in the list of records, select **Import Data**. More information: [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)


## Important points

-  As a system administrator, you can edit any read-only field but changes will not reflect for the locked fields. 

-  If configured, Plugins, Business processes and workflows will run on fields getting updated or becoming editable. 

-  In case of (../includes/pn-dynamics-365.md)] Customer Engagement integration with any third-party system, there is a chance of GDPR requested changes to be overwritten if correct sequence of updates is not followed. It is the (../includes/pn-dynamics-365.md)] Customer Engagement system administrator's liability to follow the correct order. 

-  The (../includes/pn-dynamics-365.md)] Customer Engagement system administrator may end up updating fields on the Order entity, which may be required for audit purposes or the administrator may end up altering the order record in a way that changes the original order scope. The responsibility and liability of such an event is entirely on the (../includes/pn-dynamics-365.md)] Customer Engagement system administrator. 

To know more about GDPR compliance, see [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/en-us/dynamics365/get-started/gdpr/index).
