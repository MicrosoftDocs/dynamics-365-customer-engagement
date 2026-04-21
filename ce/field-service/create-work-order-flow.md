---
title: Create work orders using Power Automate
description: Learn how to automatically create work orders in Dynamics 365 Field Service using Power Automate flows with the Dataverse connector.
ms.date: 04/06/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: puneetsingh
ms.custom: bap-template
---

# Create work orders using Power Automate

You can automatically create work orders in Dynamics 365 Field Service using Power Automate flows. This is useful when work orders need to be created based on external triggers, such as an IoT alert, a form submission, a service request from another system, or a change to a related record.

Power Automate flows use the **Microsoft Dataverse** connector to interact with Field Service records. For information on creating work orders through code, go to [Create work orders using the Dataverse Web API](create-work-order-api-example.md).

## Prerequisites

- A Power Automate license (included with most Dynamics 365 licenses).
- At least one of the following Field Service security roles assigned to the flow's connection account. Learn more in [Set up users and security roles](users-licenses-permissions.md).
  - Field Service - Dispatcher
  - Field Service - Administrator
- Existing records for the required lookup fields:
  - **Service Account** (`account` entity)
  - **Work Order Type** (`msdyn_workordertype` entity)
  - **Price List** (`pricelevel` entity)

## Option 1: Create a work order when a Dataverse record changes

Use this pattern to create a work order in response to a change in another Dataverse table, such as when a customer asset's status changes.

### Set up the trigger

1. In [Power Automate](https://make.powerautomate.com), select **Create** > **Automated cloud flow**.

1. Search for and select **When a row is added, modified or deleted** (Microsoft Dataverse connector).

1. When prompted, sign in to the **Microsoft Dataverse** connector using your Dynamics 365 credentials. If you already have a connection to your environment, select it from the dropdown. The trigger's configuration fields don't populate until an active connection is established.

1. Configure the trigger:

   | Field | Value |
   |---|---|
   | **Change type** | Modified |
   | **Table name** | Customer Assets |
   | **Scope** | Organization |

1. Optionally, add a **Filter rows** condition to limit when the flow runs. For example: `msdyn_operationalstatus eq 690970001` (Needs Service).

> [!TIP]
> To test the work order creation steps without changing a Dataverse record, create a copy of your flow and replace the Dataverse trigger with **Manually trigger a flow**. Add input parameters (such as text inputs for the service account ID, work order type ID, and price list ID) so you can pass test values when you run the flow. After you verify that the work order is created correctly, switch back to the Dataverse trigger in your production flow.

### Add the Create work order action

1. Select **+ New step** and search for **Add a new row** (Microsoft Dataverse connector).

1. Select the same Dataverse connection you used for the trigger. The **Table name** field only appears after a connection is selected.

1. Set **Table name** to **Work Orders**.

1. Fill in the required fields:

   | Field | Value |
   |---|---|
   | **Work Order Number** | Enter the expression `guid()` as a placeholder. The Work Order Number field is required by the Dataverse connector UI, but Field Service's autonumber plugin automatically assigns the correct sequential work order number when the record is saved. To enter an expression, select the field, switch to the **Expression** tab in the dynamic content panel, type `guid()`, and select **OK**. |
   | **Service Account** | Select the account using the search field, or enter the expression `concat('/accounts(', 'service-account-guid', ')')` in the **Expression** tab if you need to use a hardcoded or dynamic GUID. See below for how to find this. |
   | **Work Order Type** | Select the work order type using the search field, or enter the expression `concat('/msdyn_workordertypes(', 'work-order-type-guid', ')')` in the **Expression** tab if you need to use a hardcoded or dynamic GUID. See below for how to find this. |
   | **Price List** | Select the price list using the search field, or enter the expression `concat('/pricelevels(', 'your-price-list-guid', ')')` in the **Expression** tab if you need to use a hardcoded or dynamic GUID. If you retrieve the price list dynamically using a **List rows** action inside a **For each** loop, use `concat('/pricelevels(', items('YourLoopName')?['pricelevelid'], ')')` instead, replacing `YourLoopName` with your loop's name. See below for how to find this. |
   | **System Status** | `690970000` (Unscheduled) |
   | **Taxable** | `false` |
   | **Instructions** | Use dynamic content from the trigger, for example the asset name |

   **Service Account**: Type the account name directly in the **Service Account** field to search for and select it. If the trigger is a Customer Asset change and the asset is linked to an account, you can instead select **Account (Customer Assets)** from the dynamic content panel. If you need to use a GUID directly, go to **Service** area > **Customers** > **Accounts** in Field Service, open the account, and copy the record ID from the browser URL (the value between `%7B` and `%7D`, or the plain GUID if the URL is unencoded).

   **Work Order Type**: Type the work order type name directly in the **Work Order Type** field to search for and select it. If you need to use a GUID directly, go to **Settings** area > **Work Order** > **Work Order Types** in Field Service, open the work order type, and copy the record ID from the browser URL.

   **Price List**: Type the price list name directly in the **Price List** field to search for and select it. If you need to use a GUID directly, go to **Settings** > **General** > **Price Lists** in Field Service, open the price list, and copy the record ID from the browser URL.

   > [!NOTE]
   > The Dataverse connector requires lookup fields to use an OData entity reference path (for example, `/accounts(guid)`) rather than a plain GUID. Entering a bare GUID causes an `ODataUnrecognizedPathException` at runtime. The `concat` expressions above construct the correct path format.

1. Save and test the flow.

## Option 2: Create a work order from an HTTP request

Use this pattern to create a work order from an external system, such as a customer portal, ticketing system, or IoT platform.

### Set up the trigger

1. In Power Automate, select **Create** > **Instant cloud flow**.

1. Name the flow and select **When an HTTP request is received** as the trigger.

1. Select **Create**.

1. In the **Request Body JSON Schema** field, paste the following schema:

   ```json
   {
     "type": "object",
     "properties": {
       "serviceAccountId": { "type": "string" },
       "workOrderTypeId": { "type": "string" },
       "priceListId": { "type": "string" },
       "instructions": { "type": "string" }
     },
     "required": ["serviceAccountId", "workOrderTypeId", "priceListId"]
   }
   ```

1. For **Who can trigger the flow**, select one of the following options:

   | Option | When to use |
   |---|---|
   | **Only users in my tenant** | **Recommended for production.** Callers must authenticate with Microsoft Entra ID and present a valid OAuth bearer token. Use this for internal systems or trusted service principals. |
   | **Anyone** | The URL itself acts as the credential — no additional auth header is required. Use only when the calling system cannot obtain an Entra ID token and you can ensure the URL is stored securely. |

   Learn more about securing HTTP-triggered flows in [Add OAuth authentication for HTTP request triggers](/power-automate/oauth-authentication).

1. The **HTTP URL** field is read-only — don't fill it in. Power Automate automatically populates it when you save the flow for the first time.

1. Save the flow. The **HTTP URL** field is now populated with the endpoint URL. Copy this URL and provide it to whoever configures the external system (such as a developer or system administrator). The external system triggers the flow by sending an HTTP POST request to this URL with a JSON body that matches the schema you defined. For example:

   ```http
   POST <paste the HTTP URL here>
   Content-Type: application/json

   {
     "serviceAccountId": "<account record GUID>",
     "workOrderTypeId": "<work order type record GUID>",
     "priceListId": "<price list record GUID>",
     "instructions": "Reported issue: equipment not functioning"
   }
   ```

   Each time the external system sends this request, Power Automate runs the flow and creates a work order in Field Service.

### Add the Create work order action

1. Select **+ New step** and search for **Add a new row** (Microsoft Dataverse connector).

1. Sign in to the Microsoft Dataverse connector or select an existing connection. The **Table name** field only appears after a connection is selected.

1. Set **Table name** to **Work Orders**.

1. Map the HTTP request body fields to the work order fields:

   | Work order field | Value |
   |---|---|
   | **Work Order Number** | Enter the expression `guid()` as a placeholder. The Work Order Number field is required by the Dataverse connector UI, but Field Service's autonumber plugin automatically assigns the correct sequential work order number when the record is saved. To enter an expression, select the field, switch to the **Expression** tab in the dynamic content panel, type `guid()`, and select **OK**. | 
   | **Service Account** | `concat('/accounts(', triggerBody()?['serviceAccountId'], ')')` |
   | **Work Order Type** | `concat('/msdyn_workordertypes(', triggerBody()?['workOrderTypeId'], ')')` |
   | **Price List** | `concat('/pricelevels(', triggerBody()?['priceListId'], ')')` |
   | **System Status** | `690970000` (Unscheduled) |
   | **Instructions** | `@{triggerBody()?['instructions']}` |

1. Optionally, add a **Response** action to return the new work order ID to the calling system:

   1. Select **+ New step** and search for **Response** (from the **Request** connector).
   1. Set **Status Code** to `200`.
   1. In the **Body** field, select the dynamic content icon and choose **msdyn_workorderid** from the **Add a new row** step. This is the unique ID of the work order that was just created.

   Without this step, the calling system receives no response and the HTTP request times out after waiting. If you add this step, the calling system receives a `200` response with the work order ID as soon as the flow completes.

## System Status option set values

Use these integer values when setting **System Status** in a flow or API call.

| Label | Value |
|---|---|
| Unscheduled | `690970000` |
| Scheduled | `690970001` |
| In Progress | `690970002` |
| Completed | `690970003` |
| Posted | `690970004` |
| Canceled | `690970005` |

## Considerations

**Flow connection account ownership**

Work orders created by a flow are owned by the connection account used in the Dataverse connector. Ensure this account has the correct security role and that work orders created by the flow appear in the expected views and queues.

**Child records**

The **Add a new row** action creates only the work order header. To add work order products, services, or service tasks, add separate **Add a new row** steps for each child table (`msdyn_workorderproduct`, `msdyn_workorderservice`, `msdyn_workorderservicetask`) and set the **Work Order** lookup field to the ID returned by the create step.

**API rate limits**

Power Automate flows are subject to Dataverse API limits. For high-volume scenarios, consider using the [Dataverse Web API batch endpoint](create-work-order-api-example.md) or spreading flow runs using a scheduled trigger with batch processing.

**Avoiding duplicate work orders**

If a flow runs frequently on the same trigger, add a condition to check whether a work order already exists before creating a new one. Use a **List rows** action filtered by the source record ID to check for existing work orders.

**Error handling**

For production flows, wrap the **Add a new row** step in a **Scope** action and add a parallel branch configured to run **has failed**. Use this branch to log the error or send a notification. For HTTP-triggered flows, always add a **Response** action so the calling system receives a success or failure status code rather than timing out.

## Next steps

- [Create work orders using the Dataverse Web API](create-work-order-api-example.md)
- [Schedule a work order](universal-resource-scheduling-for-field-service.md)
- [Work order life cycle and statuses](work-order-status-booking-status.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
