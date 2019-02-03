---
title: Changes in the Pre-Sales area (Project Service 3.x)
description: This topic describes solution changes for Project Service 3.x in the Pre-Sales area
author: makk
manager: rchawla
ms.custom:
  - dyn365-projectservice
ms.date: 12/14/2018
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
---


# Changes in the Pre-Sales area (Project Service 3.x)
## Parent-Child relationships for Sales Document, Sales Document Line, Sales Document Line Detail entities

In the older versions of Project Service solution due to platform limitations existing at that time some of the relationships between sales documents, sales document lines and sales document line detail entities were implemented through string fields that would hold a string representation of GUID of the related entity. That also required plenty of custom code on the server and client sides of the solution to make those type of relationships work similar to regular CRM entity relationships and make string fields act like lookup fields.

Starting Project Service 3.0 the solution has been updated to leverage newly introduced entity relationships between sales document and sales document line entities.

The old fields that were holding the string value of the GUID of the related entity (in attempt to indicate that there is a relationship to document lines) were deprecated as they are no longer needed, since regular lookup fields could be used to indicate references the entities (as it happens with the rest of the entities). The custom client and server side code that handles the relationships defined by old string fields got deprecated. 

### Entity schema changes
 Entity |	Deprecated field (Type: String) |	New field (Type: Lookup)
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

### Changes to the custom views and controls
Chargeability view has been removed, relevant artifacts have been deprecated.  
Custom grid controls for showing Quote Line Details on the 'Project Information' form for Quote Line have been removed, relevant artifacts have been deprecated.  
Custom grid controls for showing Project Contract Line Details on the 'Project Information' form for Sales Order Line have been removed, relevant artifacts have been deprecated.  

> For the full list of deprecated resources see the [List of Web Resources Deprecated in Project Service v3.x](../developer-guides/webresources-deprecated-in-v3.x.md)

## Introduction of the Unified Client Interface App Module
With the introduction of UCI App Modules the Project Service site map entries have been removed from the system.  
Functionality related to the form switching for Opportunity, Quote, Order, Invoice has been deprecated as it is no longer required since Project Service App Module includes only Project Service versions of the forms.  

The following web resources got deprecated:

- msdyn_\SalesDocument\SalesDocumentFormLoader.js
- msdyn_\SalesDocument\PSSalesDocumentCustomFormIds.js

> For the full list of deprecated resources see the [List of Web Resources Deprecated in Project Service v3.x](../developer-guides/webresources-deprecated-in-v3.x.md)


