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

Examples include: 
- passing account (customer) price lists to all related work orders.
- passing the account territory to all related work orders to ensure resources devoted to that territory are scheduled to perform the on site work.
 
In this article let's explore creating and using accounts on work orders. 

## Prerequisites

Locations are very important in field service scenarios where field technicians may need to be routed to multiple customers' locations each day. For this reason it is highly recommended to: 

1. [connect to Bing maps and enable map visualizations](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling) 
2. [enable and test geo coding](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-2-field-service-settings)
 



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Create a service account

First lets create a service account that represents a specific customer location where work orders will be performed. Whether it is a service account or a billing account, they are both simply account records. The main difference is it is recommended service accounts have addresses and are geo coded.

Go to **Field Service > Accounts > +New**

Enter an **Account name** and an **address** along with other important details based on your business needs.

Next, select **Geo Code** at the top fo the form. If you have Set **Auto Geo Code** to **Yes** in Field Service Settings as noted in the prerequisites then you can skip this step. 

Confirm geo coding is successful by the location visualized on the map and values populated in the latitude and longitude fields in the Scheduling section. 

Next, go the Field Service section of the account form and fill in details based on your business needs. Values entered here are passed down to work orders where this account is listed as the service account, but the values can be edited on each work order as needed.

**Price List:** This value is listed on the work order and all related work order products and services and dictates the price of those products and services on the resulting invoice. If the work order products or services are not listed on the price list, then the list price on the product record is used.

**Billing Account:** The value chosen here will populate the billing account field on the work order when this account is entered as the service account. This field is not required, and if no account is entered here, the service account listed on the work order will act as both the service account and the billing account.

**Tax Exempt:** Decides if sales tax should be added to the price of related work orders. Set to **Yes** to not add sales tax. Set to **No** to specify a sales tax code (percentage) that should be added onto the work order price and invoice.

**Service Territory:** Choose the geographical region this account is located in. This will be passed down to the work order and work order requirement

**Travel Charge Type:**

**Work Order Instructions:** 


> [!Note]
> Updating these values will not update previous work orders, only work order going forward.


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
