---
title: "Integrate Field Service and Finance & Operations Supply Chain Management | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Integrate Field Service and Finance & Operations Supply Chain Management

Customers often need support for both supply chain management and field service scenarios as part of their Dynamics 365 deployment. They need these two solutions to work well together, which we support by integrating Dynamics 365 Field Service with Dynamics 365 Supply Chain Management. Leveraging the common data model and common data service in Dynamics 365, you can use Supply Chain Management features including warehouse, payment type, and shipment method.

This is only the first step in Field Service and Supply Chain Management integration. Further integration will be developed over time.



A synchronous (realtime) two way integration between  [Supply Chain Management](https://docs.microsoft.com/en-us/dynamics365/supply-chain/)

As of today, 4 entities are integrated between Field Service and Supply Chain Management with more expected:

- Warehouse
- Customer Asset
- Payment Terms
- Ship Via



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-warehouse-supply-chain1.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-warehouse-supply-chain2.png)

## Prerequisites
> [!Note]
>

Public preview 

## How does it work?

When dual write is enabled, a solution is imported into field service that adds fields to allow a synchronization Field Service and Supply Chain Management

updating fields will be kpet in sync


Creating a warehouse in field service creates a record in Common Data Service and [dual write](https://docs.microsoft.com/en-us/business-applications-release-notes/april19/cdm-data-integration/dual-write-link-common-data-service-apps) connects Supply Chain management to Common Data Service

respect business logic 

## Why is it useful

technicians will have a view of all warehouses and customer assets



## Configuration considerations
## Additional Notes

this is better than the [prospect to cash](https://docs.microsoft.com/en-us/dynamics365/supply-chain/sales-marketing/prospect-to-cash) data integrator which is one direction, batch, asynchronous and doesnt respect rules

asynchronous and batch exists today and this is a more robusy version of prospect to cash

can integrate to common tables in CDS (Warehouse, Customer Asset, Account, etc) even without field service


