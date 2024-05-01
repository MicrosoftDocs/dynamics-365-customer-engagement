---
title: Manage work orders with Field Service in Outlook (frontline managers) 
description: Learn how service managers and dispatchers can use the Dynamics 365 Field Service for Outlook add-in to create, view, update, and schedule work orders with AI assistance in Outlook.
ms.date: 05/01/2024
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Manage work orders with Field Service in Outlook (frontline managers)

Dynamics 365 Field Service provides an Outlook add-in for frontline managers to create, view, and edit work orders directly from their email. Without leaving Outlook, you can respond to requests for service or questions about existing requests. The Outlook add-in supports [shared mailboxes](https://support.microsoft.com/en-us/office/open-and-use-a-shared-mailbox-in-outlook-d94a8e9e-21f1-4240-808b-de9c9c088afd). The Outlook add-in uses the Microsoft account credentials of the individual that was signed in for the shared mailbox.

With Copilot, you can quickly create a work order with information from the email, respond with proposed schedules, or confirm a schedule.

:::image type="content" source="media/fsp-outlook-copilot-flow.png" alt-text="Screenshot of work order process flow with Copilot in Field Service for Outlook.":::

You can also create a work order manually and use the [Field Service schedule board](work-with-schedule-board.md) for scheduling.

## Prerequisites

- Complete [Get started with Field Service in Outlook](flw-outlook-get-started.md).
- Your administrator enables the [Copilot in Microsoft Outlook and the Generate email response settings](flw-admin.md#give-consent-to-use-copilot-in-field-service-for-outlook).
- You have a paid Field Service environment. Copilot isn't available in trial environments.
- Your environment is [updated](update-field-service.md) to the latest 2023 wave 2 build.

## Create a work order with Copilot

Copilot in Dynamics 365 Field Service adheres to [responsible AI guidelines](faqs-wo-flw-copilot.md). If you don't see the Copilot icon, your admin might have [disabled the Copilot setting](configure-default-settings.md#features-settings).

1. While you're viewing an email, [open the Field Service add-in](flw-outlook-get-started.md#open-the-field-service-add-in).

   If the email was previously used to create a work order using Copilot, a message displays with a link to the work order, unless the email was moved. If the email was moved to another folder, for example from Inbox to Archive, a message or link doesn't display.

1. On the **Home** tab, select **Create a work order from email**.

   :::image type="content" source="media/fsp-copilot-tab.png" alt-text="Screenshot of Field Service Outlook pane showing Home tab":::

   If the email doesn't meet Microsoft Responsible AI guidelines, Copilot displays an error. [Create the work order manually](#create-a-work-order-manually).

1. Review the work order to ensure all AI-generated content is accurate. Fill in any required information that wasn't included in the email. For example:

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

   If a value doesn't appear in the list, select **+ New item type** to create it in the Field Service app. Save and close the Field Service app. Type the new value or select **Refresh** to make it appear in the list.

   :::image type="content" source="media/fsp-copilot-review-work-order.png" alt-text="Screenshot of Field Service Outlook pane showing an auto-generated work order for review":::

   We encourage you to use the like/dislike buttons to leave feedback. Your feedback helps us to continually improve Copilot's responses.

1. Select **Save**.

   The work order number displays at the top of the **Field Service** pane and the email is saved in the Field Service timeline.

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the open web app :::image type="icon" source="media/fsp-open-web-app-icon.png"::: icon.

1. Choose from one of the **Suggested actions** or select the back arrow to return to the **Home** tab.

## Create a work order manually

1. While you're viewing an email, [open the Field Service add-in](flw-outlook-get-started.md#open-the-field-service-add-in), and then select the **Work orders** tab.

1. Select the **Create work order (+)** button.

1. Fill in the required information from the email. For example:

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

   If a value doesn't appear in the list, select **+ New item type** to create it in the Field Service app. Save and close the Field Service app. Type the new value or select **Refresh** to make it appear in the list.

   :::image type="content" source="media/fsp-outlook-fsp-pane.png" alt-text="Screenshot of Field Service Outlook Create work order pane":::

   > [!TIP]
   > Copy relevant information from the email into the **Summary** field, up to 8,000 characters. For general information about work orders, see [Work order architecture](field-service-architecture.md).

1. Select **Save**.

   The work order number displays at the top of the **Field Service** pane and the email is saved in the Field Service timeline.

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the open web app icon :::image type="icon" source="media/fsp-open-web-app-icon.png":::.

## Draft an email response with Copilot

Use Copilot to share proposed schedules for unscheduled work orders or provide schedule confirmations for scheduled work orders.

Copilot in Dynamics 365 Field Service adheres to [responsible AI guidelines](faqs-flm-copilot-email.md). If you don't see the Copilot icon, your admin might have disabled this feature.

1. While you're viewing an email, [open the Field Service add-in](flw-outlook-get-started.md#open-the-field-service-add-in).

1. From an open work order, select **Draft email with scheduling suggestions** or **Draft email to confirm schedule**.

   :::image type="content" source="media/fsp-draft-email-scheduling.png" alt-text="Screenshot of the Field Service pane in Outlook, showing Draft email scheduling suggestion button":::

   Or on the **Home** tab, select **Draft email based on work order**, and then select **Proposed schedules** or **Confirm schedule**. If you don't see these options, select the original email.

   :::image type="content" source="media/fsp-draft-email-based-wo.png" alt-text="Screenshot of the Field Service pane in Outlook, showing Draft email based on work order button":::

1. After reviewing the generated email, select one of the following.

   - **Add to email**: The generated response appears as a reply. Make any changes and select **Send**.
   - Copy to clipboard: Select the **Copy** icon to copy the response and paste it where needed.
   - Make adjustments: Select the **Adjust** icon to change the length or the tone of the email, and then select **Update**.
   - Regenerate: Select the **Regenerate** icon to generate a different email response.

     :::image type="content" source="media/fsp-draft-email.png" alt-text="Screenshot of the Field Service pane in Outlook, showing a draft email with Action buttons highlighted.":::

1. After adding and sending the email, choose from one of the **Suggested actions** or select the back arrow to return to the **Home** tab or the work order list.

## View a work order

1. While you're viewing an email, [open the Field Service add-in](flw-outlook-get-started.md#open-the-field-service-add-in), and then select the **Work orders** tab.

   The list shows up to 50 work orders, with the most recent one listed first.

1. To view more work orders in the Field Service app, select **See more** at the bottom of the list.

   :::image type="content" source="media/fsp-work-order-list.png" alt-text="Screenshot of the Field Service pane in Outlook, with four work orders listed":::

1. Find the work order you want to view:

   - Type the work order ID in the **Find by ID** box and select **Search**.

   - To filter the list by status or priority, select **Filter**, make your choice, and then select **Apply**.

   - To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select the work order to view or edit it.

   :::image type="content" source="media/fsp-work-order-details.png" alt-text="Screenshot of Field Service Outlook work order details":::

While you're viewing a work order, depending on the **System Status**, you can also:

- [Draft an email with Copilot to propose or confirm schedules](#draft-an-email-response-with-copilot).

- [Schedule the work order or view the schedule](#schedule-or-reschedule-a-work-order).

- Open a map to locate the service address. Select the **Open in Bing Maps** :::image type="icon" source="media/fsp-flm-map-icon.png"::: icon.

- Open the work order in Dynamics 365 Field Service. Select the open web app :::image type="icon" source="media/fsp-open-web-app-icon.png"::: icon.

## Schedule or reschedule a work order

The Field Service add-in helps you schedule work orders in Outlook. Scheduling suggestions are based on technicians' availability and skills, proximity to the customer's location, promised time windows, and the business unit.

1. [View the work order](#view-a-work-order) you need to schedule or reschedule.

1. To schedule, select **Schedule**. To reschedule, select **View schedule**, and then **Reschedule**.

   The system searches for available technicians based on the work order requirements and then displays suggestions. To view more suggestions, select **Show more** at the bottom of the list.

1. Review the list of suggestions. You can search for a technician by name, filter by dates, or sort the list by start time or travel time.

   If the **Estimated Duration** isn't set up in the resource requirements, 30 minutes is used as a default.

   :::image type="content" source="media/fsp-outlook-scheduling.png" alt-text="Screenshot of the Field Service pane in Outlook, Scheduling suggestions, with the search, filter, and sorting options highlighted.":::

   <!--- Remove until adding back in.
   If the system doesn't find suggestions or you don't find the right technician, use the [schedule board in Field Service](work-with-schedule-board.md) instead.
   --->
1. To assign the work order to a technician, select the **Book resource** icon.

   The technician is booked and the status is changed to **Scheduled**. A confirmation displays at the top of the **Field Service** pane.

1. Select the back arrow to return to the **Home** tab or the work order list.

## Move a booking

If you don't need to change the assigned technician, just the date or time of the service appointment, you can move the booking. If needed, you can also assign the work order to a different resource.

1. [View the work order](#view-a-work-order) and select **View schedule**.

1. Select **Move booking**.

   :::image type="content" source="media/fsp-outlook-move-booking.png" alt-text="Screenshot of the Field Service pane in Outlook, with the Move booking item highlighted":::

1. Select the new date and time and, if needed, a different resource.

1. Select **Update**.

   The technician is booked. A confirmation displays at the top of the **Field Service** pane.

## Edit a work order

1. [View the work order](#view-a-work-order) you want to edit.

1. Make the necessary changes and select **Save**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
