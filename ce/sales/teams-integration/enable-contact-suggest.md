---
title: Configure the ability to use suggested contacts when starting a Teams chat
description: Learn how to configure the ability to use suggested contacts.
ms.date: 06/28/2024
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
ms.reviewer: shjais 
---

# Configure the ability to use suggested contacts

Configure the ability to use suggested contacts when starting a Teams chat.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | System Administrator<br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|

## Turn on the suggested contacts capability for a record type

As an administrator, you can enable the suggested contacts to be displayed when a seller starts a new connected chat. It helps the sellers to quickly find the right coworkers to collaborate with.

> [!NOTE]
> For the case record type, there are two types of contact suggestions: AI and rules-based. Other record types enabled for connected chats may only have rules-based suggestions.

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.

3. Under **Connect chats to Dynamics 365 records**, select the record type (for example, Lead).

4. In the settings panel, turn on the **Rules-based suggested contacts** toggle.

    :::image type="content" source="media/lead-configure-suggest-contact.png" alt-text="Settings page to turn on or off the suggested contacts feature.":::

5. In the **Update rules for suggesting contacts** section, reorder or disable the rules for suggesting contacts. Users will see the suggestions in the order you choose.

    - To reorder the rules, hover over a rule, and then select the up or down arrow to move the rules up or down respectively.
    - To disable a rule, hover over a rule, and then select :::image type="icon" source="media/suggested-contacts-rule-disable.png" border="false":::. When the rule is disabled, :::image type="icon" source="media/suggested-contacts-rule-disabled.png" border="false"::: is displayed when you hover over the disabled rule.
    - To delete a rule, hover over the rule, and then select :::image type="icon" source="../media/delete-icon.png" border="false":::. When the rule is deleted, it's removed from the list.
    - To add a new rule, select **Add rule**. 

    :::image type="content" source="media/suggested-contacts-rules.png" alt-text="Reorder or disable the rules for suggested contacts.":::

6. Select **Save**.

### Add a new rule

1. In the settings panel, in the **Update rules for suggesting contacts** section, select **Add rule**.
1. In the **Add rule** pane, enter a **Rule name** for the rule. The name you enter displays on the contact, and also appears in the rule list.
1. Select from the following **Rule type** options:
   - **Relational**: Suggest a user who has a relationship with the linked record type or one of its related records. In the **Rule settings** section, the dropdown allows you to select a user directly on the record type for which you're creating a rule or an entity that's related to it. You can select up to 10 related entities, each one being associated with the previous selection. Once you've selected a user, either on the record type or related entity/entities, you can save the rule.
   - **Custom**: You can use your own custom logic with a record type, and then apply it.

1. Select **Save**.

## Related information

[Enable or disable Microsoft Teams chat in Sales Hub](enable-teams-chat.md)   
[Use Microsoft Teams chat in Sales Hub](using-teams-chat-in-dynamics.md)
