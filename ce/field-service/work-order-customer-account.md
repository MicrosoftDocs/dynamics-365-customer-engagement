---
title: "Add a customer, location, and related account details to a work order | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/01/2019
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

# Add a customer, location, and related account details to a work order

Dynamics 365 for Field Service utilizes accounts and contacts during the work order process. Accounts represent who is receiving on site service, where the work order must be performed, and which customer account should be billed for invoices generated from the work order.

**Service accounts** represent **who** the receiving account of the on site service (work order) is and **where** the work order will be performed and the field technician will be dispatched to.

**Billing accounts** represent which account should receive invoices and who the parent account is in cases where many service accounts belong to a central organization (ex: multiple wine vineyards are owned by a wine corporation). 

In addition, selecting accounts will auto-populate other fields on a work order.
 
In this article let's explore creating and using accounts on work orders. 

## Prerequisites

Locations are very important in field service scenarios where field technicians may need to be routed to multiple customers' locations each day. For this reason it is highly recommended to 

1. [connect to Bing maps and enable map visualizations](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling) 
2. [enable and test geo coding](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-2-field-service-settings)
 

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Create a service account

- have an account that represents a customer location where service will take place
- add field service information on an account 
- if the service account does not have a different billing account then leave this blank



## create a work order for the service account

- add a service account to a work order
- billing account
- primary contact 
- price list
- location 
  - board

## Configuration considerations
- travel charge type 


## Additional Notes
- can add location to work order without account location
