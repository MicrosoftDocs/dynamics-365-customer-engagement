---
title: Entity, control, and user interface changes (Project Service Automation 3.x)
description: This topic describes solution changes for Microsoft Dynamics Project Service Automation 3.x.
author: makk
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 03/15/2019
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: makk
audience: admin
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365PS
  - ProjectOperations
---


# Entity, control, and user interface changes (Project Service Automation 3.x)
With the release of Microsoft Dynamics Project Service Automation (PSA) 3.x, many changes have been made to the entities, controls, views, and user interface. This topic provides information about these important changes.

## Parent-child relationships for sales document, sales document line, sales document line detail entities
In versions of Dynamics 365 Project Service Automation (PSA) released prior to version 3.0, some of the relationships between sales documents, sales document lines, and sales document line detail entities were implemented through string fields that would hold a string representation of GUID of the related entity. This was due to platform limitations that required significant custom code on the server and client sides of the solution to make those relationships work similar to typical Dynamics CRM entity relationships and to make string fields act like lookup fields.

PSA 3.0 has been updated to leverage the new entity relationships between sales document and sales document line entities.

Because lookup fields can now be used to indicate references to entities, the fields that held the string value of the GUID of the related entity in previous versions are no longer needed and therefore have been deprecated. The custom client and server side code that handles the relationships defined by legacy string fields has also been deprecated.

### Entity schema changes
The following table provides a one-to-one list of the deprecated string fields and the new lookup fields for the entities. 

 Entity |	Deprecated field (String) |	New field (Lookup)
--- | --- | ---
invoicedetail (Invoice Line) |	msdyn_contractline |	msdyn_contractlineid
msdyn_actual (Actual) |	msdyn_salescontractline |	msdyn_salescontractlineid
msdyn_contractlineinvoiceschedule (Project Contract Line Invoice Schedule) |	msdyn_contractline |	msdyn_contractlineid
msdyn_contractlinescheduleofvalue (Project Contract Line Milestone) |	msdyn_contractline |	msdyn_contractlineid
msdyn_fact (Fact) |	msdyn_salescontractline |	msdyn_salescontractlineid
msdyn_invoicelinetransaction (Invoice Line Detail) | msdyn_invoiceline <br> msdyn_salescontractline | msdyn_invoicelineid <br> msdyn_salescontractlineid
msdyn_journalline (Journal Line) |	msdyn_salescontractline |	msdyn_salescontractlineid
msdyn_orderlineresourcecategory (Project Contract Line Resource Category) |	msdyn_salescontractline |	msdyn_contractlineid
msdyn_orderlinetransaction (Project Contract Line Detail) |	msdyn_salescontractline |	msdyn_salescontractlineid
msdyn_orderlinetransactioncategory (Project Contract Line Transaction Category) |	msdyn_contractline |	msdyn_contractlineid
msdyn_orderlinetransactionclassification (Project Contract Line Transaction Classification) |	msdyn_contractline |	msdyn_contractlineid
msdyn_quotelineinvoiceschedule (Quote Line Invoice Schedule) |	msdyn_quoteline |	msdyn_quotelineid
msdyn_quotelineresourcecategory (Quote Line Resource Category) |	msdyn_quoteline |	msdyn_quotelineid
msdyn_quotelinescheduleofvalue (Quote Line Milestone) |	msdyn_quoteline |	msdyn_quotelineid
msdyn_quotelinetransaction (Quote Line Detail) |	msdyn_quoteline |	msdyn_quotelineid
msdyn_quotelinetransactioncategory (Quote Line Transaction Category) |	msdyn_quoteline |	msdyn_quotelineid
msdyn_quotelinetransactionclassification (Quote Line Transaction Classification) |	msdyn_quoteline |	msdyn_quotelineid
SalesOrderDetail (Order Line) |	msdyn_quotelineid |	msdyn_quoteline 

### Deprecated custom views and controls
The following custom views and controls, and their related artifacts, have been deprecated.

- Chargeability view.
- Custom grid controls for showing quote line details on the **Project Information** page for the quote line.
- Custom grid controls for showing project contract line details on the **Project Information** page for the sales order line.

> [!NOTE]
> For the full list of deprecated resources, see [Deprecated Web resources in Project Service Automation v3.x](../developer-guides/web-resources-deprecated-v3.x.md)

## Unified Client Interface App Module
With the introduction of Unified Client Interface (UCI) App Modules, the PSA site map entries have been removed from the system.  
Functionality related to form switching for Opportunity, Quote, Order, Invoice has been deprecated as it is no longer required because the UCI App Module includes only PSA versions of the forms.  

The following web resources have been deprecated:

- msdyn_\SalesDocument\SalesDocumentFormLoader.js
- msdyn_\SalesDocument\PSSalesDocumentCustomFormIds.js

> [!NOTE]
> For the full list of deprecated resources, see [Deprecated Web resources in Project Service Automation v3.x](../developer-guides/web-resources-deprecated-v3.x.md).


