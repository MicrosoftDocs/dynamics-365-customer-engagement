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


Creating a warehouse in field service creates a record in Common Data Service and [dual write](https://docs.microsoft.com/en-us/business-applications-release-notes/april19/cdm-data-integration/dual-write-link-common-data-service-apps) connects Supply Chain management to Common Data Service

respect business logic 



## Configuration considerations
## Additional Notes

this is better than the [prospect to cash](https://docs.microsoft.com/en-us/dynamics365/supply-chain/sales-marketing/prospect-to-cash) data integrator which is one direction, batch, asynchronous and doesnt respect rules

asynchronous and batch exists today and this is a more robusy version of prospect to cash


