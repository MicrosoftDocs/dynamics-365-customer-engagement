---
title: Work with Field Service in Outlook (frontline managers) 
description:  Learn how service managers and dispatchers can use the Dynamics 365 Field Service for Outlook add-in to create, view, update, and schedule work orders with AI assistance in Outlook.
ms.date: 12/08/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Work with Field Service in Outlook (frontline managers)

Dynamics 365 Field Service provides an Outlook add-in for frontline managers to create, view, and edit work orders directly from their email. Without leaving Outlook, you can quickly respond to requests for service or questions about existing requests. The add-in provides copilot AI assistance to quickly create a work order with the information from the email. Then you can see suggested schedules so you can quickly select and book a technician. You can also create a work order manually and use the [Field Service schedule board](work-with-schedule-board.md) for scheduling.

## Install the Field Service for Outlook add-in

Your admin might have installed the add-in for your organization. If you see the Field Service icon in your email actions or **Field Service** in an email's **More actions** (**&hellip;**) menu, you can skip this step.

### Prerequisites

- You have either Outlook on the web or Outlook 2013 or later on Windows or macOS.
- You have a license for both Outlook and Dynamics 365 Field Service. If you don't have one, contact your organization's IT administrator.
- Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)
  > [!NOTE]
  > The supported language is based on your Outlook language. If you access Outlook from the web, the language is based on the web browser. If you access Outlook from Outlook Desktop, the language is based on Outlook Desktop's language.

### Install the Outlook Add-in

1. Go to [Microsoft AppSource](https://aka.ms/fieldserviceaddin) and select **Dynamics 365 Field Service for Outlook**.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Field Service add-in card":::

1. Select **Get it now** and confirm your information.

> [!NOTE]
> Changing themes (colors, fonts, or effects) in Outlook Web is not supported in Outlook add-ins.

## Get started with the add-in

1. Open an email or view it in the Reading Pane, select **More actions (...)**, and then select **Field Service**.

   > [!TIP]
   > If you can't find the add-in, it may appear in a different location. See [Use an add-in in Outlook](https://support.microsoft.com/office/get-an-office-add-in-for-outlook-1ee261f9-49bf-4ba6-b3e2-2ba7bcab64c8)

   :::image type="content" source="media/fsp-outlook-sign-in.png" alt-text="Screenshot of the Outlook message More actions menu, with the menu button and Field Service highlighted.":::

1. Select **Sign in to get started**.

1. Sign in to your Dynamics 365 account and select your environment. If you don’t know your environment, see [Find your environment and organization ID and name](/power-platform/admin/determine-org-id-name).

1. Select **Get started**.

To make the Field Service add-in easier to get to in Outlook on the web, add it to your custom message actions:

1. Select **View** > **View settings** > **Customize actions**.

1. Under **Message surface**, select **Field Service**.

1. Select **Save**.

   :::image type="content" source="media/fsp-email.png" alt-text="Screenshot of an email in Outlook on the web, with the Field Service icon highlighted.":::

## Open the Field Service add-in

Open an email or view it in the Reading Pane, and then select the Field Service icon in the message actions. If you didn't add Field Service to your message actions, select **More actions** (**&hellip;**), and then select **Field Service**.

> [!TIP]
> By default, the **Field Service** pane closes when you switch to a different email. To keep the pane open across all emails, select the **Pin** icon.

## Create a work order with Copilot

Copilot in Dynamics 365 Field Service adheres to [responsible AI guidelines](faqs-wo-flw-copilot.md). If you don't see the Copilot icon, your admin might have disabled this feature.

1. While you're viewing an email, [open the Field Service add-in](#open-the-field-service-add-in). If the email was previously used to create a work order using Copilot, a message displays with a link to the work order.

1. On the Home tab, select **Create a work order from email**.

   :::image type="content" source="media/fsp-copilot-tab.png" alt-text="Field Service Outlook pane showing Home tab":::

   If the email doesn't meet Microsoft Responsible AI guidelines, Copilot display an error. [Create the work order manually](#create-a-work-order-manually-in-outlook).

1. Review the work order to ensure all AI-generated content is accurate.

   :::image type="content" source="media/fsp-copilot-review-work-order.png" alt-text="Field Service Outlook pane showing an auto-generated work order for review":::

   We encourage you to use the like/dislike buttons to leave feedback. Your feedback helps us continually improve Copilot's responses.

1. Fill in any required information that wasn't included in the email.

   If a value doesn't appear in the list, select **+ New item type** to create it in the Field Service app. Save and close the Field Service app. Type the new value or select **Refresh** to make it appear in the list.

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

1. Select **Save**.

   The work order number displays at the top of the **Field Service** pane and the email is saved in the Field Service timeline.

1. [Schedule the work order](#schedule-or-reschedule-a-work-order) or select the back arrow to return to the **Home** tab.

   :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Field Service Outlook pane highlighting the pop-out icon to go to Field Service":::

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the pop-out icon.

## Create a work order manually in Outlook

1. While you're viewing an email, [open the Field Service add-in](#open-the-field-service-add-in), and then select the **Work orders** tab/

1. Select the **Create work order (+)** button.

   :::image type="content" source="media/fsp-outlook-create-button.png" alt-text="Field Service Outlook pane Work Orders tab highlighting the Create button":::

1. Fill in the required information from the email.

   If a value doesn't appear in the list, select **+ New item type** to create it in the Field Service app. Save and close the Field Service app. Type the new value or select **Refresh** to make it appear in the list.

   - [Service Account](accounts.md)
   - [Work Order Type](create-work-order-types.md)
   - [Price List](create-price-list.md)

   :::image type="content" source="media/fsp-outlook-fsp-pane.png" alt-text="Field Service Outlook Create work order pane":::

   > [!TIP]
   > Copy relevant information from the email into the **Summary** field. For general information about work orders, see [Work order architecture](field-service-architecture.md).

1. Select **Save**.

   The work order number displays at the top of the **Field Service** pane and the email is saved in the Field Service timeline.

1. [Schedule the work order](#schedule-or-reschedule-a-work-order) or select the back arrow to return to the **Home** tab.

   :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Field Service Outlook pane highlighting the pop-out icon to go to Field Service":::

   > [!TIP]
   > If you want to open the work order in the Dynamics 365 Field Service app, select the pop-out icon.

## Schedule or reschedule a work order

The Field Service add-in helps you schedule work orders in Outlook. Scheduling suggestions are based on technicians' availability and skills, proximity to the customer's location, promised time windows, and the business unit.

1. Open the work order you need to schedule or reschedule.

1. To schedule, select **Schedule**. To reschedule, select **View schedule**, and then **Reschedule**.

   The system searches for available technicians based on the work order requirements and then displays suggestions. To view more suggestions, select **Show more** at the bottom of the list.

1. Review the list of suggestions. You can search for a technician by name, filter by dates, or sort the list by start time or travel time. 

   If the **Estimated Duration** hasn't been set up in the resource requirements, 30 minutes is used as a default.

   :::image type="content" source="media/fsp-outlook-scheduling.png" alt-text="Screenshot of the Field Service pane in Outlook, Scheduling suggestions, with the search, filter, and sorting options highlighted.":::

   If the system doesn't find suggestions or you don't find the right technician, use the [schedule board in Field Service](work-with-schedule-board.md) instead.

1. To assign the work order to a technician, select the **Book resource** icon.

   The technician is booked and the status is changed to **Scheduled**. A confirmation displays at the top of the **Field Service** pane.

1. Select the back arrow to return to the **Home** tab or the work order list.

## Move a booking

If you don't need to change the assigned technician, just the date or time of the service appointment, you can move the booking. If needed, you can also assign the work order to a different resource.

1. Open a scheduled work order and select **View schedule**.

1. Select **Move booking**.

   :::image type="content" source="media/fsp-outlook-move-booking.png" alt-text="Screenshot of the Field Service pane in Outlook, with the Move booking item highlighted":::

1. Select the new date and time and, if needed, a different resource.

1. Select **Update**.

   The technician is booked. A confirmation displays at the top of the **Field Service** pane.

## View a work order

1. While you're viewing an email, [open the Field Service add-in](#open-the-field-service-add-in), and then select the **Work orders** tab.

   The list shows up to 50 work orders, with the most recent one listed first.

1. To view more work orders in the Field Service app, select **See more** at the bottom of the list.

   :::image type="content" source="media/fsp-work-order-list.png" alt-text="Screenshot of the Field Service pane in Outlook, with four work orders listed":::

1. Find the work order you want to view:

   - Type the work order ID in the **Find by ID** box and select **Search**.

   - To filter the list by status or priority, select **Filter**, make your choice, and then select **Apply**.

   - To remove a filter, select **Filter**, clear each selection, and then select **Apply**.

1. Select the work order to view or edit it.

   :::image type="content" source="media/fsp-work-order-details.png" alt-text="Field Service Outlook work order details":::

While you're viewing a work order, you can also:

- Open a map to locate the service address. Select the **Open in Bing Maps** icon.

   :::image type="content" source="media/fsp-map-icon.png" alt-text="Screenshot of a work order in Outlook, with the Open in Bing Maps icon highlighted.":::

- [Open the schedule board in Field Service](work-with-schedule-board.md). Select the **Schedule board** link.

- Open the work order in Dynamics 365 Field Service. Select the pop-out icon.

  :::image type="content" source="media/fsp-copilot-pop-out-icon.png" alt-text="Field Service Outlook pane highlighting the pop-out icon to go to Field Service":::

## Edit a work order in Outlook

1. [View the work order](#view-a-work-order) you want to edit.

1. Make the necessary changes and select **Save**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
