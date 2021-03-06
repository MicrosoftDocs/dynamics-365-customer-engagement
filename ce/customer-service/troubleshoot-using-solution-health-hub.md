---
title: "Troubleshoot issues in Customer Service and Omnichannel for Customer Service with Solution Health Hub | MicrosoftDocs"
description: "Learn how to troubleshoot issues in Customer Service and Omnichannel for Customer Service by using the Solution Health Hub."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 03/05/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Troubleshoot issues in Customer Service and Omnichannel for Customer Service using Solution Health Hub

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

You can use Solution Health Hub to get a better picture of the state of your Dynamics 365 environment and detect any issues it might have. Solution Health Hub runs rules within an instance to validate the environment's configuration, which might change over time through natural system operations. The rules are specific to Customer Service and Omnichannel for Customer Service; you can run the rules on demand when you run into an issue. Some rules are automatically triggered when Customer Service or Omnichannel for Customer Service is installed or updated. You can regularly run the rule sets to monitor the health of your environment.

Some of the issues that the Solution Health Hub helps detect are as follows:

- **Customer Service**
  - Critical Customer Service processes that are deactivated
  - Processes that will cause an upgrade to fail are assigned to disabled users
  - Presence of customized web resources that might lead to runtime issues

- **Omnichannel for Customer Service**
  - Missed or wrong configurations
  - Queues with no agents
  - Agents with no capacity
  - Agents who aren't part of any queues
  - Work stream configuration problems

## Prerequisites

To run the rules for Customer Service, the following prerequisites must be met:

- The Customer Service Hub app installed in your environment.
- You should have either the CSR Manager or System Administrator security role

To run the rule for Omnichannel for Customer Service, you must have Omnichannel for Customer Service installed in your environment.

## Run a health check

Perform the following steps to run an analysis job to check for issues in Omnichannel for Customer Service:

1. Open Solution Health Hub app.
2. Select **Analysis Jobs** > **New**.
3. In the **Create Analysis Job** dialog box, in  **Rule Set**, select **Omnichannel** or **Customer Service**, and then select **OK**.

> [!Note]
>
> For Customer Service, you can run the health check from **Analysis Jobs** in **Service Management** site map of Customer Service Hub.

## Analyze the health check results

 After the analysis job completes its run, the results are displayed on the **Job Details** tab.

The following information is available:

- **Name:** The name of the analysis job.
- **Status:** The status of the run.
- **Start Time:** The date and time when the job was started.
- **End Time:** The date and time when the job completed its run.
- **Failed Rules:** The number of rules that failed.
- **Warnings:** The number of rules that resulted in warnings.
- **Passed Rules:** The number of rules that passed successfully.
- **Total Rules** The number of available rules.
- **Rule Run Count:** The count of rules that have been run.

The details of the results are displayed in a table as follows:

- **Name:** The name of the rule.
- **Message:** A brief summary of the result.
- **Return Status:** Whether the rule passed, failed, or returned a warning.
- **Severity:** The severity level.

You can do the following:

1. Select a rule for which the status appears as failed. The results of the analysis of the objects that failed are displayed in the **Failing Records** area.
    > ![Analysis job results for a rule](./media/oc-solution-health-results.png "Analysis job results for a rule")
2. Optionally, select the **Summary** tab for an overview of the results.

> [!NOTE]
> If you see any discrepancy in the health check results, rerun the job.

## Out-of-the-box rule sets for Customer Service

The out-of-the-box rules for Customer Service are as follows. These rules can't be edited.

| Rule | What the rule checks for | Reason for failure and fix |How to fix|
|----|--------|----------|-----|
| Automatic Record Creation process definitions in draft status |Checks whether ExecutePrimaryCreatePostActions and ExecuteARC custom actions are in the active or draft state when a rule for creating records automatically is being used. | The processes to create records automatically are deactivated.<br> Review whether the deactivated processes are required for your business logic and reactivate them if necessary. You can select the rule and select **Resolve**, which will activate the processes. |
|Check if Activity Monitor for Automatic Record Creation is enabled  |Checks for msdyn_ArcActivityMonitorForFailedScenarios and msdyn_ArcActivityMonitorForSkippedScenarios flag values to decide whether activity monitor is enabled. | Activity monitor is not enabled for creating records automatically. Enable the activity monitor to monitor rules to know whether they succeeded or failed.<br> More information: [Use activity monitor to review and track rules](automatically-create-update-records.md#use-activity-monitor-to-review-and-track-rules) |
|Check if autoRouteToOwnerQueue for Email is enabled|Checks whether rules to create records automatically are enabled and auto route to owner queue is set on the Email entity. |The rule for creating records automatically might not be triggered to the right user if **Automatically move records to owner's default queue** check box is selected for the Email entity.<br> More information: [Entity records routing](entity-channel.md#step-2-enable-entity-for-activities-and-queues) |
|Check if Customer Service forms are from unmanaged layer|The rule fails when Customer Service forms are found in the unmanaged layer. |Customer Service forms found in active layer. Because unmanaged solutions overwrite Customer Service metadata fixes, we recommend that you don't place the system forms in active layers in a production environment.|
|Check workflow type for convert rule and convert rule items|<ul><li> **Modern rule:** Associated workflow should be a power automate flow <li>**Legacy rule:** Associated workflow should be a legacy workfow <li>Workflow state check <ul><li> **Active rule:** Associated workflow on the rule and rule item should be present and in active state <li> **Draft rule:** Rule for creating records automatically should have no associated workflow, rule item should have associated workflow in draft state </ul></ul> | <ul><li>**Workflow type issue:** You've performed an activate or deactivate action on a legacy rule in Unified Interface form <li> **Workflow type issue:** Created rule items for a modern rule in the legacy experience </li> <li> **Workflow state issue:** You've turned on or off flow in Power Automate </li></ul> <br> How to fix the issue<ul><li>**Workflow state issue:** should be automatically corrected for customer to update the relevant workflow to its required state </li> <li> **Workflow type issue:** contact Microsoft Support </li></ul> <br> We recommend the following: <ul><li> Rules created in Unified Interface should only be edited, activated, or deactivated in Unified Interface experience</li><li> Rules created in legacy experience should only be edited, activated, or deactivated in legacy experience</li> <li> In Power Automate, do not manually turn on or off flows for creating records automatically</li> |
|ConditionXml format check| <ul><li> **Modern rule:** "conditionxml" attribute value of all the related rule items should be in fetchxml format </li><li>**Legacy rule:** "conditionxml" attribute value of all the related rule items should be in conditionxml format </li></ul> |<ul><li> Format is mismatched in rule type for creating records automatically</li><li> You've performed the activate or deactivate action on a legacy rule in Unified Interface form experience </li><li>You've created rule items of a modern rule in the legacy experience</li></ul><br> We recommend that the rules created in the Unified Interface app and legacy app be edited, activated, or deactivated in the corresponding app respectively and do not use the apps interchangeably. |
|Custom customizations on 'Customer Service Hub' sitemap|Checks for customizations on Customer Service Hub site map. |Fails when the site map is customized. More information: [Merge site map customizations](/customerengagement/on-premises/developer/understand-managed-solutions-merged#BKMK_MergingNavigationCustomizations)|
|Custom customizations on 'Customer Service Workspace' sitemap|Checks for customizations on Customer Service workspace site map. |Fails when the site map is customized. More information: Merge site map customizations|
|Customized option sets|Detects whether any option set in Customer Service has been customized. Customizing option sets can lead to unexpected behavior for unintended option sets.|Option set has been modified by customization.<br> Manually remove customizations from the Customer Service option set if they are not required for your business.|
|Deleted Sdk message processing steps|Checks whether any SDK message processing steps are deleted. Deleted SDK message processing steps will lead to incorrect behavior when using Customer Service. |Fails if any of the shipped Customer Service SDK message processing steps have been deleted from the system. <br>Contact Microsoft Support to resolve the issue.|
|Disabled Sdk message processing steps|Checks whether any SDK message processing are disabled. Disabled SDK message processing steps will lead to incorrect behavior when using Customer Service.|SdkMessageProcessingSteps are deactivated. Review if the disabled SdkMessageProcessingSteps processes are required for your business logic and reactivate them if necessary. ||
|Process definitions in draft status|Checks whether any process definitions related to Customer Service are in draft status. <br> **Note:** The ManageContract, Contractline, and Entitlement workflows are excluded from the validation check when they are in the draft state.|Processes are deactivated. Customer Service might not work correctly when processes are disabled. <br>To resolve the issue, reactivate process definition from customizations.|
|Process definitions owned by disabled users|Checks whether any process definitions in the system are assigned to disabled users. |Processes will fail because they are owned by disabled users.Make sure that all workflows are assigned to users who have the required permissions.<br> To resolve the issue, reactivate the user accounts that own workflows or assign the workflows to another user account with the proper security privileges.|
|Validate Email response template type for Modern Automatic Record Creation | The template type code of the auto reponse email template set on a rule should match the primary entity set on all its rule items:<ul><li>"responsetemplateid" stores the auto response email template on "convertrule" entity </li><li>"templatetypecode" store the template type code on email template entity </li><li>"primarycreateentitylogicalname" stores the primary create entity on "convertruleitem" entity </li> |The template type code of the autoreponse email template set on a rule did not match with the primary entity set on its rule items. As a result, the auto response will not be sent because the template type didn't match rule item primary action entity type. But will not cause failure ||
|Waiting workflow instances are owned by disabled users|Detects waiting workflow instances that are assigned to disabled users. These workflows will fail to correctly generate the records that they are supposed to generate. | The workflows are assigned to disabled users.<br> To resolve the issue, reactivate the user accounts that own the workflows or assign the workflows to another user account with the proper security privileges. |
|||||

## Out-of-the-box rule sets for Omnichannel for Customer Service

When you run the analysis job, the following out-of-the-box rules are run. These rules can't be edited.


| Rule | Description |
|----|--------|
| Agents should have capacity | Verifies that capacity has been defined for agents. More information: [Manage users](users-user-profiles.md) |
| Bots should have capacity | Verifies that bot's capacity is greater than zero. More information: [Configure a bot](configure-bot.md)|
| Bots should not have potentially low capacity  | Verifies that bot's capacity is at least a hundred times the capacity of the work stream. |
| Custom channel configuration should have work stream | Verifies that all custom channels have an active work stream. More information: [Configure a custom channel](configure-custom-channel.md) |
| Custom channel settings should have all required fields | Verifies that custom channel settings have the messaging endpoint URL field. |
| Facebook page configuration should have work stream | Verifies that all Facebook pages have an active work stream. More information: [Configure a Facebook channel](configure-facebook-channel.md) |
| Facebook settings should have all required fields | Verifies that Facebook channel settings have the messaging endpoint URL field. |
|Line channel configuration should have work stream | Verifies that all LINE channel configurations have an active work stream. More information: [Configure a LINE channel](configure-line-channel.md) |
| Line settings should have all required fields  | Verifies that LINE settings webhook URL is not empty. |
|Live chat channel configuration should have work stream | Verifies that Live Chat has an active work stream. More information:[Configure a chat channel](add-chat-widget.md) |
| Omnichannel service endpoint should be configured | Verifies that the underlying services needed for the functioning of Omnichannel for Customer Service are configured correctly. More information: [Provisioning Omnichannel for Customer Service](omnichannel-provision-license.md) |
| Queues should have agents | Verifies that the queues that are assigned to the work streams have agents assigned. More information: [Manage queues](queues-omnichannel.md) |
| SDK message/plugins should be active | Verifies that the SDK messages or plug-ins are active. More information: [Remove deactivated or disabled customizations](https://docs.microsoft.com/powerapps/developer/model-driven-apps/best-practices/business-logic/remove-deactivated-disabled-configurations) |
|SMS channel configuration should have work stream | Verifies that SMS channel has an active work stream. More information: [Configure an SMS channel for TeleSign](configure-sms-channel.md) and [Configure an SMS channel for Twilio](Configure-sms-channel-twilio.md) |
| SMS settings should have all required fields | Verifies that SMS settings don't have empty customer ID and API key fields. |
|Teams channel configuration should have work stream | Verifies that the Microsoft Teams channel configuration has an active work stream. More information: [Configure a Microsoft Teams channel](configure-microsoft-teams.md) |
|Teams settings should have all required fields | Verifies that the bot ID field is not missing from the Teams settings. |
|Twitter handle configuration should have work stream | Verifies that al Twitter handles have an active work stream. More information: [Configure a Twitter channel](configure-twitter-channel.md) |
| Twitter settings should have all required fields | Verifies that Twitter settings don't have an empty callback URL field. |
|WeChat channel configuration should have work stream | Verifies that all WeChat channel configurations have an active work stream. |
| WeChat settings should have all required fields | Verifies that the **IP whitelist** and **Server address (URL)** fields aren't empty in the WeChat settings. More information: [Configure a WeChat channel](configure-wechat-channel.md) |
|WhatsApp channel configuration should have work stream | Verifies that all WhatsApp phone numbers have an active work stream. More information: [Configure a WhatsApp channel](configure-whatsapp-channel.md) |
| WhatsApp settings should have all required fields | Verifies that WhatsApp settings have a valid Twilio inbound URL and validation has not failed. |
| Work stream capacity should be less than agents | Verifies that the capacity defined for agents is more than that defined for the work streams. More information: [Understand work streams](work-streams-introduction.md) |
| Work stream should have notification templates set | Verifies that notification templates have been set for work streams. More information: [Associate templates with work streams](../app-profile-manager/associate-templates.md) |
| Work stream should have session template set | Verifies that session templates have been set for work streams. More information: [Associate templates with work streams](../app-profile-manager/associate-templates.md)) |
| Work stream should not have duplicate context variables | Verifies that duplicate context variables haven't been defined for work streams. More information: [Create a work stream](work-streams-introduction.md#create-a-work-stream)  |
| Work stream should not have empty routing rules above rules with condition | Verifies that empty routing rules haven't been defined for a work stream that prevent routing rules with a lower priority from running. More information: [Create and manage routing rules](routing-rules.md) |
| Work stream with push mode should not allow offline mode | Verifies that "Offline" isn't an allowed presence for work streams that have push mode enabled. More information: [Create a work stream](work-streams-introduction.md#create-a-work-stream) |
|||

### See also

[Troubleshoot issues in Omnichannel for Customer Service](troubleshoot-omnichannel-customer-service.md)  
[Frequently asked questions](faqs.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]