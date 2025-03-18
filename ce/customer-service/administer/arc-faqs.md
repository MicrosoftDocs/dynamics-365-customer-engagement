---
title: FAQ about automatic record creation
description: Learn answers to frequently asked questions about automatic record creation.
ms.date: 03/18/2025
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
---

# FAQ about automatic record creation

## FAQ about automatic record creation and activity monitor

The following section provides answers to questions about automatic record creation and activity monitor.

### What are the scenarios in which the rule skips creating records automatically?

The automatic record creation rule doesn't create records in the following scenarios:

### Reason 1

Email is from an unknown sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **Yes** for **Allow emails from unknown senders**, and choose an option in **Manage unknown senders by** according to your business needs. Learn more at [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 2

A resolved case is already connected with this record.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **Yes** for **Wait for a specific amount of time after the connected case has been resolved**, and specify the time in the **Select the amount of time** option. Learn more at [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 3

No valid entitlement for the email sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **No** for **Require a valid entitlement on the connect case**.

### Reason 4

No applicable reason can be specified.

**Resolution**: If the reason is empty and the state says **Ready for workflow/Power automate**, and the case doesn't get created, then check system jobs if it's a legacy rule, or check flow runs if it's a modern rule.

### Reason 5

The message **The rule doesn't have any conditions applicable to the record** appears in the activity monitor.

**Resolution**: Revisit the existing rules to ensure that the conditions defined in the rule apply to the incoming email.

### Reason 6

Microsoft Exchange conversations are used to identify emails that are part of a conversation.

**Resolution**: Microsoft Exchange groups related emails and assigns a conversation ID to them. This assignment helps identify all the email replies sent to a tracked email.

If you use the correlation option to track and group related email conversations, ARC doesn't create a case for the email replies when an active case connected to the tracked emails already exists.

Learn more at [Manage email tracking settings](/power-platform/admin/settings-email-tracking).

### Why do multiple cases get created from a single email?

Multiple cases can get created from a single email because of various reasons. Perform the following steps to check if multiple cases were created for an email.

1. Enable the activity monitor options: **Ready for Power Automate / Workflow** and **Skipped**. Learn more at [Manage activity monitor to review and track rules](automatically-create-update-records.md#manage-activity-monitor-to-review-and-track-rules).
1. Send a new email to reproduce the issue.
   You should see new activity monitor records in the grid for the new test email. Multiple activity monitor records for the email indicate that there are multiple queue items created for the same email that triggered the ARC rule. You can also view which rule was triggered on each activity monitor row. The activity monitor records with the **Ready for Power Automate** state indicate that they reached the flow and are likely to create a case in each of them. If you see the described behavior, perform the next step.
1. Perform the following steps to identify where the duplicate queue items are from:
    1. Rule item flow definition, to verify if the child flow adds the email to queue. Duplicate queue items can be created because of various reasons, such as a flow step calling **AddToQueue** bound action, queue item creation, another custom flow that the ARC flow calls from within, or a post operation plugin of an action performed within ARC flow, such as case creation.
    1. Email background processes, to verify if there are any custom workflows. You can do this action during live debugging, where successful background processes get cleaned up. If you don't see any background processes for an email received, it doesn’t necessarily mean that there are no custom runs.
    1. Multiple queues with active ARC rule set up in the email's recipient or CC list. By default, an email gets added to all the queues, which are listed as recipient and CC.

## FAQ about modern automatic record creation

The following section provides answers to questions about migrated rule or flows in modern automatic record creation.

### How many flows should I see in Power Automate when I have an active modern or migrated ARC rule, with or without a rule item?

Active rule with rule item:
If you activate a rule, you see one active rule with the name **ARC: rule item name**. The Power Automate flows turn on automatically whenever you activate a rule. If you see that your rule is activated, navigate to the Power Automate flow page to confirm that the flow is turned on, as the ARC rule works only when this flow is turned on.
 
Inactive rule with rule item:
For any inactive ARC rule, you also see one flow only with the name **ARC: rule item name**, but the flow is turned off automatically. This flow is the only one associated with the ARC rule and invoked during run time.
 
Active or inactive rule without rule item:
ARC doesn't run if you don't have a rule item. You don't see any flows related to this rule. You can choose to not have any conditions associated with the rule item. For ARC to run, you must deactivate the rule and then create a rule item without any conditions, which creates a flow. 

### Why do I still see flow ARC| rule name, and can I customize it?

If your rule has been active since June 2024, you'll see this flow, but it's no longer used in runtime. If you deactivate and then reactivate this flow, you'll no longer see it. 

### I see that the ARC flow trigger is on the email update filtering on importsequencenumber attribute. Is it the reason that cases aren't being created for some emails?

No, all ARC flow triggers need to be on the update action with the **importsequencenumber** filtering attribute. This configuration isn't the reason if sometimes cases aren't being created for some emails.  

### Can I change the flow trigger to email create or remove the filtering attribute?

No, changing the flow trigger to the create action or removing the filtering attribute leads the ARC flow to run during unexpected scenarios. This scenario leads to infinite flow run issues.

### When I export an ARC rule from an organization, what other required components do I need to include in the same solution?

You must include the rule item’s associated flows with the ARC rules in the exported solution. You can include them by selecting the rule and then selecting **Add required components**. The rule item’s associated flows need to be named as **ARC: rule item name**. Don't include flows with the name **ARC | rule name** in the solutions.

### Can I turn off or on ARC flows directly in the Power Automate portal?  

No, don't turn off or on any ARC flows directly in the Power Automate portal. Only enable or disable ARC flows from Microsoft Dataverse.

## Related information

[Troubleshoot common configuration issues with automatic record creation and update rules](/troubleshoot/dynamics-365/customer-service/email/common-email-error-messages)

[Incoming email isn't converted to a case](/troubleshoot/dynamics-365/customer-service/email/incoming-email-not-converted-case)
