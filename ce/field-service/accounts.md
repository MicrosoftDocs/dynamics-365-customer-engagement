---
title: Create and manage accounts in Dynamics 365 Field Service
description: Learn how to create and use service account and billing accounts in Dynamics 365 Field Service.
ms.date: 01/18/2023
ms.reviewer: mhart
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Create and manage accounts in Dynamics 365 Field Service

An account represents a customer that receives service from a field service organization. Accounts are a fundamental entity in Dynamics 365 Field Service and they're used in several areas of the application.

There are two main types of accounts:

- **Service account** is the account that receives the on-site service by a field technician.

- **Billing account** represents the account that receives invoices for the work provided. Usually, it's a shared account for multiple service accounts that belong to a central organization.

Example: Multiple vineyards are owned by a wine producer corporation. Every vineyard is a service account that share the corporation as a billing account.

:::image type="content" source="media/service-account-overview.png" alt-text="Screenshot of an account summary.":::

## Create a service account

In this section, we'll create a service account with a geocoded address that represents a specific customer location where work orders will be performed.

1. In Field Service, open the **Service** area.

1. Go to **Customers** > **Accounts** and select **+New**.

1. Enter an **Account name** and a **Service address**.

1. Select **Geo Code** at the top of the form. You can also [enable the auto-geocoding setting](turn-on-auto-geocoding.md).

1. Select **Save** to create the account record.

You can add more details and information to the account form as listed in the sections below. Updating values won't update existing work orders, only future work orders.

## Add account information

On the **Summary** section, you can provide additional information about the account. These fields are optional.

- **Phone**

- **Fax**

- **Website**

- **Parent Account**: For larger organizations, you can define parent/child relations between accounts that define the organization hierarchy.

- **Ticker Symbol**: Stock ticker symbol of the company if it's publicly listed.

## Add contacts for an account

Contacts are individuals that are related to an account. You can add contacts on the **Summary** section.

- **Primary Contact**: The individual that is your main point of contact for an account.

- **Contacts**: Create more contacts or add an existing contact as a reference to the account form.

## Specify details for an account

The **Details** section lets you add more information and preferences to the account record.

- **Company Profile**: Information about the industry and ownership structure of the account.

- **Description**: Text description of the account.

- **Contact Preferences**: Preferred contact method and which contact methods are allowed. This section also lets you defined the primary time zone to ensure you schedule calls and work order at the right time.

- **Billing**: Default billing options for the account.

- **Shipping**: Default shipping method and terms.

## Configure additional details for an account

### Servicing

The **Servicing** section of the account form lists details to provide services to the account and the work orders that are associated to it.

### Accounting

- **Billing Account**: Sets the billing account field on the work order when this account is selected as the service account. If no billing account is selected, the service account acts as both the service account and the billing account.

- **Product Price List**: [Price list configuration](create-price-list.md) for this account. If a billing account is selected, the price list on the billing account record will be used. If products or services aren't listed on the selected price list, the list price on the product record is used.

- **Tax Exempt**: Defines if sales tax gets added to the price of related work orders. Set to **Yes** to *not* add sales tax. Set to **No** to [specify a sales tax code](set-up-tax-codes.md) for the work order price and invoice.

### Service

- **Service Territory**: [Territories for accounts, work orders, and resources](set-up-territories.md) are geographical regions, which are used in work orders and resource scheduling.

- **Travel Charge Type**: Defines pricing and billing for [travel cost charged for a field technician](travel-charges.md) as a work order product.

  - **Hourly:** Quantity is the **Actual Travel Duration** on the booking for a work order per 60 minutes. For example, if the unit amount price of the travel charge is set to 60 and the actual travel duration is 30 minutes. The travel charge work order product will be priced as $30.
  - **Mileage:** Quantity is the **Miles Traveled** on the booking for a work order. For example, if the unit amount price of the travel charge is 1 and miles traveled is 20, the travel charge work order product will be priced as $20.
  - **Fixed:** Quantity is **1**. For example, if the unit amount price of the **Travel Charge** is set to 50, the travel charge work order product will be priced as 50, regardless of distance or time spent traveling.
  - **None:** No travel charge will be added to the work order.

- **Work Hour Template**: Work template to use for this account.

- **Work Order Instructions**: Text note that populates the **Instructions** field on all related work orders. Use this field to help technicians follow processes specific to this account.

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
