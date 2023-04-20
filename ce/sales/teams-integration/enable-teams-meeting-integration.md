---
title: Enable Microsoft Teams meeting integration in Sales Hub (preview)
description: Learn how to enable Microsoft Teams meeting integration in Sales Hub apps.
ms.date: 08/09/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
---

# Enable Microsoft Teams meeting integration (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../../includes/preview-disclaimer.md)]

With Microsoft Teams meeting integration, sellers can quickly access and update Dynamics 365 records in Microsoft Teams before, during, and after meetings. As an administrator, enable this feature to empower sellers and accelerate business outcomes with a seamless experience between Dynamics 365 and Microsoft Teams meetings.

> [!NOTE]
> - If you have other customer engagement apps installed, and you turn on Teams meeting integration in one customer engagement app, it's turned on in all customer engagement apps in your organization. For example, if this feature is turned on in Sales Hub, it will also be shown as turned on in Customer Service Hub.
> - Conversation intelligence has been deprecated within the Dynamics 365 app for Teams.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | System Administrator<br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|


## Enable Teams meeting integration

1. In the Sales Hub app, on the lower-left corner of the screen, select **Change area** > **App Settings**.

2. From the site map, select **Teams Meetings (preview)**.

3. Turn on **Show Dynamics 365 data in Teams meetings (preview)**.

    :::image type="content" source="./media/tmi-admin-page.png" alt-text="Enable Teams meeting integration.":::

4. Select **Save**.

You'll also need to turn on the following settings:

- **Sync calendars**: This setting ensures that the meetings that are created in Dynamics 365 are added to the calendars in Microsoft Outlook and Microsoft Teams. For more information, see [Set up server-side synchronization of email, appointments, contacts, and tasks](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).

    > [!IMPORTANT]
    >
    > - If you don't turn on this setting, meetings you create in Dynamics 365 won't be added to the calendars in Outlook and Teams.
    > - With this setting on, any meetings that are created in Dynamics 365 are added to the calendars in Outlook and Teams and vice versa. Sometimes, there might be a delay of up to 15 minutes before a new meeting appears on synced calendars. For more information, see [Appointments, contacts, and tasks sync frequency](/power-platform/admin/server-side-synchronization#appointments-contacts-and-tasks-sync-frequency).
    > - If you've turned on server-side synchronization for a user in multiple organizations, only the latest configured organization will have server-side sync enabled. The other organizations will have server-side sync disabled. This applies on per-user basis. For information on testing a mailbox configuration, see [Test the configuration of mailboxes](/power-platform/admin/connect-exchange-online#test-the-configuration-of-mailboxes).


- **Add and join meetings**: This setting ensures that a seller can create and join Teams meetings directly from Dynamics 365. For more information, see [Manage feature settings](/power-platform/admin/settings-features).

### See also

[Customize record details in the side panel](customize-record-side-panel.md)    
[Integrate Dynamics 365 and Microsoft Teams meetings](teams-meeting-integration.md)
