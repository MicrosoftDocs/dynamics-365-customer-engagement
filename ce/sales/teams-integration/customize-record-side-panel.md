---
title: Customize the side panel to view record details during a meeting
description: Learn how to customize the side panel to view record details during a meeting.
ms.date: 08/09/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
---

# Customize record details in the side panel (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../../includes/preview-disclaimer.md)]

Sellers can use the side panel to quickly view and update details of a record during a Teams meeting. It displays notes, tasks, and activities associated with the record.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | System Administrator<br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|

## Customize the record side panel

As an administrator, you can customize record details that should be displayed within the side panel to meet the needs of your users.

> [!NOTE]
> - To customize record details in the side panel, edit a table's **In Context Form** form. 
> - The side panel supports the Contact, Opportunity, Lead, Account, and Case tables.

The following customizations are supported:

- Add or remove fields in the **(table) info** section.
- Change a field label.
- Set a field requirement (for example, read-only).

The following customizations are not supported:

- Enable or disable tabs.
- Rearrange tabs.
- Add custom tabs or sections.
- Add sections other than (table) info, Contacts, Notes, Tasks, Collaboration, and Recent Opportunities.
- Add a web resource.
- Add a subgrid.
- Change the format or layout of headers, tabs, sections, and fields.
- Change certain properties of headers, tabs, sections, and fields.

**To customize record details in the side panel:**

1. Sign in to Power Apps.

2. Select the environment, and then select **Data** > **Tables**.

3. In the upper-right corner, select the views list, and then select **All**.

    :::image type="content" source="./media/tmi-select-all-tables.png" alt-text="Select all tables.":::

4. Search for and select the table.

5. Select the **Forms** tab, and then select the **In Context Form** form.

6. Edit the form to choose the fields you want to show in the side panel.

    By default, all the fields in the form are editable. To make a field read-only, select it and turn on the **Read-only** property.

### See also

[Enable Microsoft Teams meeting integration](enable-teams-meeting-integration.md)    
[Integrate Dynamics 365 and Microsoft Teams meetings](teams-meeting-integration.md)
