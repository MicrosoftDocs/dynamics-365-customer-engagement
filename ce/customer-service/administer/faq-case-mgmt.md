---
title: FAQ on managing cases
description: Learn about the frequently asked questions (FAQ) on the different features in case management.
ms.date: 04/22/2026
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# FAQ on managing cases

This article provides answers to frequently asked questions about managing cases.

## General

### How can I create a case when the contact isn't linked to the customer organization?

Out of the box, customer service representatives (service representatives or representatives) can't create a case because the contact isn't associated with the customer organization. However, you can [customize case forms and remove the validation on contact](remove-validation-contacts.md) and allow unrelated contacts to be linked with the case. 

### Why can I use only few columns to search in the Case view?

 To search on columns of your choice, make sure that the quick find search is configured for the required search parameters. More information: [Use quick find search](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).

### Why do representatives get permission errors when they try to access, create, delete, or update a case?

If the role assigned to representatives is missing security privileges, permission errors are displayed when they perform case actions. For example, the following error is displayed when a representative tries to access a case, and the role assigned to the representative is missing read privileges:

Principal user (Id= \<GUID>, type=8, roleCount=5, privilegeCount=465, accessMode=0), is missing prvReadincident privilege (Id=\<GUID>) on OTC=112 for entity 'incident'. context.Caller=\<GUID>

To resolve the error, ensure that role assigned to the representative has read access to the case entity. More information, see: [Security roles and privileges](/power-platform/admin/security-roles-privileges). You can also refer to the out-of-the-box Customer Service Representative role before you create custom roles or modify permissions of roles assigned to representatives. More information: [Roles and personas](role-persona-mapping.md)

### Why do I see a warning when I add and save case attributes that a child case must inherit from the parent case?

If you see a warning once you select the case attributes that a child case must inherit from the parent case, it means that you didn't select any of the mandatory attributes. You must select all of the mandatory fields whose values the child case will inherit. Select the mandatory case attributes whose values the child case inherits. **Case Title** and **Customer** are mandatory attributes. More information: [Define settings for parent and child cases](define-settings-parent-child-cases.md).

### Why do I receive an "Expected non-empty Guid" error when I create a case?

This error occurs when case creation includes a required lookup column that contains an empty or invalid GUID. The issue can occur when a customer, contact, or entitlement lookup populated by a Power Automate flow, workflow, or plug-in resolves to a blank value, when a custom script or integration passes a malformed GUID, or when a quick-create form or field mapping transfers an empty GUID from a related record during case creation.

To identify and resolve the issue, follow these steps:

1. Reproduce the issue by using [Live monitor](/power-apps/maker/model-driven-apps/monitor-form-checker) or review the plug-in trace log.
1. Identify the lookup column that contains the invalid GUID.
1. Correct the automation, script, integration, or field mapping that populates the column.
1. If you create cases by using the Web API or SDK, verify that every `@odata.bind` reference points to an existing record.

### Why is case creation through the Web API slow or intermittently delayed?

Slow case creation or intermittent delays might be due to any of the following reasons:
- Processing delays because of service protection limits that restrict high volumes of requests.
- Synchronous plug-ins or real-time workflows that run when a case is created, cascading operations that update or evaluate large numbers of related records.
-  Service protection API limits that throttle requests when transaction volume exceeds allowed thresholds.

To identify the source of the latency, correlate slow requests with plug-in trace logs and determine whether the delays occur during periods of high activity or when specific synchronous processes run. Consider moving nonessential synchronous processing to asynchronous operations to reduce the impact on case creation performance. If requests are being throttled, implement retry logic that respects the Retry-After response header. Learn more in [Service protection API limits](/power-apps/developer/data-platform/api-limits).

## FAQ on case forms

### Why is a field, such as Description, missing from the case form for some users?

A field might not appear because of form, security, or customization settings. Check the following configurations.

- Ensure that affected users are opening the correct form. A higher order form might open. Learn more in [Set form order](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order).
- Verify that the users are assigned the appropriate field-level security profiles.
- Verify that the users have read access to the table that contains the field.
- Review active [solution layers](/power-apps/maker/data-platform/solution-layers) to determine whether another customization is overriding the field configuration.
- Publish all customizations after importing a solution.

### Why are the Save and Save & Close buttons hidden?

Custom command rules or solution customizations can hide the **Save** and **Save & Close** buttons. Use Command checker to identify the rule that's affecting the command.

1. Follow the guidance in [Troubleshoot ribbon issues in Power Apps](/troubleshoot/power-platform/power-apps/create-and-use-apps/ribbon-issues) to enable Command checker.
1. Open Command Checker and search for the **Save** or **Save & Close** command and do the steps in [Inspect a command](/troubleshoot/power-platform/power-apps/create-and-use-apps/ribbon-issues#inspect-a-command)

### Why do I receive an HTTP 500 error when I save a case?

This error can occur when an `OnSave` script, synchronous plug-in, or other customization fails during the save operation. To identify the source of the error, perform the following steps:

1. Reproduce the error by using [Live monitor](/power-apps/maker/model-driven-apps/monitor-form-checker).
1. Review the browser network trace and plug-in trace log.
1. Identify the failing `OnSave` script or synchronous plug-in.
1. Disable `OnSave` handlers one at a time to isolate the issue.
1. Correct the failing script or plug-in.


### Why do I receive an error indicating that a component referenced by the form can't be found?

This error can occur when the form references a component that's unavailable in the environment, such as a web resource, view, subgrid, or related form. To identify and resolve the issue, perform the following steps:

1. Verify that the missing component is included in the deployed solution.
1. Compare solution versions across environments to identify missing or outdated components.
1. Import the complete solution if any required components are missing.
1. Publish all customizations to ensure the latest changes are applied.
1. Clear the client cache.

### Why does the case form take a long time to load?

The form can load slowly if it contains many controls on the default tab, uses synchronous `OnLoad` scripts, or includes a resource-intensive timeline. To identify the source of the delay, use [Live monitor](/power-apps/maker/model-driven-apps/monitor-form-checker). After you identify the cause, optimize the affected components by following the guidance in [Design forms for performance in model-driven apps](/power-apps/maker/model-driven-apps/design-performant-forms).

## FAQ on resolving cases

### Why can't I see Billable time, Remarks, or Total time fields on the case resolution dialog box?

By default, representatives see the minimal case resolution dialog. The minimal case resolution dialog displays the **Resolution Type** and **Resolution** only. You can disable the minimal case resolution dialog and switch to the legacy experience. Learn more in [Disable the minimal case resolution dialog](add-enhanced-case-management.md#disable-the-minimal-case-resolution-dialog). 

   > [!NOTE]
   > - You can revert to the legacy case resolution dialog only if the **Case settings** > **Other settings** > **Resolve case dialog** is set to **Standard dialog** in Copilot Service admin center.
   > - If **Resolve case dialog**  is set to **Customizable dialog** or **Quick create dialog**, to add **Duration**, **Billable Time**, **Total Time** and other customizations, perform the steps in [Add or remove fields from the case resolution dialog](modify-case-resolution-dialog.md#add-or-remove-fields-from-the-custom-case-resolution-dialog).


### Can I update cases after they're resolved or canceled?

Yes, representatives can update the case description or other information after the case is resolved or canceled. You must configure and run flows in Power Automate or an API to update the case without having to reopen the case records. More information: [Allow updates for resolved and canceled cases](update-resolved-canceled-cases.md).

### Why isn't the billable time automatically updated on the case resolution dialog? 

Billable time is the amount of time the representative spent on the case and can be billed to the customer. The application automatically calculates and displays the **Billable Time** value on the case resolution dialog, only if the **Total Time** field is also available on the dialog. If **Total Time** isn't displayed, representatives have to manually add the billable time. More information: [Add or remove fields from the case resolution dialog](modify-case-resolution-dialog.md#add-or-remove-fields-from-the-custom-case-resolution-dialog).

### Can I customize the case resolution dialog?

Yes. More information: [Modify the case resolution dialog](modify-case-resolution-dialog.md).

### Why can't I see the custom value I added to Case resolution type field in the case resolution dialog?

Make sure that you added the custom value to both the **Case** and **Case Resolution** entity for the custom value to be displayed on the case resolution dialog. Learn more in [Add custom values to the case resolution dialog](modify-case-resolution-dialog.md#add-or-remove-fields-from-the-custom-case-resolution-dialog).

### Why can't I set the Case Status field on a case to Resolved?

A case is resolved only when you select **Resolve case** on the command bar. You can't set the value of the **Case Status** field to **Resolved**. More information: [Resolve a case](../use/customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md#resolve-a-case).

### Why do I see errors when I try to resolve a case?

 Resolve a case isn't supported if **Regarding** field is configured in **Case resolution dialog**, and representatives see errors if they try to resolve the case.

## Enhanced case experience

### I used the form selector on the Enhanced full case form to navigate to another form. Why can't I go back to the enhanced form?

Starting Feb 1 2024, the **Enhanced case form** is available in the form selector by default as an [early access feature](/power-platform/admin/opt-in-early-access-updates).

If you didn't opt in to the early access feature, you can't navigate to Enhanced case form using form selector since the **ShowInFormSelector** option in Enhanced full case form is set to **False**. Set **ShowInFormSelector** to **True** through FormXML, to see the **Enhanced full case form** option in the form selector and navigate back to it.

### When I navigate from the enhanced case form to another form and change the customer information, why isn't the customer details pane refreshed automatically?

The customer details pane is available only for the enhanced case form. When you switch to any other form from the enhanced case form, the pane isn't automatically refreshed or closed. You need to close it manually.

### Why are representatives seeing the Enhanced case form when they create a case even if I haven't enabled Enhanced case experience?

If the **Enhanced full case form** has a higher form order than the default case form, representatives might see the enhanced full case form even if you haven't enabled the enhanced case experience. If you'd like representatives to see the default case experience, set the form order of the enhanced form lower than the default form. More information: [Control access to model-driven app forms](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order).

### Why do my existing cases open in the default case form when I've enabled the enhanced case experience?

You must set the **Enhanced full case form** as the default form for your representatives to see the enhanced full case form when they open an existing case. More information: [Control access to model-driven app forms](/power-apps/maker/model-driven-apps/control-access-forms).

## Resolve form issues

### How can I resolve the discrepancies in the number of buttons displayed on the command bar and ribbon issues in my case form?

If representatives see buttons being hidden or extra buttons displayed on the form, you can use the [**Command Checker**](https://powerapps.microsoft.com/blog/introducing-command-checker-for-model-app-ribbons/) tool to troubleshoot the issue and also see what command runs when a button is clicked.

You can follow the steps in [Troubleshooting ribbon issues in Power Apps](/troubleshoot/power-platform/power-apps/create-and-use-apps/ribbon-issues) to resolve ribbon issues.

### How can I identify and resolve form issues effectively?

Form issues occur because of business rules, JavaScript, form events, or client APIs. Monitor is a tool that can help you debug and diagnose problems, and can also help identify whether the issue experienced is designed out-of-the-box or due to a customization. More information: [Use Monitor to troubleshoot model-driven app form behavior](/power-apps/maker/model-driven-apps/monitor-form-checker).

### Why does the Responsible Contact Id field show null/blank when I refresh the browser or open the record in a new tab?

Responsible Contact Id is a deprecated field. With the recent platform enhancements, deprecated attributes aren't populated when a form loads in a new tab. More information: [ResponsibleContactId lookup attribute is deprecated](../implement/deprecations-customer-service.md#responsiblecontactid-lookup-attribute-is-deprecated)
