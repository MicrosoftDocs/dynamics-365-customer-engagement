---
title: Synchronize Microsoft Planner with Field Service
description: Learn how to sync work orders from Field Service with Microsoft Planner.
ms.date: 09/20/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
---

# Synchronize Microsoft Planner with Field Service (Preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Dynamics 365 Field Service and Microsoft Planner sync combines work orders and tasks in a single task management application. This feature simplifies task tracking by automatically creating corresponding tasks in Planner for each work order in Field Service. It allows frontline teams to stay organized and responsive, helping businesses achieve greater operational efficiency.

- **Enhanced collaboration**: Frontline workers and back-office teams can track tasks in real time using Planner, improving communication and coordination across the organization.

- **Increased efficiency**: Task management becomes more seamless, reducing the need to switch between platforms to track the progress of work orders.

- **Better organization**: Work orders can be categorized into different buckets in Planner, which reflect the type of work being done, helping teams manage and prioritize tasks effectively.

- **Scalability**: The integration supports multiple business units and environments, allowing for flexible setup across large organizations.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Set up the integration

### Prerequisite

- [Work order types created](create-work-order-types.md)

### Step 1: Set up Microsoft Teams (optional)

If your organization uses Microsoft Teams, it is beneficial to [create a new team](https://support.microsoft.com/office/create-a-team-from-scratch-in-microsoft-teams-174adf5f-846b-4780-b765-de1a0a737e2b) that corresponds to the work order sync. This automatically creates an associated Entra ID group, which will be used later in the integration.

### Step 2: Create a Microsoft Dataverse team

1. In the Power Platform admin center, [create a new Dataverse team](/power-platform/admin/manage-teams#create-a-new-team) in the environment with Field Service installed.

1. For **Team type**, choose **Microsoft Entra Office Group**.

1. For **Group name**, select the Microsoft 365 group that you want to use as the basis for the team.

1. For **Membership type**, choose **Members and guests**.  

### Step 3: Configure business units in Advanced Settings

1. In Field Service, open **Advanced Settings** and go to **Business Units**.

1. Associate the Business Unit with the Dataverse Team: Under the **Frontline Team** field, link the business unit to the Dataverse team created in the previous step.

> [!IMPORTANT]
> The Frontline Team field is not visible when you manage business units in the Power Platform admin center. Use the Advanced Settings in Dynamics 365 instead.

### Step 4: Enable Planner sync in Field Service settings

1. In Field Service, change to the **Settings** area and go to **Field Service Settings**.

1. On the **Features** tab, in the **Planner Task (Preview)** section, turn on the **Planner Task Synchronization** feature.

1. Select **Save** to apply the changes.

## View work orders in Planner

1. [Create a work oder](create-work-order.md) in Field Service, set the corresponding work order type and save it.

1. [Sign in to Planner](https://support.microsoft.com/office/sign-in-to-microsoft-planner-fe43c972-5a95-4071-86d4-423a64a3b21e) to find the synced work order will in the appropriate bucket based on the work order type.

> [!TIP]
> To update or complete the work order, select the link in the Planner task to navigate back to the full work order in Field Service. Direct updates in Planner for work order-related tasks aren't supported.

## Known issues

- Planner supports up to 2,400 active tasks and 9,000 tasks in total. Make sure you mark work orders as completed when done. When you reach 9,000 tasks in total, consider cleaning up tasks in Planner.
- The system allows up to 50 work order types as buckets in Planner. Consolidate work order types to avoid reaching this limit.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
