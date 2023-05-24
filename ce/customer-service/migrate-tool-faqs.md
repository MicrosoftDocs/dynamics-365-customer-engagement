---
title: Migration tool FAQ
description: This article is the migration tool FAQ for automatic record creation rules and service-level agreement (SLA) items.
ms.date: 03/29/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Migration tool FAQ

## Migration tool for automatic record creation rules and service-level agreements (SLAs)

### Who can access or run the migration tool?

Administrators and users who have CSR manager roles can run the migration tool.

### Are migrated rules automatically activated post-migration?

No. You must manually activate the migrated rules after the migration is completed.

### Can I still use my legacy rules after the deprecation deadline?

Yes. Active legacy rules will continue to run after the deprecation deadline, until they are deactivated. However, supportability and the editing experience will stop after deprecation.

### Can I activate a rule that has an "incomplete" migration status?

No. A migrated rule can be activated only when the **Mark as complete** toggle is switched to **Yes** (that is, when the rule is considered successfully migrated).

> [!NOTE] 
> Before you switch the **Mark as complete** toggle to **Yes**, review the incomplete rule to fix any issues. Then activate the rule.

### Will the legacy rule be deactivated?

- **For automatic record creation, yes.** When you activate a migrated automatic record creation rule in Unified Interface, the corresponding legacy rule is deactivated.
- **For SLAs, no.** When you activate a migrated SLA rule in Unified Interface, the corresponding legacy rule remains active, because the two rules can coexist.

### What does an "incomplete" migration status mean?

- **In the Summary section:** The overall migration process could not successfully complete the migration of all selected rules.
- **Next to a rule:** Either the rule either failed, or the rule could not be fully migrated (that is, one or more items or conditions failed to be migrated).

### Where can I find a list of partially migrated rules that are tracked in the migration tool?

Rules that are partially migrated, or that are identified as incompletely migrated, aren't considered fully migrated. Therefore, they are tracked under **Pending** in the **Summary** section. Only rules that successfully completed migration are counted under **Migrated**.

### Does the migration tool support custom forms or fields?

- **For automatic record creation, yes.** The migration tool supports custom entities, fields, attributes, and configurations.
- **For SLAs, no.** The migration tool doesn't fully support custom entities, fields, attributes, and configurations. To complete the migration, users must modify any existing customization flows, workflows, plugins, or other custom code on the custom entities, fields, attributes, and configurations.

### Do I need a separate license for Power Automate before I run migration?

No. For more information about licensing guidelines, go to [What are Microsoft Power Apps and Power Automate use rights for Dynamics 365 applications?](/power-platform/admin/powerapps-flow-licensing-faq#what-are-microsoft-power-apps-and-power-automate-use-rights-for-dynamics-365-applications)

### Some of my rules are incomplete or partially migrated. What should I do?

You can either use the issue details to fix the rule in the web client and then rerun the migration, or fix the migrated rule directly in Unified Interface.

### Can I rerun the migration tool for a specific migrated rule?

Yes, you can rerun the migration tool for a specific migrated rule, based on the following criteria:

- **For incomplete rules or rules that failed migration:** Select the same rule when you rerun the migration tool. The tool automatically replaces the existing incomplete or failed rule with the newly migrated rule.
- **For successfully migrated rules:** Delete the migrated rule in Unified Interface before you rerun the migration tool.

### After the migration is completed, what happens to existing SLA records that are associated with legacy SLAs?

- **If the legacy SLA is deactivated after migration:** The timer will continue to run until the terminal state for such SLA records. However, the **Resolve** and **Pause** functionality won't work.
- **If the legacy SLA is still in an Active state:** Existing SLA records that are associated with legacy SLAs will continue to work as expected.
- **If you want to use SLAs created in the Unified Interface apps on existing records:** You will have to manually update the SLA field to Unified Interface SLA or write the plugin to update the records. For example, the plugin logic might be Modern Flow or Workflow.

For information about migrated rules or flows in modern automatic record creation, go to [FAQ about modern automatic record creation](arc-faqs.md#faq-about-modern-automatic-record-creation).

## Known condition conversion issues

This section describes key scenarios where rules or items won't successfully complete migration.

### If my rule items or conditions have related entities inside a nested group clause (and/or), will they be migrated to Unified Interface?

No. We currently support only one level of the related entity hierarchy. Such rule items or conditions can be successfully migrated only if you remove any related entity in the group clause before you migrate. If you don't take any action, the rule will fail during the **Premigration checkup** step. If you choose to continue with the migration, the rule will have an empty condition for the related item.

#### Example: Related entities in a nested group clause

**Premigration web client view**

![Screenshot of the premigration web client view of an item with related entities in a nested group clause.](media/migration-tool-11-a.png "Screenshot of the premigration web client view of an item with related entities in a nested group clause")

Legend:

**a.** The title of the item.

**Post-migration Unified Interface view** 

![Screenshot of the post-migration Unified Interface view of the item with related entities in a nested group clause.](media/migration-tool-11-b.png "Screenshot of the post-migration Unified Interface view of the item with related entities in a nested group clause")

Legend:

**2a.** "\_FailedMigration" is appended to the title of the migrated item.

**2b.** The same standard placeholder, **Created On Equals 2200-01-01**, is added to the condition.

### Why do my rule items or conditions with a DateType field that uses a not-on operator fail during the premigration checkup and actual migration?

The **not-on** operator for the *Date* data type isn't supported in Unified Interface. Therefore, it isn't supported as part of migration. To fix this issue, you can change the legacy items or conditions from **\{not-on selecteddate\}** to **\{selecteddate less than and selecteddate greater than\}** in the web client before you rerun the migration tool for the corresponding rule.

#### Example: DateType field that uses a not-on operator

**Premigration web client view**

![Screenshot of the premigration web client view of an item with a not-on operator for a DateType field.](media/migration-tool-12-a.png "Screenshot of the premigration web client view of an item with a not-on operator for a DateType field")

Legend:

**a.** The title of the item.

**Post-migration Unified Interface view**

![Screenshot of the post migration Unified Interface view of the item with a not-on operator for a DateType field.](media/migration-tool-12-b.png "Screenshot of the post migration Unified Interface view of the item with a not-on operator for a DateType field.")

Legend:

**2a.** "\_FailedMigration" is appended to the title of the migrated item. 

**2b.** The condition **Created On Equals 2200-01-01** is added to the condition.

### Why does the data in my DateTime field change during migration?

No separate time field exists in Unified Interface. Therefore, the **DateTime** field will change from a calendar control to a text field. Input should be in a specific format, as shown in the text field in the following example.

#### Example: DateTime field

**Premigration web client view**

![Screenshot of the premigration web client view where DateTime fields are represented by calendar controls.](media/faq-arc-sla-web-view-13.png "Screenshot of the premigration web client view where DateTime fields are represented by calendar controls")

Legend:

**a.** Premigration **Date and time** field.

**b.** Premigration **Date only** field.

**Post-migration Unified Interface view** 

![Screenshot of the post-migration Unified Interface view where DateTime fields are represented by text fields.](media\faq-arc-sla-uci-view-13.png "Screenshot of the post-migration Unified Interface view where DateTime fields are represented by text fields")

Legend:

**a.** Post-migration **Date and time** field.

**b.** Post-migration **Date only** field.

### Why are some of my operator fields blank in Unified Interface post-migration?

For lookup data types, only the **equal**, **not equal, null**, and **not null** operators are supported in Unified Interface and the migration tool. **Under** and **not-under** operators aren't supported in Unified Interface, and therefore they aren't supported in the migration tool. Any conditions that have **under** or **not-under** operators are translated as *related entities* after migration. They are shown as blank in Unified Interface and can't be edited.

#### Example: Under and not-under operator fields

**Premigration web client view**

![Screenshot of the premigration web client view where a condition uses under operators.](media/faq-arc-sla-web-client-14.png "Screenshot of the premigration web client view where a condition uses under operators")

Legend:

**a.** **Under** operators.

**Post-migration Unified Interface view**

![Screenshot of the post-migration Unified Interface view where a condition has a blank operator field.](media\faq-arc-sla-uci-14.png "Screenshot of the post-migration Unified Interface view where a condition has a blank operator field")

Legend:

**b.** Blank operator field.

> [!NOTE]
> The following limitations are applicable when a condition is defined in Customer Service Hub:
>
> - The Date & Time picker control is no longer available in the conditions. However, you can still edit the date and time in the text field.
> - Only one level of the related entity hierarchy is supported. However, you can select nested, related entities in the application.
> - The related entity inside a group of the and/or clause isn't supported.
> - The **not-on** operator for the *Date* data type isn't supported.
> - For the *Lookups* data type, only the **equal**, **not equal**, **null**, and **not null** operators are supported. The **under** and **not-under** operators aren't supported.

### Can I migrate a rule again after it has been activated?

- **For automatic record creation rules, yes.** You can migrate an activated rule again, but you must first deactivate it and delete it from Unified Interface.
- **For SLAs, no.** After a migrated SLA rule is activated, it's linked to another entity (such as a case) or is in use. By default, an activated rule has been successfully migrated. Before you can migrate an activated rule again, you must delete it. However, there is a limitation for Unified Interface SLA rules. After a rule is associated with a case or entity (that is, after it has been activated once), you can't delete it, even if it's deactivated. Therefore, the rule can't be migrated again if it has previously been activated or applied.

### Can I migrate deprecated standard SLA rules?

No. The migration tool supports only enhanced SLA rules. Standard SLA rules have been deprecated. They are no longer supported in Unified Interface, and therefore they aren't supported in the migration tool. For more information, go to [Standard SLAs in Dynamics 365 Customer Service are deprecated](/power-platform/important-changes-coming#standard-slas-in-dynamics-365-customer-service-are-deprecated). 

## Known issues

### Channel property deprecation

If you've used any channel properties in the customization of legacy rules, the migration tool won't successfully migrate those rules. There is no general workaround that can be applied to fix this gap for all users. The workaround highly depends on how you use the channel properties in the legacy rules.

### Behavior difference when the "Create cases for activities associated with a resolved case" option is selected

- **Legacy behavior:** If the email has a related case that has been resolved since the specified time, the resolved case is reactivated by default. No customization is required.
- **Modern behavior:** If the email has a related case that has been resolved since the specified time, a new case is created by default. Customization is required to reactivate an existing case instead of creating a new case.

### Behavior difference when the "Create case if a valid entitlement exists for the customer" option is selected

- **Legacy behavior:** If the email sender doesn't have a valid entitlement, and the email has a related case, the existing related case is updated.
- **Modern behavior:** If the email sender doesn't have a valid entitlement, no flow is invoked.

### Parity gaps between workflows and Power Automate flows (applicable only to customization of rule item actions)

- "First not null" expressions can't be migrated automatically. However, customization can be manually applied to the flow for the migration.
- The mapping of a lookup record's display name to a string field can't be migrated automatically. However, customization can be manually applied to the flow for the migration.
- Activity party fields that are used as source fields aren't supported in the flow.

## Known flow issues

### Migration doesn't support multiple items or conditions that have the same "applicable when" condition in the same SLA.

In the web client, multiple items can be defined that have the same "applicable when" condition and different success criteria for an SLA. However, the same capability isn't supported in Unified Interface. Therefore, during migration, no subsequent SLA items of this type that have the same "applicable when" condition are created.

The following screenshots show the scenario that isn't supported in Unified Interface. The two "applicable when" conditions that are shown have different success criteria.

![Screenshot of an 'applicable when' condition that has success criteria.](media/applicable-when.png "Screenshot of an 'applicable when' condition that has success criteria")

![Screenshot of the same 'applicable when' condition that has different success criteria.](media/different-success-condition.png "Screenshot of the same 'applicable when' condition that has different success criteria")

### Activity party-type attribute issues during workflow-to-flow conversion

An activity party–type attribute that is assigned to another activity party–type field won't be migrated during the workflow-to-flow conversion, because Power Automate doesn't currently support this scenario. (The most commonly affected fields are the **To**, **From**, **CC**, and **BCC** fields in emails.) Although migration of the rule won't fail, the data value for such activity party–type fields that rely on another activity party–type attribute will be blank after migration. 

#### Example: Activity party-type attributes

**Premigration web client view**

![Screenshot of the premigration web client view where a workflow has two activity party-type attributes, From and To.](media/faq-arc-sla-web-client-17.png "Screenshot of the premigration web client view where a workflow has two activity party-type attributes, From and To")

Legend:

**a.** The **From** field is an activity party–type field that is assigned another activity party–type attribute, **\{Bcc(Email)\}**. It will be blank after migration.

**b.** The **To** field will be migrated.

**Post-migration Unified Interface view**

![Screenshot of the post-migration Unified Interface view where the To field has been migrated.](media\migration-tool-17-b.PNG "Screenshot of the post-migration Unified Interface view where the To field has been migrated")

Legend:

**b.** **To** field.

### "First Not Null" checks in expressions in legacy workflows aren't supported during workflow-to-flow conversion.

In legacy workflows, a lookup field can be mapped with multiple expressions where you check and assign the "First Not Null" expression, as shown in the web client example that follows. Because of a known limitation in the legacy workflow designer, this approach isn't supported as part of workflow-to-flow conversion. Therefore, the workflow converter assigns the first expression without performing the null check. It then removes all the remaining expressions, regardless of whether they have non-null values. In the example that follows, the flow will have only **Regarding(Email)** in the **Customer** field in this step.

#### Example: "First Not Null" expressions

**Premigration view**

![Screenshot of the web client view for a Regarding field.](media/faq-arc-sla-web-client-18.png "Screenshot of the web client view for a Regarding field")

Legend:

**a.** **Unified Interface view:** In Power Automate, the **Customer** field has only **Regarding(Email)**, regardless of whether it's null.

**b.** **Web client view:** In the workflow, the **Customer** field has **\{Regarding(Email); Contact(Create (Case)); Customer(Create (Case))\}**.

> [!IMPORTANT]
> If you're still experiencing issues with the migration tool, contact your administrator or Microsoft Support.

### See also

[FAQ about modern automatic record creation](arc-faqs.md#faq-about-modern-automatic-record-creation)

[Migrate automatic record creation rules and SLAs](migrate-automatic-record-creation-and-sla-agreements.md)

[Dynamics 365 SLA and ARC Migration Playbook](https://www.d365implementationguide.com/books/aiij/) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
