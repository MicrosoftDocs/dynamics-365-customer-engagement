---
title: FAQ about automatic record creation
description: Learn answers to frequently asked questions about automatic record creation.
ms.date: 02/10/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# FAQ about automatic record creation

## FAQ about automatic record creation and activity monitor

The following section provides answers to questions about automatic record creation and activity monitor.

### What are the scenarios in which the rule skips creating records automatically?

The automatic record creation rule doesn't create records in the following scenarios:

### Reason 1

Email is from an unknown sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **Yes** for **Allow emails from unknown senders**, and choose an option in **Manage unknown senders by** according to your business needs. More information: [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 2

A resolved case is already connected with this record.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **Yes** for **Wait for a specific amount of time after the connected case has been resolved**, and specify the time in the **Select the amount of time** option. More information: [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 3

No valid entitlement for this email sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **No** for **Require a valid entitlement on the connect case**.

### Reason 4

No applicable reason can be specified.

**Resolution**: If the reason is empty and the state says **Ready for workflow/Power automate**, and the case doesn't get created, then check system jobs if it's a legacy rule, or check flow runs if it's a modern rule.

## FAQ about modern automatic record creation

The following section provides answers to questions about migrated rule or flows in modern automatic record creation.

### Why do I see two flows in Power Automate when I have an active modern or migrated ARC rule with only one rule item?
  
If you have an active rule with rule items, you'll see two flows, one with the name **ARC | rule name**, and another with the name **ARC: rule item name**. These flows are automatically turned on whenever you activate a rule. The ARC rule works only when these two flows are turned on.

For any inactive ARC rule, you'll see only one flow with the name **ARC: rule item name**. You won't see **ARC | rule name**, as this flow is created during rule activation. Even if you do see duplicate flows with the name **ARC | rule name** for the same rule, it won't cause any rule item issues. Even though they have the same name, only one of these flows is associated with the ARC rule, and only that flow will be invoked during run time.

### What does the flow ARC | rule name do, and can I customize it?

The purpose of this flow is to evaluate all the rule item conditions to select the first match and invoke its associated flow. This flow shouldn't be customized.  

### I see that the ARC flow trigger is on the email update filtering on importsequencenumber attribute. Is it the reason that cases aren't being created for some emails?

No, all ARC flow triggers need to be on the update action with the **importsequencenumber** filtering attribute. This configuration isn't the reason if sometimes cases aren't being created for some emails.  

### Can I change the flow trigger to email create or remove the filtering attribute?

No, changing the flow trigger to the create action or removing the filtering attribute will lead the ARC flow to run during unexpected scenarios. This scenario will lead to infinite flow run issues.

### When I export an ARC rule from an organization, what other required components do I need to include in the same solution?

You must include the rule item’s associated flows with the ARC rules in the exported solution. You can include them by selecting the rule and then selecting **Add required components**. The rule item’s associated flows need to be named as **ARC: rule item name**. Don't include flows with the name **ARC | rule name** in the solutions.

### I imported a modern ARC rule with its associated flows. After I activate the imported rule, I see duplicated flows with name ARC | rule name in the Power Automate portal. Will this affect run-time issues like creating duplicate cases?  

No, runtime or create duplicate cases won't be affected. The flow with name **ARC | rule name** is created during rule activation. The reason you'll see duplicates is because those duplicated flows were included in a managed solution and imported to the organization. See the previous question for what must be included while exporting or importing an ARC rule through solution.

### Can I turn off or on ARC flows directly in the Power Automate portal?  

No, don't turn off or on any ARC flows directly in the Power Automate portal. Only enable or disable ARC flows from Microsoft Dataverse.
