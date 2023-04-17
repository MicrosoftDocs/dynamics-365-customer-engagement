---
title: Create a Microsoft Teams meeting in Dynamics 365
description: Learn how to create a Teams meeting in Dynamics 365.
ms.date: 08/09/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
---

# Create a Microsoft Teams meeting

Create a Teams meeting from Dynamics 365 or Microsoft Outlook

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, Dynamics 365 Team Members, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Team Members](/dynamics365/get-started/team-members-license)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | <ul><li>Any primary sales role, such as salesperson, or sales manager</li><li>Any role that has access to a Dynamics 365 record</li></ul> <br>  More information: [Primary sales roles](../security-roles-for-sales.md#primary-sales-roles)|

## Overview

You can create a Teams meeting from Dynamics 365 or Microsoft Outlook. Link a Dynamics 365 record to the meeting to view record details before the meeting, in a side panel during the meeting, and after the meeting.

To link a Dynamics 365 record to a meeting, select a **Regarding** record while creating the meeting. When a record is linked to the meeting, the **Dynamics 365** app is added automatically to the meeting, and you can see the details of the linked record.

If a record isn't linked to the meeting, you can still add the **Dynamics 365** app to the meeting. Although you can add the app during the meeting, we recommend that you add it before the meeting starts for a better experience.

## Create Teams meetings in Dynamics 365

In Dynamics 365, you can create a Teams meeting from the **Timeline** of a record or from the **Activities** page.

> [!NOTE]
> The personal standards and formats selected by a user in Dynamics 365 affect the formatting of the Teams meeting details saved within the description of the meeting. To view the selected format, select **Settings** (:::image type="icon" source="../media/settings-icon.png" border="false":::) > **Personalization Settings**, and then select the **Formats** tab.

### Create a Teams meeting from the Timeline

1. On the **Timeline**, select **Create a timeline record** > **Meeting**.
1. In the **Quick Create: Meeting** panel, enter the meeting information, such as attendees, location, time, and description.
1. Turn on **Teams meeting**.

    :::image type="content" source="./media/tmi-create-teams-meeting.png" alt-text="Create a Teams meeting from the Timeline.":::

1. Select **Save and Close**.

> [!NOTE]
> When you create a meeting from a record's Timeline, the record name automatically fills the **Regarding** field, creating the link between the record and the meeting.

### Create a Teams meeting from the Activities page

1. Sign in to your customer engagement app.
1. On the sitemap, select **Activities**.
1. On the command bar at the top, select **Meeting**.
1. On the **New Meeting** page, enter the meeting information, such as attendees, location, time, and description.
1. Turn on **Teams meeting**.
1. In the **Regarding** field, search for and select a record that the meeting is related to.
1. Select **Save & Close**.

## Create Teams meetings in Microsoft Outlook

If you create a Teams meeting in Outlook, it isn't linked to a Dynamics 365 record automatically. You must install the Dynamics 365 App for Outlook to link the meeting to a Dynamics 365 record. After you install the app, open it and search for the record in the **Set Regarding** field.

For more information on creating a Teams meeting in Outlook, see [Schedule a Teams meeting from Outlook](https://support.microsoft.com/office/schedule-a-teams-meeting-from-outlook-883cc15c-580f-441a-92ea-0992c00a9b0f).

For more information on using the Dynamics 365 App for Outlook, see [Basic navigation in App for Outlook](/dynamics365/outlook-app/user/basic-navigation).

### See also

[Enable Microsoft Teams meeting integration](enable-teams-meeting-integration.md)    
[Customize record details in the side panel](customize-record-side-panel.md)   
[Integrate Dynamics 365 and Microsoft Teams meetings](teams-meeting-integration.md)    
[Add the Dynamics 365 app to a Teams meeting](add-d365-app.md)   
[Work with the Dynamics 365 app](work-with-d365-app.md)     
[Join a Teams meeting](join-teams-meeting.md)   
[Work with notes during a meeting](work-with-notes.md)   
[Work with tasks during a meeting](work-with-tasks.md)   
[Work with activities during a meeting](work-with-activities.md)   
   
