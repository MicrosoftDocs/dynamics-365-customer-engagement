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
> ![Screenshot of new service account](./media/.png)


## Create a service account

First lets create a service account that represents a specific customer location where work orders will be performed. Whether it is a service account or a billing account, they are both simply account records. The main difference is it is recommended service accounts have addresses and are geo coded.

Go to **Field Service > Accounts > +New**

Enter an **Account name** and an **address** along with other important details based on your business needs.

Next, select **Geo Code** at the top fo the form. If you have Set **Auto Geo Code** to **Yes** in Field Service Settings as noted in the prerequisites then you can skip this step. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-service-account-create.png)

Confirm geo coding is successful by the location visualized on the map and values populated in the latitude and longitude fields in the Scheduling section. 


> [!div class="mx-imgBorder"]
> ![Screenshot of geo coded account](./media/service-account-scheduling-section.png)

Next, go the Field Service section of the account form and fill in details based on your business needs. Values entered here are passed down to work orders where this account is listed as the service account, but the values can be edited on each work order as needed.

**Billing Account:** The value chosen here will populate the billing account field on the work order when this account is entered as the service account. This field is not required, and if no account is entered here, the service account listed on the work order will act as both the service account and the billing account. In the example image below, Winery Inc. is the Billing Account for the service account, Coho Winery. This implies Coho Winery is a specific location of Winery Inc. and invoices should be listed for Winery Inc.

**Price List:** This value is listed on related work orders and all related work order products and services and dictates the price of those products and services on the resulting invoices. If the billing account field in the previous step has a value, then the price list on the billing account record will be used. If no billing account is entered, then the price list entered here will be used on resulting work orders and invoices. If the work order products or services are not listed on the price list, then the list price on the product record is used. 

**Tax Exempt:** Decides if sales tax should be added to the price of related work orders. Set to **Yes** to not add sales tax. Set to **No** to specify a sales tax code (percentage) that should be added to the work order price and invoice.

**Service Territory:** Choose the geographical region this account is located in. This value will be passed down to the related work orders and work order requirements and is considered in the scheduling process on the schedule board, in the schedule assistant, and with resource scheduling optimization (RSO).

**Travel Charge Type:** Decide if and how travel by a field technician to this service account should be priced and billed on work orders. See configuration considerations in this article for more details.

**Work Order Instructions:** The value here serves as a text note and populates the **Instructions** field on all related work orders. This is a good way to ensure field technicians follow processes specific to this account. See an example in the image below.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service related values for a specific account](./media/service-account-field-service-section.png)

> [!Note]
> Updating these values will not update previous work orders, only future work orders.


## create a work order for the service account

Next, go to **Field Service > Work Orders > +New**

Add the account you just created as the service account. 


Notice the following values automatically populated.

**Billing Account** - populated as the billing account specified on the service account record.

**Price List** - populated as the price list specified on the **billing account** record.

> [!div class="mx-imgBorder"]
> ![Screenshot of new work order with the account just created listed as a service account](./media/work-order-service-account.png)

> [!Note]
> If the work order price list does not reflect the price list entered on your service account or billing account, this means it is being overridden by the price list related to Work Order Types or Entitlements.

**Service Territory and Instructions**

> [!div class="mx-imgBorder"]
> ![Screenshot of service territory and instructions](./media/work-order-account-territory-instructions.png)

**Address**

> [!div class="mx-imgBorder"]
> ![Screenshot of address of service account passed down to work order address](./media/work-order-account-address.png)

**Location**

This work order location is passed down to the work order requirement and is reflected on the schedule board map. 

> [!div class="mx-imgBorder"]
> ![Screenshot of work order map location](./media/work-order-account-map.png)

**Pro Tip:** You can select and drag the map pin to edit the work order location (latitude and longitude) as needed. This is helpful for scenarios where the address points to an arbitrary location at a university campus for example, but the work order must take place at a specific building or location on the campus.

> [!Note]
> Work Orders can be assigned addresses and geo coded independent of the service account if needed.

## Configuration considerations

### Travel charge explained

If the service account (not billing account) of the work order has a travel charge type set, then a work order product for a travel charge will be added when the **Work Order System Status** becomes **Open-Completed** after being booked. 

First, go to **Field Service > Settings > Field Service Settings** and specify a product in the **Travel Charge Item** field. 

> [!div class="mx-imgBorder"]
> ![Screenshot of travel charge item in field service settings](./media/field-service-settings-travel-charge.png)

This is the product that will later show as a work order product.

> [!div class="mx-imgBorder"]
> ![Screenshot of travel charge added as a work order product](./media/work-order-service-account-travel-charge-product.png)

> [!Note]
> The travel charge work order product is subject to the same pricing rules as all work order products and services. The unit amount pricing of travel charge work order products is dictated first by the **price list**, if the travel charge product is not part of the price list as a price list item then the **list price** on the travel charge product will be used, and lastly if no list price is entered, the unit amount price will be the value entered in the service account **travel charge**.


Though the uit amount price of the travel charge is dictated by the price list, list price, and travel charge, the quantity is dictated by the **Travel Charge Type** on the service account.

- **Hourly:** Quantity will be the **Actual Travel Duration** of the booking / 60 minutes. As an example, if the unit amount price of the Travel Charge is set to $60 and actual travel duration is 30 minutes, the travel charge work order product will be priced as $30.
- **Mileage:** Quantity is the **Miles Traveled** of the booking. As an example, if the unit amount price of the Travel Charge is set to $1 and miles traveled is 20 miles, the travel charge work order product will be priced as $20.
- **Fixed:** Quantity is **1**. As an example, if the unit amount price of the Travel Charge is set to $50, the travel charge work order product will be priced as $50, regardless of miles or time spent traveling. 
- **None:** No travel charge will be added to the work order.

> [!Note]
> In cases of multiple bookings for a single work order, multiple travel charges will be added as work order products.


