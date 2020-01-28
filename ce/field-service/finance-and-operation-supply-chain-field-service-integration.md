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

While Dynamics 365 Field Service includes basic [inventory capbilities](./inventory-purchasing-returns-overview.md) for managing technician truck stock, tracking asset service history, requesting purchase orders, and documenting returns; many field service organizations still integrate Field Service with their Enterprise Resource Planning (ERP) system. Organizations utilizing the Microsoft Dynamics 365 stack will find it exceptionally easy to integrate Dynamics 365 Field Service and Finance & Operations [Supply Chain Management](https://docs.microsoft.com/en-us/dynamics365/supply-chain/) systems. 

Leveraging the common data model and common data service in Dynamics 365, you can set up a synchronous two-way integration for the following 4 entities, with more entities planned: 

4 entities are integrated between Field Service and Supply Chain Management with more expected:

- Warehouse
- Customer Asset
- Payment Terms
- Ship Via

This first round of integrtion is particularly important for two key scenarios:

1. **Asset management** - When creating a work order for repair or maintenance on a customer asset, the integration will allow dispatchers to pick from a full list of customer assets regardless of which system it was created in.
2. **Warehouses** - Integration empowers technicians with a complete list of nearby warehouses and relevant details.



## Prerequisites
> [!Note]
>
only need one license, few people will have licenses to both. only need a license for the interface that you are accessing

Public preview 

## How does it work?

When dual write is enabled, a solution is imported into field service that adds fields to allow a synchronization Field Service and Supply Chain Management

updating fields will be kpet in sync


Creating a warehouse in field service creates a record in Common Data Service and [dual write](https://docs.microsoft.com/en-us/business-applications-release-notes/april19/cdm-data-integration/dual-write-link-common-data-service-apps) connects Supply Chain management to Common Data Service

respect business logic 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-warehouse-supply-chain1.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-warehouse-supply-chain2.png)





## Configuration considerations
## Additional Notes

this is better than the [prospect to cash](https://docs.microsoft.com/en-us/dynamics365/supply-chain/sales-marketing/prospect-to-cash) data integrator which is one direction, batch, asynchronous and doesnt respect rules

asynchronous and batch exists today and this is a more robusy version of prospect to cash

can integrate to common tables in CDS (Warehouse, Customer Asset, Account, etc) even without field service

same table with no dupicate data

## See also

inventory
customer assets
pricing


