---
title: "Configure rules-based suggested contacts when starting a Microsoft Teams chat in Dynamics 365 Customer Service | Microsoft Docs"
description: "Learn how to configure the ability to use rules-based suggested contacts."
ms.date: 07/21/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.reviewer: shujoshi
---

# Configure rules-based suggestions for contacts in Microsoft Teams

Agents can collaborate with other contacts directly through Microsoft Teams to quickly resolve customer issues. As an administrator, you can enable rules-based suggested contacts that are displayed when an agent starts a new connected chat. This feature can help agents in your organization to quickly find the right coworkers to collaborate with.

A maximum of 10 rules are supported per record type.

## Turn on the suggested contacts for a record type

> [!NOTE]
> For the case record type, there are two types of contact suggestions: AI and rules-based. Most record types enabled for connected chats only have rules-based suggestions. For more information about configuring AI-suggested contacts in Teams, see [Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)

**To enable collaboration with Microsoft Teams and chat**

1. In Dynamics 365, go to one of the apps and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, in **Agent experience**, select **Collaboration**.
    
    1. In **Embedded chat using Teams**, select **Manage**.
   
   ### [Customer Service Hub](#tab/customerservicehub) 

    1. In the site map, select **Service Management**.
    2. In **Collaboration**, select **Embedded chat using Teams**.

1. On the **Microsoft Teams collaboration and chat** page, set the toggle for **Turn on the linking of Dynamics 365 records to Microsoft Teams channels** to **Yes**.

1. To get suggested contacts for any record type, perform the following steps:
   
   1. In **Connect chat to Dynamics 365 records**, select record type for which you want to enable rules-based suggested contacts. Based on your selection, the relative settings pane appears on the right.

   2. In **Suggest contacts**, turn on the toggle for **Rules-based suggested contacts**.

1. In the **Update rules for suggesting contacts** section, reorder or disable the rules for suggesting contacts. Users see the suggestions in the order you choose.

    - To reorder the rules, hover over a rule, and then select the up or down arrow to move the rules up or down, respectively.
    - To disable a rule, hover over a rule, and then select :::image type="icon" source="media/suggested-contacts-rule-disable.png" border="false":::. When the rule is disabled, a check mark is displayed when you hover over the disabled rule.
     - To delete a rule, hover over the rule, and then select :::image type="icon" source="media/suggested-contacts-rule-delete.png" border="false":::. Deleting a rule removes it entirely so it won't influence suggested contacts in the future.

1. Select **Save**.

### Add a new rule

1. On the settings pane, in the **Update rules for suggesting contacts** section, select **Add new rule**. The **Add rule** pane is displayed for the record type you selected.
1. Type a **Rule name** for the rule. The name you enter displays on the contact, and also appears in the rule list.
1. Select from the following **Rule type** options:
   - **Relational**: Suggest a user who has a relationship with the linked record type or one of its related records. In the rule settings section, the dropdown allows you to select a user directly on the record type for which you're creating a rule or an entity that's related to it. You can select up to 10 related entities, each one being associated with the previous selection. Once you've selected a user, either on the record type or related entity/entities, you can save the rule.
   - **Custom**: You can use your own custom logic with a record type, and then apply it.

1. Select **Save**.

### Use a custom action

> [!IMPORTANT]
> We recommend that you have previous experience working with custom actions before configuring them for rules-based suggestions. More information: [Create or edit custom actions from a workflow](customerengagement/on-premises/customize/configure-actions)

You can call a custom action to handle advanced scenarios. The suggested contacts identifier passes along the ID and entity type as arguments, and expects the custom action to return users. In the rule settings section, type the name of an existing action.

To use the custom rule type, you must have an existing custom action that has the following arguments:

| Name | Type | Required | Direction |
|---------|---------|------------|-------------|
|EntityLogicalName |String |Required |Input|
|Recordid |String |Required |Input |
|CustomActionSuggestedUsers |String |Required | Output |
|CustomActionInputs |String |Optional |Input |

:::image type="content" source="media/rules-based-custom-arguments.png" alt-text="Required arguments for an existing custom action to use the custom rule type.":::

The output, CustomActionSuggestedUsers, is a list of objects that follow this contract:
```
public class ContactSuggestionCustomActionOutput
  {
    public Guid AADUserId { get; set; }
    public Guid systemUserId { get; set; }
    public string description { get; set; }

    public ContactSuggestionCustomActionOutput(Guid AADUserId, Guid systemUserId, string description)
    {
        this.AADUserId = AADUserId;
        this.systemUserId = systemUserId;
        this.description = description;
    }
  }
```
### Language localization

To ensure that the user's language is localized, make sure they have Read privileges for the following entities:
- msdyn_contactsuggestionrule
- msdyn_contactsuggestionruleset

### See also

[Configure Microsoft Teams chat in Customer Service](configure-teams-chat.md)   
[Use Teams chat in Customer Service](use-teams-chat.md)
