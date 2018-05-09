---
title: "Use lookup field on forms (Dynamics 365 for Sales) | Microsoft Docs"
description: "Learn how to use lookup fields on fileds in Dynamics 365 for Sales."
keywords: "Lookup fields, forms"
ms.date: 12/15/2017
ms.service: "crm-online"
ms.topic: "use-lookup-field-forms"
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.custom:
  - Sales
ms.assetid: ef027076-0d9d-4ae4-b111-dfd176221d67
author: udag 
ms.author: udag
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Use lookup field on forms

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc-applies-to-update-9-0-0.md)]

Lookup helps you to choose records from related entity (recordset) quickly in [!INCLUDE[pn-crm-shortest](../includes/pn-crm-shortest.md)]. When you select a related entity and you type search criteria, such as a name or email address, lookup automatically begins to resolve the partial text and displays any matching records. If no records are displayed after you have typed the full text of your search criteria, a message is displayed specifying that there are no records.
For example, you are searching for the name **Adrian Dumitrascu**. When you type **ad**, possible matching records are automatically populated and displayed.

![Automatically populates matching records](media/populate-matched-records.png "Automatically populates matching records")

> [!Note]
> An administrator can define the criteria that lookup uses for resolving partial search text.

Also, you can create a new record by selecting the add new button (**+New**). You must have sufficient permissions to view the **New** button to create a record. 
When you select the lookup field, the five most recently used records are displayed along with five favorite records. Which records are displayed depends on your view history and the favorites you’ve pinned. 
For example, if you have only three records in your history, lookup will display those three along with seven of your favorite records. If you have not pinned any favorites, only the most recently viewed records will be displayed. 

> [!Note]
> The number of favorites or recently visited records depends on the device and application type that you are using such as mobile and tablet devices. 

## Types of lookups
Lookups are classified into two types: 
- **Simple lookup:** Select a single record in a field from a single entity. 
- **Complex lookup:** Select a single record or multiple records in a field from multiple entities: 
    - **Regarding-type fields:** Use to select a single record from multiple tabs in lookup.
    - **Party-type fields:** Use to select multiple records from multiple tabs in lookup.
    Use party-type fields to select multiple records. This allows you to add each record by performing a new search, multiple times. Every time you select a record, you will be able to perform a new search for another record.

## Create a new record if you don’t find an existing record
If you did not find a record, select **+ New** in the lookup area to create a new record.

## Replace an existing record from a lookup field
You can replace an existing record while using simple and regarding-type lookups. Select the search icon to search for a record, then select the record and replace it with a new record. 

Change a view in a lookup field
Selecting Change View lets you determine:

- How you want to view records such as **Contacts Being Followed**, **Contacts Lookup View**, or **Active Contacts**. 
- What you want to view in the records, such as name, email, and telephone. 
    For example, if you want to view only the contacts that you follow, select **Change View** > **Contacts being followed**. Only the contacts that you are following will be displayed. The following image illustrates this example:

    ![Change view contacts types](media/change-view-contacts.png "Change view contacts types")

> [!Important]
> Contact your administrator to configure **Change View** option for lookup. The **Change View** option will not be visible, if the administrator didn’t configure the **Change View** option to appear in any views.

## Choose from multiple records
When lookup has more records in a field than can fit in the available display area, the display area is collapsed—that is, the records that do fit the display area are shown next to the number of records that are not shown. To view all records, select the number. The following images show the difference between collapsed and non-collapsed fields.

**Collapsed:**

![Collapsed multi-lookup display area](media/multilookup-collapsed.png "Collapsed multi-lookup display area")

**Non-collapsed:**

![Non-collapsed multi-lookup display area](media/noncollapsed-multilookup.png "Non-collapsed multi-lookup display area")

### See Also
[User guide (Sales, Preview)](user-guide-dynamics-365-sales.md)
