---
title: Field Service Outlook add-in with Copilot for the Frontline Manager (preview)
description: Learn about the Dynamics 365 Field Service (Preview) Outlook add-in to create, view, and edit work orders.
ms.date: 09/01/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service Outlook Add-in with Copilot for the Frontline Manager (preview)

[!INCLUDE[public-preview-banner](../includes/public-preview-banner.md)]

Dynamics 365 Field Service provides an Outlook Add-in for frontline managers to manage work orders without disrupting their workflow. As a frontline manager, you can create, view, and edit work orders directly from your email without leaving Outlook. You can quickly respond to requests for service or questions about existing requests.

The Field Service (Preview) Outlook Add-in provides copilot capabilities where you can use the copilot to quickly create a work order with the information from the email. Use the copilot to see suggested schedules so you can quickly select a technician and schedule the work order. Or, you can create a work order manually and use the Field Service schedule board for scheduling.

## Install the Field Service (Preview) Outlook Add-in

If you don’t already have Outlook and Field Service licenses, contact your organization’s IT administrator. If your admin installed the add-in for your organization, you can skip this step.

### Prerequisites

- Outlook on the web
- Outlook 2013 or later on Windows (or Mac)

### Install the Outlook Add-in

1. [Install the Outlook Add-in](https://support.microsoft.com/office/get-an-office-add-in-for-outlook-1ee261f9-49bf-4ba6-b3e2-2ba7bcab64c8). In the **Add-Ins for Outlook** dialog box, search for **Dynamics 365 Field Service for Outlook (Preview)** and select it.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Field Service (Preview) add-in card":::

1. Select **Get it now**.

> [!NOTE]
> Switching to a different theme in Outlook Web is not supported in Outlook add-ins.

## Open the Field Service (Preview) Outlook Add-in

1. While in an email, select **More actions (...)**, and then select **Field Service (Preview)**.

   > [!TIP]
   > If you can't find the add-in, it may appear in a different location. See [Use an add-in in Outlook](https://support.microsoft.com/office/get-an-office-add-in-for-outlook-1ee261f9-49bf-4ba6-b3e2-2ba7bcab64c8)

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
> To keep the **Field Service (Preview)** pane open across all emails, select the **Pin** icon.

:::image type="content" source="media/fsp-email.png" alt-text="Field Service (Preview) Outlook icon highlighted on an open email":::

## Create a work order in Outlook using Copilot in Field Service (Preview)

This feature adheres to [responsible AI guidelines](faqs-wo-flw-copilot.md).

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Copilot** tab select **Create a work order from email**.

   :::image type="content" source="media/fsp-copilot-tab.png" alt-text="Field Service (Preview) Outlook pane showing Copilot tab":::

   A message displays that the work order is being generated.

   > [!TIP]
   > If the email does not meet Microsoft Responsible AI guidelines, an error displays. You can create the work order manually.

1. Review the work order to ensure all AI-generated content is accurate and fill in any additional information.

   :::image type="content" source="media/fsp-copilot-review-work-order.png" alt-text="Field Service (Preview) Outlook pane showing an auto-generated work order for review":::

1. At a minimum, ensure the required information is entered for the work order.

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

1. Select **Save**. After the work order is created, the work order number displays at the top of the **Field Service (Preview)** pane. The **System Status** default is **Unscheduled**. You can [schedule the work order](#schedule-a-work-order-using-copilot).

<!--- Change screenshot --->

   :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Field Service (Preview) Outlook pane highlighting the pop-out icon to go to Field Service":::

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the pop-out icon.

See [View work orders](#view-work-orders-in-outlook) and [Edit a work order](#edit-a-work-order-in-outlook) for any work orders created by the Copilot or manually.

## Create a work order manually in Outlook

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Work orders** tab, select the **Create work order (+)** button.

   :::image type="content" source="media/fsp-outlook-create-button.png" alt-text="Field Service (Preview) Outlook pane Work Orders tab highlighting the Create button":::

1. At a minimum, enter the required information for the work order.

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

   :::image type="content" source="media/fsp-outlook-fsp-pane.png" alt-text="Field Service (Preview) Outlook Create work order pane":::

   > [!TIP]
   > Copy relevant information from the email into the **Description** field. For general information about work orders, see [Work order architecture](field-service-architecture.md).

1. Select **Save**. After the work order is created, the work order number displays at the top of the **Field Service (Preview)** pane. The **System Status** default is **Unscheduled**. You can [schedule the work order](#schedule-a-work-order-using-copilot).

<!--- Change screenshot --->

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the pop-out icon.

   :::image type="content" source="media/fsp-pop-out-icon.png" alt-text="Field Service (Preview) Outlook Work Orders tab highlighting the pop-out icon":::

See [View work orders](#view-work-orders-in-outlook) and [Edit a work order](#edit-a-work-order-in-outlook) for any work orders created by the Copilot or manually.

## Schedule a work order using Copilot

This feature adheres to responsible AI guidelines.

<!--- Update FAQ or create a new one --->

Scheduling is based on resource availability, skills, customer promised time windows, customer location proximity, and business unit.

1. After you create a work order or open an unscheduled work order, select the **Scheduling** tab. The system searches for available technicians based on the work order requirements and then displays suggestions. To view more suggestions, select **Show more** at the bottom of the list.

1. Review the suggested technicians and their availability. You can search for a technician by name, filter by dates, or sort the technicians by start time or travel time.

   :::image type="content" source="media/fsp-outlook-scheduling.png" alt-text="Field Service (Preview) Outlook Scheduling":::

   > [!TIP]
   > If the system doesn't find suggestions or you don't find the right technician, use the [schedule board in Field Service](preview-schedule-board.md) instead.

1. Select the technician. The technician is booked and the status is changed to **Scheduled**.

1. Select the back arrow to return to the **Copilot** tab or the work order list.

## View work orders in Outlook

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Work orders** tab, a list of up to 50 work orders display. The most recent work order displays first.

   > [!TIP]
   > To view more work orders, select **Show more** at the bottom of the list.

<!--- Change screenshot --->

   :::image type="content" source="media/fsp-work-order-list.png" alt-text="Field Service (Preview) Outlook work order list":::

1. To find a particular work order, enter the work order ID in the **Find by ID** box and select **Search**.

   > [!TIP]
   > The **Find by ID** box uses a strict match between what is typed in the box and the work order number. For example, “10” won’t find work order ID “00010”.

1. To filter the work orders by status or priority, select **Filter**, make your choice, and then select **Apply**. To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select a work order to view or edit the details.

## Edit a work order in Outlook

1. While in an email, [open the Field Service (Preview) add-in](#open-the-field-service-preview-outlook-add-in).

1. On the **Work orders** tab, a list of up to 50 work orders display.

1. Select the work order you want to edit. Use **Find by ID** or **Filter** to find the work order if necessary.

   :::image type="content" source="media/fsp-work-order-details.png" alt-text="Field Service (Preview) Outlook work order details":::

1. Make the necessary changes and select **Save**. Within the details of the work order, you can also:

   - Open a map to locate the service address
   - [Open the schedule board in Field Service](configure-schedule-board.md#overview-of-the-schedule-board)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
