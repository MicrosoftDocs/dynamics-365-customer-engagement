---
title: Field Service (Preview) Outlook add-in with Copilot for the Frontline Manager
description: Learn about the Dynamics 365 Field Service (Preview) Outlook add-in to create, view, and edit work orders.
ms.date: 05/22/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) Outlook add-in with Copilot for the Frontline Manager

The Dynamics 365 Field Service (Preview) provides an Outlook add-in for frontline managers to manage work orders without disrupting their workflow. As a frontline manager, you can create, view, and edit work orders directly from your email without leaving Outlook. You can quickly respond to requests for service or questions about existing requests.

The Field Service Outlook Add-in (Preview) provides copilot capabilities where you can use the copilot to quickly create a work order with the information from the email. Or, you can create a work order manually.

## Install the Field Service (Preview) Outlook add-in

If you don’t already have Outlook and Field Service licenses, contact your organization’s IT administrator. If your admin installed the add-in for your organization, you can skip this step.

### Prerequisites

- Outlook on the Web
- Outlook 2013 or later on Windows (or Mac)

### Install the Outlook Add-in

1. [Install the Outlook Add-in](https://support.microsoft.com/en-us/office/get-an-office-add-in-for-outlook-1ee261f9-49bf-4ba6-b3e2-2ba7bcab64c8#:~:text=1%20In%20Outlook%2C%20click%20Home%20%3E%20Store%20on,trials%2C%20select%20Get%20it%20to%20...%20See%20More). In the **Add-Ins for Outlook** dialog box, search for **Field Service (Preview)** and select it.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Field Service (Preview) add-in card":::

1. Select **Add**.

## Open the Field Service (Preview) Outlook add-in

1. While in an email, select **More actions (...)**, and then select **Field Service (Preview)**.

   :::image type="content" source="media/fsp-outlook-sign-in.png" alt-text="Field Service (Preview) Outlook sign-in":::

1. Select **Sign in to get started**.

1. Select your environment. If you don’t know your environment, see [Find your environment and organization ID and name](/power-platform/admin/determine-org-id-name).

1. Select **Get started**.

1. Add **Field Service (Preview)** to your favorites.
   - Select **View** > **View settings**.
   - Select **Mail** > **Customize actions**.
   - Under **Message surface**, select **Field Service (Preview)**.
   - Select **Save**. Close settings.

   The Field Service (Preview) icon :::image type="icon" source="media/fsp-icon.png"::: displays in all your emails.

> [!TIP]
> To keep the **Field Service (Preview)** pane open across all emails, select **Pin**.

:::image type="content" source="media/fsp-email.png" alt-text="Field Service (Preview) Outlook icon highlighted on an open email":::

## Create a work order in Outlook using Copilot in Field Service (Preview)

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Copilot** tab select **Create a work order from email**.

   :::image type="content" source="media/fsp-copilot-tab.png" alt-text="Field Service (Preview) Outlook pane showing Copilot tab":::

   A message displays that the work order is being generated.

1. Review the work order to ensure all AI-generated content is accurate and fill in any additional information.

   :::image type="content" source="media/fsp-copilot-review-work-order.png" alt-text="Field Service (Preview) Outlook pane showing an auto-generated work order for review":::

1. At a minimum, ensure the required information is entered for the work order.

   - [Service Account](../accounts.md)
   - [Work Order Type](../create-work-order-types.md)
   - [Price List](../create-price-list.md)

1. Select **Save**. After the work order is created, the work order number displays at the top of the **Field Service (Preview)** pane. The **System Status** default is **Unscheduled**.

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the pop-out icon.

   :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Field Service (Preview) Outlook pane highlighting the pop-out icon to go to Field Service":::

See View work orders and Edit a work order for any work orders created by the Copilot or manually.

## Create a work order manually in Outlook

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Work orders** tab, select the **Create work order (+)** button.

   :::image type="content" source="media/fsp-outlook-create-button.png" alt-text="Field Service (Preview) Outlook pane Work Orders tab highlighting the Create button":::

1. At a minimum, enter the required information for the work order.
   - [Service Account](../accounts.md)
   - [Work Order Type](../create-work-order-types.md)
   - [Price List](../create-price-list.md)

   :::image type="content" source="media/fsp-outlook-fsp-pane.png" alt-text="Field Service (Preview) Outlook Create work order pane":::

   > [!TIP]
   > Copy relevant information from the email into the **Description** field. For general information about work orders, see [Work order architecture](../field-service-architecture.md).

1. Select **Save**. After the work order is created, the work order number displays at the top of the **Field Service (Preview)** pane. The **System Status** default is **Unscheduled**.

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the pop-out icon.

   :::image type="content" source="media/fsp-pop-out-icon.png" alt-text="Field Service (Preview) Outlook Work Orders tab highlighting the pop-out icon":::

## View work orders in Outlook

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Work orders** tab, a list of up to 50 work orders display. The most recent work order displays first.

   > [!TIP]
   > To view more work orders in the Field Service app, select **View all in Dynamics 365** at the bottom of the list.

   :::image type="content" source="media/fsp-work-order-list.png" alt-text="Field Service (Preview) Outlook work order list":::

1. To find a particular work order, enter the work order ID in the **Find by ID** box and select **Search**.

1. To filter the work orders by status or priority, select **Filter**, make your choice, and then select **Apply**.

1. Select a work order to view or edit the details.

## Edit a work order in Outlook

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Work orders** tab, a list of up to 50 work orders display.

1. Select the work order you want to edit. Use **Find by ID** or **Filter** to find the work order if necessary.

   :::image type="content" source="media/fsp-work-order-details.png" alt-text="Field Service (Preview) Outlook work order details":::

1. Make the necessary changes and select **Save**.
