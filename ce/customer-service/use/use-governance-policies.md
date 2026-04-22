---
title: Use governance policies
description: Learn about governance policies, a rule-based system that ensures AI assistants operate safely and within compliance guidelines.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
ms.date: 04/22/2026
ms.custom: bap-template
---

# Use governance policies (preview)

[!INCLUDE [cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

Create and enforce policies to prevent noncompliant customer communications. Governance policy checks evaluate AI-generated emails before sending, ensuring compliance with business, legal, and regulatory standards. Failed responses are blocked, and violations are surfaced for review and improvement.


> [!IMPORTANT]
>
> - This is a preview feature. 
> - Preview features aren’t meant for production use and might have restricted functionality. These features are subject to [supplemental terms of use](https://go.microsoft.com/fwlink/?linkid=2189520), and are available before an official release so that customers can get early access and provide feedback.


## Prerequisites

- The CSR Manager role.
- Set up [Microsoft Copilot credits](../administer/setup-pay-as-you-go.md#set-up-pay-as-you-go)
- Provide consent for potential [data movement across regions](/power-platform/admin/geographical-availability-copilot?utm_source=chatgpt.com&tabs=new).
- Enable AI agents for your Dynamics 365 environment in Power platform admin center. Learn more in [Copilot adoption in the Power Platform](/power-platform/admin/copilot/copilot-hub).

## Enable governance policies

1. In Copilot Service workspace, go to **Service** > **Governance**. The **Governance** page appears.
1. Select **New policy** or select any of the default system policies, such as **Email Template Adherence**, **Groundedness**, or **Profanity**.
1. If you select a system policy, you can edit the given conditions, save, and publish the policy to reactivate the policy. Select **Unpublish**, if you need to retain it in a draft state after editing the policy.
1. If you select **New policy**, then on the **Add a policy** dialog, provide the following information:
    1. In the **Details** section:
        1. **Policy name**: Provide policy name.
        1. **Description**: provide a short description for your policy.
    1. In the **Content to check** section, provide:
        1. **Content type**: The content type is **Email** by default.
        1. **Written by**: Select **Customer service representatives** or **Autonomous AI**.
        1. **How strictly to enforce**: Select **Flag noncompliant content** or **Block noncompliant content**.
    1. **Conditions for content**: Add conditions to select a subset of emails that meet the conditions. If you don’t select any conditions, all emails are run through for the check.
1. Save and publish.

You must review the generated prompt. If you want to make changes, update the instructions to refine prompt. Microsoft Copilot credits are consumed each time a prompt is generated.

## Manage policies

You can deactivate a policy by selecting **Upublish**, delete a policy, or run a simulation for a policy.

## Run a simulation

Use simulation to validate how efficiently a policy runs.

1. On the **Governance** page, on the **Policy check** tab, select **Simulation**.
1. On the **Governance policy simulation** page, on the **Simulation setup** tab, in the **Set up policy simulation** section, provide the following information:
    1. **Simulation name**: Provide a name.
    1. **Data source**: Select **Excel Upload** or **Organization Records**. 
        1. If you select **Organization Records**, then add the conditions that would be applicable during a simulation run. You can select up to 30 email records.
        1. If you select **Excel Upload**, then upload your file as per the excel file guidance.
    1.**Simulation scenario**: Select the policies to apply.
1. Select **Run Simulation**. 

You can view the results under the **Simulation result** tab. You can **View** or **Download** the results. When you select **View** for a policy, the **Simulation overview** page appears. You can view the details of the **Simulation Setup**, **Compliance Summary**, and **Detailed Results**. The detailed results show the email body, policy, violation status, and the violation reason.

## View detection log

You can view logs under the **Policy flags/blocks log** tab on the **Governance** page. You can also delete or refresh the logs as required.

## Related information

[Configure governance policies (preview)](../administer/configure-governance-policies.md#configure-governance-policies-preview)

