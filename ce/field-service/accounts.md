---
title: Create and manage customer accounts
description: Learn how to create and use service account and billing accounts in Dynamics 365 Field Service.
ms.date: 01/24/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Create and manage customer accounts

An account represents a customer that receives service from a field service organization. There are two main types of accounts:

- **Service account** is the account that receives the on-site service by a field technician.

- **Billing account** represents the account that receives invoices for the work provided. Usually, it's a shared account for multiple service accounts that belong to a central organization.

For example, a wine producer corporation owns several vineyards. Each vineyard is a service account. The corporation is the billing account.

## Create a service account

1. In Field Service, select the **Service** area. Under **Customers**, select **Accounts**, and then select **New**.

1. Enter the **Account Name** and **Service Address**.

1. Select **Geo Code** at the top of the form to get the latitude and longitude of the service address, and then select **OK**.

    You can also [turn on auto-geocoding](turn-on-auto-geocoding.md) to automatically get the coordinates of a service address.

1. (Optional) Enter as much of the information in the **Summary** tab as you like.

    Adding or updating an account's summary information won't update existing work orders, but will be reflected in future work orders.

1. (Optional) Select the **Details** tab and enter the account's company profile information, contact preferences, and billing and shipping defaults.

1. (Optional) Select the **Service** tab and enter accounting and service defaults for work orders associated with the account.

    - **Billing Account**: Sets the billing account on the work order when this account is selected as the service account. If no billing account is specified, the service account acts as both the service account and the billing account.

    - **Product Price List**: Sets the [price list](create-price-list.md) for this account. If a billing account is specified, work orders use the price list in the billing account record. If the selected price list doesn't contain products or services, the list price on the product record is used.

    - **Tax Exempt**: Determines whether sales tax is added to the price of work orders. Set to **Yes** to *not* add sales tax. Set to **No** to [specify a sales tax code](set-up-tax-codes.md) for the work order price and invoice.

    - **Service Territory**: [Territories for accounts, work orders, and resources](set-up-territories.md) are geographical regions, which are used in work orders and resource scheduling.

    - **Travel Charge Type**: Determines pricing and billing for [travel cost charged for a field technician](travel-charges.md) as a work order product.

    - **Hourly**: A quantity that represents the **Actual Travel Duration** on the booking for a work order for every 60 minutes. For example, if the unit amount price of the travel charge is `60` and the actual travel duration is 30 minutes, the travel charge work order product will be priced as $30.

    - **Mileage**: A quantity that represents the **Miles Traveled** on the booking for a work order. For example, if the unit amount price of the travel charge is `1` and the miles traveled is 20, the travel charge work order product will be priced as $20.

    - **Fixed**: This quantity is `1`. For example, if the unit amount price of the **Travel Charge** is `50`, the travel charge work order product will be priced as $50, regardless of the distance or the travel time.

    - **None**: No travel charge will be added to the work order.

    - **Work Hour Template**: Work template to use for this account.

    - **Work Order Instructions**: A text note that populates the **Instructions** field on work orders. Use this note to help technicians follow processes specific to this account.

1. Select **Save**.

## Next steps

[Create a work order to coordinate and schedule resources and activities](create-work-order.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
