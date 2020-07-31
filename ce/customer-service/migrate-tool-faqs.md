---
title: "Migration Tool FAQs | Microsoft Docs"
description: "Migration Tool FAQs for: Automatic record creation (ARC) and Service Level Agreement (SLA)"
ms.date: 08/03/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Migration Tool FAQs

## Automatic record creation (ARC) and Service Level Agreement (SLA) Migration Tool FAQs

1. **What roles can access or run the migration tool?** <br />
Currently, only admins have permissions to run the migration tool. 

2. **Will migrated rules be activated post-migration automatically?**<br />
No, the user will need to activate the migrated rules manually once migration is complete.

3.	**Can I activate a rule with an incomplete migration status?**<br />
No, a migrated rule can only be activated when **Mark as complete** is toggled to **Yes** (that's when the rule is considered successfully migrated). 

>[!Note] 
> Review the incomplete rule to resolve any issues before you toggle the **Mark as complete** to **Yes**, then activate the rule.

4.	**Will the legacy rule will be de-activated?**
<ol>- <b>For ARC, yes</b> - when you activate a migrated ARC rule in the Unified Client Interface (UCI), the corresponding legacy rule will be de-activated.<br />- <b>For SLA, no</b> – when you activate a migrated SLA rule in the UCI, the corresponding legacy rule will remain active as they can co-exist.</ol>  

5.	**What does an ‘incomplete status’ mean?**
<ol>- If located in the **Summary** section, it means the overall migration process could not successfully complete the migration of all selected rules.<br />
- If listed next to a rule, it means the rule has either failed or could not be fully migrated (meaning one or more items/conditions failed to migrate).</ol>

6.	**Where is there a count listing partially migrated rules that are tracked in the migration tool?**<br />
Rules that are partially or identified as ‘incompletely migrated’ are counted and tracked under **Pending** in the **Summary** section since they are not considered fully migrated. Only rules that completed migration successfully are counted under **Migrated**.

7.	**Are custom forms and/or fields supported by the migration tool?** <br />
No. Custom entities, fields, attributes, and configurations are not supported by the migration tool. Only out-of-box (OOB) entities, fields, and attributes are supported by the migration tool.

8.	**Do I need a separate license for Power Automate before running migration?** <br />
No, you do not need a separate Power Automate license. See [What are Microsoft Power Apps and Power Automate use rights for Dynamics 365 applications](https://docs.microsoft.com/power-platform/admin/powerapps-flow-licensing-faq#what-are-microsoft-power-apps-and-power-automate-use-rights-for-dynamics-365-applications) for more information on licensing guidelines.

9.	**Some of my rules are incomplete and/or partially migrated, what should I do?**<br />
You can either fix the rule in the web client based on the problem details and run your migration again or fix the migrated rule directly in the Unified Client Interface (UCI).

10.	**Can I rerun the migration tool for a specific migrated rule?**<br />
Yes, you can rerun the migration tool for a specific migrated rule based on the following for:
<ol>- incomplete/failed migration rules: re-select the same rule again when you rerun the migration tool. It will automatically replace the existing failed/incomplete rule with the newly migrated one.<br />- successfully migrated rules: delete the migrated rule in the Unified Client Interface (UCI) version before rerunning migration tool.</ol>

### Known condition conversions issues
The following are some key scenarios where rules/items will not successfully complete migration:

11.	**If my rule items/conditions have related entities inside nested group clause (and/or), will they be migrated to the Unified Client Interface (UCI)?**<br />
No. We currently only support one level of the related entity hierarchy. For such rule items/conditions to successfully migrate, the user would have to remove any related entity in group clause pre-migration. If the user chooses not to take any action, the rule will fail during the **Pre-migration checkup** step and if the user chooses to continue with the migration, the rule will just have an empty condition for the respective item.

12.	**Why does my rule items/conditions with a DateType field that uses a "not on" operator fail during the pre-migration checkup and actual migration?**<br />
The **Not on** operator for the **Date** data type, is not supported in the Unified Client Interface (UCI), and thereby is not supported as part of migration. To fix this issue, the user can change the legacy items/conditions from **{not-on selecteddate}** to **{selecteddate less than and selecteddate greater than}** in the web client before rerunning the migration tool for the respective rule.

13.	**Why does the data in my DateTime field change during migration?**<br />
There is not a separate time field in the Unified Client Interface (UCI), so the DateTime field will change from a calendar control to text field.  Input should be in a specific format as shown in the text box below:<br />
**a.**	Date and time<br />
**b.**	Date only

![Web view](media\faq-arc-sla-web-view-13.png)

![UCI view](media\faq-arc-sla-uci-view-13.png)

14.	**Why are some of my operator fields blank in Unified Client Interface (UCI) after migration?**<br />
For lookup data types only the **equal / not equal, null /not null** operators are supported in UCI and are supported in the migration tool. **Under** and **not-under** operators are not supported in UCI and therefore are not supported in the migration tool. Any condition which have **under** or **not-under** operators are translated as **related entities** after migration and are shown as blank in the UCI after migration and the user cannot edit them. <br />
**a.**	Pre-migration Web Client View <br />
**b.**	Post migration UCI View

![Web view](media\faq-arc-sla-web-client-14.png)

![UCI view](media\faq-arc-sla-uci-14.png)

> [!Note]
> The following limitations are applicable when defining a condition in Customer Service Hub:
> - You can’t select a time value for the Date and Time data type. 
> - Only one level of the related entity hierarchy is supported though the application lets you select nested related entities.
> - The related entity inside a group of the and/or clause is not supported.
> - "not-on" operator for the Date data type are not supported.
> - For the lookups data type, only the "equal", "not equal", "null", and "not null" operators are supported.

### Known SLA issues
 
15.	**Can I remigrate a rule after it’s been activated?**
<ol>- <b>Yes for ARC rules.</b> You can re-migrate activated rules, but you must deactivate and delete it from the Unified Client Interface (UCI) first before you can re-migrate the rule.<br />
- <b>No for SLA rules.</b> Once a migrated SLA rule is activated, it is linked to another entity (such as a case or is in use). To attempt remigration of an activated rule (which is a successfully migrated rule by default) you need to delete that specific rule, however there is a limitation with UCI SLA rules, that once a rule is associated with a case or entity (that if it has been activated even once), you cannot delete the rule, even if it is deactivated. Therefore, the rule cannot be re-migrated if it has been previously activated and/or applied.</ol>

16.	<b>Can I migrate deprecated standard SLA rules?</b><br />
No. Only migration of enhanced SLA rules are supported by the migration tool. Standard SLA rules have been deprecated and are no longer supported in the Unified Client Interface (UCI) and therefore not supported in the migration tool. See [Standard SLAs in Dynamics 365 Customer Service](https://docs.microsoft.com/power-platform/important-changes-coming#standard-slas-in-dynamics-365-customer-service-are-deprecated) are deprecated for more information. 

### Known Flow issues

17.	**Activity party type attribute issues during workflow to Flow conversion.**<br />
Any activity party type attribute assigned to another activity party type field (the most commonly impacted fields are: to, from, cc, and bcc, in emails) will not migrate during the workflow to Flow conversion, as Flow currently does not support this scenario.  Although the migration of the rule will not fail, the data value for such activity party type fields that relies on another activity party type attribute will be empty post migration. <br /><br />
**Example:**<br /> 
**a.** The **From** field, which is activity party type field that is assigned another activity party type attribute **{Bcc(Email)}** will be empty post migration.<br />
**b.**	Whereas the **To** field will successfully migrate.

![Web view](media\faq-arc-sla-web-client-17.png)

18.	**"First not null" checks in expressions within legacy workflow during workflow to flow conversion is not supported.**<br />
In legacy workflows, a lookup field can be mapped with multiple expressions where you check and assign the **“First Not Null”** expression as shown in the Web Client example below. Currently, this is not supported as part of workflow to Flow conversion, as this is a known limitation from the legacy workflow designer. Therefore, the workflow converter assigns the first expression (without performing the null check) and removes the rest of the expressions irrespective of whether they have **"non-null"** values or not. In the sample snapshot shown below, the flow will only have **Regarding(Email)** in **Customer** field within this step.<br /><br />
**Example:** <br />
**a. Web Client View:** In the workflow, Customer field has: **{Regarding(Email);Contact(Create (Case));Customer(Create (Case))}**<br />
**b. UCI View:** In Flow, the Customer field will only have: **Regarding(Email)** regardless of whether it is null or not. 

![Web view](media\faq-arc-sla-web-client-18.png)

> [!Important] 
> If you are still experiencing issues pertaining to the migration tool, please contact your Admin or Microsoft Support.

### See Also
- 