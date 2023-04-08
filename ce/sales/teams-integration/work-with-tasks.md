---
title: Work with tasks in a Teams meeting
description: Learn how to work with tasks in a Teams meeting.
ms.date: 08/09/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
---

# Work with tasks during a meeting (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This article provides information on how to work with tasks in a Teams meeting.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, Dynamics 365 Team Members, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Team Members](/dynamics365/get-started/team-members-license)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | <ul><li>Any primary sales role, such as salesperson, or sales manager</li><li>Any role that has access to a Dynamics 365 record</li></ul> <br>  More information: [Primary sales roles](../security-roles-for-sales.md#primary-sales-roles)|

## Overview

The following prerequisites must be met before you can work with tasks in a linked record:

- The record must be linked to the meeting.
- The Dynamics 365 app must be added to the meeting.

Open tasks are displayed under the **Tasks** section in the side panel. To view all tasks , select **Show more tasks**.

:::image type="content" source="./media/tmi-tasks.png" alt-text="Tasks in the record side panel in a Teams meeting":::

If you add, edit, or delete tasks in the side panel, your changes are synced with the record in Dynamics 365. The tasks are sorted by their due date, prioritizing the tasks that are due soon or overdue.

## Add a task

1. In the **Tasks** section, select :::image type="icon" source="./media/tmi-add-icon.png" border="false":::.

2. Add the task details.

## Complete a task

In the **Tasks** section, select the task to mark it as complete.

## Reopen a task

1. In the **Tasks** section, select **Show more tasks**.
1. In the **Completed tasks** section, select the task to reopen it.

    :::image type="content" source="./media/tmi-tasks-panel.png" alt-text="Completed tasks in the record side panel in a Teams meeting.":::

## Edit a task

1. In the **Tasks** section, hover over the task, and then select :::image type="icon" source="./media/tmi-edit-icon.png" border="false":::.
1. Edit the task details as needed.

## Delete a task

1. In the **Tasks** section, hover over the task, and then select :::image type="icon" source="./media/tmi-delete-icon.png" border="false":::.
1. In the confirmation message, select **Delete**.

### See also

[Enable Microsoft Teams meeting integration](enable-teams-meeting-integration.md)    
[Customize record details in the side panel](customize-record-side-panel.md)   
[Integrate Dynamics 365 and Microsoft Teams meetings](teams-meeting-integration.md)    
[Create a Teams meeting](create-teams-meeting.md)   
[Add the Dynamics 365 app to a Teams meeting](add-d365-app.md)   
[Work with the Dynamics 365 app](work-with-d365-app.md)     
[Join a Teams meeting](join-teams-meeting.md)   
[Work with notes during a meeting](work-with-notes.md)   
[Work with activities during a meeting](work-with-activities.md)   
 
