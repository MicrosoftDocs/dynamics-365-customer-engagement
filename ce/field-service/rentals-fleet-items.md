---
title: View fleet items (preview)
description: Learn how to view fleet items in Field Service and review equipment status, location, rental contracts, asset associations, and movement history.
ms.date: 10/26/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# View fleet items in Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Use the **Fleet Items** page in Dynamics 365 Field Service to review equipment details, including status, location, asset associations, rental contracts, and movement history. Fleet items become available after users create and submit them in finance and operations. Finance and operations maintains the information.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## View fleet items

1. In Field Service, select the **Service** area. Under **Assets**, select **Fleet Items**. Or, select the fleet item from the **Work Order Request** page.

1. Open a fleet item.

   :::image type="content" source="media/rentals-view-fleet-items.png" alt-text="Screenshot of Fleet Items in Field Service." lightbox="media/rentals-view-fleet-items.png":::

1. View the following information.

   | Field                  |Description  |
   | -----------------------| -------------------- |
   | **Name**               | The display name of the fleet item (for example, Contoso Bulldozer XYZ).  |
   | **Fleet item ID**      | A unique identifier for the fleet item within the system. For example, CTX-000021. |
   | **Account**            | The service account associated with the fleet item. |
   | **Serial number**      | The manufacturer-provided serial number used to uniquely identify the physical unit.    |
   | **Rental Agreement Status** | Represents the commercial state of the equipment in relation to a rental agreement, such as whether it's available, currently rented, returned, or sold. |
   | **Status Reason**      | Provides additional context or explanation for the current status of the equipment. |
   | **Functional Location**| Identifies where the equipment is located or deployed, such as a job site, warehouse, or facility. |
   | **Fleet Type**         | Defines how the equipment is categorized within the fleet based on ownership or usage. For example, Rental, Lease, Customer, Competitive, or Service Truck. |
   | **Attached To**        | Indicates if the item is linked to another piece of equipment or parent asset. |
   | **Product**            | The associated product record that defines the equipment type. |
   | **Manufacturer**       | The company that produced the equipment. |
   | **Model**              | The specific model of the equipment (for example, Oven123).   |
   | **Rental Class**       | A classification used to group similar fleet items for operational or pricing purposes. |

   You can change the **Name**, **Rental Agreement Status**, and **Status Reason**, but finance and operations isn't updated with the changes.

   > [!TIP]
   > If you need to see Company, Eligible For Service, Is Attachment, and equipment dates such as Order Date, Delivery Date, Received Date, Manufacture Date, and Sell Date, ask your administrator to provide them in another view or form.

1. View service requests for the fleet item under **Related Work Order Requests**.

## View related rental contracts and movement history

The fleet item also shows related **Rental Contracts** and **Movement History** so you can see the equipment’s commercial history and movement through the rental lifecycle. Create and manage these records in finance and operations, which remains the system of record. Updates made there appear on the fleet item in Field Service.

## Related information

- [Manage work order requests in Field Service (preview)](rentals-work-order-requests.md)
- [Supply Chain Management rental management overview (preview)](/dynamics365/supply-chain/rental-management/rental-management-overview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
