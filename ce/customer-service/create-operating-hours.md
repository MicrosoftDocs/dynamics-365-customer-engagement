---
title: "Create and manage operating hours | MicrosoftDocs"
description: "Perform the steps mentioned in the article to create, manage, and define operating hours in Omnichannel for Customer Service."
ms.date: 10/03/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Create and manage operating hours

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

Operating hours define the hours when your organization's customer support team is active and available to serve customers. By setting up operating hours, you help your customers and your organization work together to resolve issues.

The operating hour schedules cater to the following scenarios:

- Display the non-availability of customer support on public holidays that are otherwise operating hours.
- Accommodate change of calendar timings for daylight saving time twice an year for timezones that have implemented the daylight saving time.
- Set up separate schedules for agents, bots, and queues to cater to different business scenarios and product lines seamlessly for any channel.
- Define schedules to transition customer queues from bots to agents.
- Customize the display and other settings of the chat widget during non-business hours.

After you define the business hours for your organization and set up [automated messages](configure-automated-message.md) to be displayed to customers, when customers interact through a channel during non-business hours, they will see the messages that you've set. For example, customers can be shown an offline message on the chat widget as "Our agents are not available. Our business hours are between 8:00 am and 5:00 pm." Similarly, for social channels, you can configure the operating hours at the queue level. When customers contact your agents through any of the social channels outside the business hours, they'll receive responses that you've set.

In Customer Service admin center and Omnichannel admin center, after you've created an operating hour record, you can do the following steps, depending on your requirement:

- **Queues:** Configure the operating hour on the main page of the queue.
- **Chat widget:** Add the operating hour record on the **Chat widget** tab.
- **SMS channels:** Add the operating hour record on the **Behaviors** tab of the channel instance that can be accessed through the corresponding workstream.

In Omnichannel Administration, you can add the operating hour record on the **Design** tab of the appropriate chat widget to control the display of the widget. For SMS channels and queues, the operating hour record will be available for selection on the **General** and **Summary** tabs respectively.

## How work items are routed when operating hours are set

When operating hours are in effect, work items during non-business hours are handled based on the channel they come through.

For live chat and voice, the conversations and calls are routed to the queue and then closed.

For asynchronous channels, such as SMS and WhatsApp, if pick-based option is configured, the conversations remain in the open state till agents sign in and take up the assignments. If push-based option is configured, the assignment method that's configured will be used to route the conversations.

## Create a record to define operating hours

You can define operating hours in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Calendars** in **Operations**. The **Calendar** page appears.
    1. In the **Operating Hours** section, select **Manage**.

       The **Active Operating Hours** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Omnichannel admin center](#tab/Omnichanneladmincenter)

    1. In the site map, select **User attributes** in **Advanced settings**. The **User attributes** page appears.
    1. In the **Operating Hours** section, select **Manage**.

       The **Active Operating Hours** view is displayed. You can switch between various system views using the drop-down list.

    > [!Note]
    > If you are using Omnichannel Administration, under **Settings**, select **Operating Hours**.

1. Select **New**. The **New Operating Hour** page is displayed.

1. On the **General** tab, provide the following information:

    - **Name**: Enter a name for the operating hour record.
    - **Owner:** Accept the default value or search to specify a different owner.
    - **Description:** Enter an optional description of the operating hour record.

1. Select **Save**. The **Working Hours** tab is displayed. By default, the calendar displays the work hours defined as 8:00 am to 5:00 pm.

1. On the **Working Hours** tab, select **New** > **Working hours** in the calendar.

1. In the **Working hours** panel, set the following options to define the working hours schedule.
   - **All Day:** Specify Yes, if the chat widget should be available 24/7.
   - **Calendar:** Specify the period for the schedule. The option to choose dates is available only when **All Day** is Yes.
   - **Time:** Select the start and end time for the schedule.
   - **Repeat:** Select a recurrence option.
   - **choose an end date:** Optionally, specify an end date.
   -  **Time zone:** Select an applicable time zone. The daylight saving timings are taken into account, if applicable for the selected time zone.

    > ![Create an operating hour schedule.](media/oc-create-operating-hour.png "Create a operating hour schedule")

1. Select **Save**. You are returned to the **Working Hours** tab.

## Define a holiday on the calendar

1. To set unavailability of customer support for a public holiday, on the calendar view, select **New** > **Holiday**.

1. Select the date or date range, and specify a reason.

1. Save the settings.

1. Select **Save** on the navigation bar.

## Edit or delete the work hour settings

You can edit or delete the operating hours schedule in an existing record.

1. Go to the record in which you want to modify the schedule.

1. Select an event on the calendar.

1. On the menu that appears, select **Edit**, and select one of the options:
   - **This event**
   - **This and all following events**
   - **All events in the series**
1. If you want to delete an event, select **Delete**.

    > ![Edit an event.](media/oc-operating-hour-modify.png "Create a working hour schedule")

## Add operating hours to a chat widget

Do the following to specify operating hours for a chat widget:

1. Open the Chat channel settings widget, and select the **chat widget** tab.

1. Toggle the **Show widget during operation hours** to **On**.

1. In the **Operating hours name** field, browse, and select the operating hour record. The chat widget is displayed during the hours specified in the selected operating hour record.

1. Select **Show widget outside of operation hours** to display the widget outside work hours.

1. Save the changes.

## Add operating hours to a queue

You can add operating hours to a queue that can later be configured for a social channel. If operation hours aren't configured, the queues will be available round the clock.

Do the following to specify operating hours for a queue:

1. Navigate to the Customer Service admin center or Customer Service Hub app, and perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Queues** in **Customer Support**. The **Queues** page appears.
    1. In the **Advanced Queues** section, select **Manage**.

       The **Queues** view is displayed.

   ### [Omnichannel admin center](#tab/Omnichanneladmincenter)

    - In the site map, select **Queues** in **General settings**. The **Queues** page appears.

1. Open the queue for which you want to specify the operating hours.

1. On the **Operation hours** tab, select **Set operation hours**.

1. In the **Set operation hours** page, search and select the operating hour record that you want to specify.

1. Save the changes.

## Limitation

You can't migrate the Calendar entity by using the export and import options and need to set up the work hours manually.

### See also

[Manage overflow of queues](manage-overflow.md)  
[Automated messages](configure-automated-message.md)  
[Add a chat widget](add-chat-widget.md)  
[Configure a pre-chat survey](configure-pre-chat-survey.md)  
[Create quick replies](create-quick-replies.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
