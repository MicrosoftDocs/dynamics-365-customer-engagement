---
title: "Integrate Dynamics 365 Field Service and Supply Chain Management | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/03/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Integrate Dynamics 365 Field Service and Supply Chain Management

While Dynamics 365 Field Service includes basic [inventory capabilities](./inventory-purchasing-returns-overview.md) for managing technician truck stock, tracking asset service history, requesting purchase orders, and documenting returns; many field service organizations still integrate Field Service with their Enterprise Resource Planning (ERP) systems. Organizations using the Microsoft Dynamics 365 stack will find it easy to integrate Dynamics 365 Field Service and [Dynamics 365 Supply Chain Management](https://docs.microsoft.com/dynamics365/supply-chain/) systems. 

Leveraging the common data model and common data service in Dynamics 365, you can set up a synchronous two-way integration for the following five entities, with more entities planned: 

- **Warehouse**
- **Customer Asset**
- **Customer Asset Category**
- **Payment Terms**
- **Ship Via**

This first round of integration is important for two key scenarios:

1. **Asset management**: When creating a work order for repair or maintenance on a customer asset, the integration will allow dispatchers to pick from a full list of customer assets, regardless of which system it was created in.
2. **Nearby warehouses**: Integration provides technicians with a complete list of nearby warehouses and relevant details.

## Prerequisites

- As of February 3, 2020, this feature is available in public preview

- To view integrated data, you need the required license and security for one system. Only a few IT administrators will need access to both Dynamics 365 Field Service *and* Supply Chain Management. In other words, users only need a license for the interface in which they are accessing the data.


## How it works

The integration is made possible because Field Service is built on top of Common Data Service and [Dual Write](https://powerapps.microsoft.com/blog/announcing-dual-write-preview/), which writes changes in Dynamics 365 Supply Chain Management to Common Data Service and vice versa.

After Dual Write is enabled, a solution is imported into Field Service that adds the required fields to make the entities in each system integratable. 

For example, in Field Service, you'll see new fields added to the warehouse entity that are required in Supply Chain Management.

> [!div class="mx-imgBorder"]
> ![Screenshot of a warehouse in Dynamics 365 Field Service.](./media/inventory-warehouse-supply-chain1.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of a warehouse, showing the integration section](./media/inventory-warehouse-supply-chain2.png)

When a warehouse record is created or updated in either system, the change will show in the other system in near real time.

Business rules and validations in either system are respected in the other system. For example, imagine a warehouse can't be created in Supply Chain Management without a specific field value. When a user attempts to create the warehouse in Field Service, an error will appear based on the validation logic in Supply Chain Management.


## Additional Notes

- Dual Write allows organizations to integrate Supply Chain Management with Common Data Service, even without Field Service. 

- The Dual Write integration described in this article is separate and more robust than the previously released [Prospect to Cash](https://docs.microsoft.com/dynamics365/supply-chain/sales-marketing/prospect-to-cash) data integrator that is one-direction, batch, asynchronous, and does not respect business rules and validations. 

## See also

- [Overview of Dynamics 365 Field Service inventory capabilities](https://docs.microsoft.com/dynamics365/field-service/inventory-purchasing-returns-overview)

- [Customer assets in Dynamics 365 Field Service](https://docs.microsoft.com/dynamics365/field-service/configure-set-up-customer-assets)

- [Pricing in Dynamics 365 Field Service](https://docs.microsoft.com/dynamics365/field-service/create-price-list) 


