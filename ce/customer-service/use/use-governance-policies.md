---
title: Use governance policies
description: Learn about governance policies, a rule-based system that ensures AI assistants operate safely and within compliance guidelines.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
ms.date: 07/01/2026
ms.custom: bap-template
---

# Use governance policies

[!INCLUDE [cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

Use governance policies to evaluate AI-generated email responses before sending. These policies help enforce compliance with business, legal, and regulatory requirements. If a response violates a policy, the system either flags or blocks the violation for review.


> - This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature isn't intended for use in making—and shouldn't be used to make—decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This responsibility also includes adequately notifying end users that their communications with representatives may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their representatives that their communications with end users may be monitored, recorded, or stored.

## Prerequisites

- You have the CSR Manager role.
- You set up [Microsoft Copilot credits](../administer/setup-pay-as-you-go.md#set-up-pay-as-you-go).
- You provided consent for potential [data movement across regions](/power-platform/admin/geographical-availability-copilot?utm_source=chatgpt.com&tabs=new).
- You enabled AI agents for your Dynamics 365 environment in Power platform admin center. Learn more in [Copilot adoption in the Power Platform](/power-platform/admin/copilot/copilot-hub).

## Enable governance policies

1. In Copilot Service workspace, go to **Service** > **Governance**. The **Governance** page appears.
1. Select **New policy** or select any of the default system policies, such as **Email Template Adherence**, **Groundedness**, or **Profanity**.
1. If you select a system policy, you can edit the given conditions, save, and publish the policy to reactivate the policy. Select **Unpublish**, if you need to retain it in a draft state after editing the policy.
1. If you select **New policy**, then on the **Add a policy** dialog, provide the following information:
    1. In the **Details** section:
        - **Policy name**: Enter a name for your policy.
        - **Description**: Enter a short description for your policy.
    1. In the **Content to check** section, provide:
        - **Content type**: The content type is **Email** by default.
        - **Written by**: Select **Customer service representatives** or **Autonomous AI**.
        - **How strictly to enforce**: Select **Flag noncompliant content** or **Block noncompliant content**.
        - **Attached files**: Select the checkbox if you want to evaluate file attachments in addition to the email body. The system evaluates only text-based content; it ignores image content in attachments. Supported file formats are .docx, .pdf, and .txt.
    1. In the **Policy strictness** section, select from the following options:
        - **Low**: Applies minimal enforcement and might allow a greater number of potential violations to pass without being flagged.
        - **Medium**: Default setting. Applies a balanced level of enforcement.
        - **High**: Applies stricter evaluation and flags more potential violations.
        - **Very High**: Applies the most aggressive enforcement, including minor deviations from policy definitions.
        Consider using High or Very High strictness when regulatory compliance requirements are strict, sensitive business information must be closely monitored, or organizations want more conservative policy enforcement. Use Low or Medium settings when reducing false positives is a higher priority.
    1. **Conditions for content**: Add conditions to select a subset of emails that meet the conditions. If you don’t select any conditions, the system evaluates all emails in the check.
1. Save and publish.

You must review the generated prompt. To refine the policy behavior, update the prompt instructions. Each prompt generation consumes Microsoft Copilot credits.

If you're using a custom Customer Service workspace app, you might need to [add governance to the site map](#add-governance-to-the-site-map-in-a-custom-customer-service-workspace-app).

## Manage policies

You can deactivate a policy by selecting **Unpublish**, delete a policy, or run a simulation for a policy.

## Run a simulation

Use simulation to validate how accurately a policy runs.

1. On the **Governance** page, on the **Policy check** tab, select **Simulation**.
1. On the **Governance policy simulation** page, on the **Simulation setup** tab, in the **Set up policy simulation** section, provide the following information:
    1. **Simulation name**: Provide a name.
    1. **Data source**: Select **Excel Upload** or **Organization Records**. 
        1. If you select **Organization Records**, then add the conditions that would be applicable during a simulation run. You can select up to 30 email records.
        1. If you select **Excel Upload**, then upload your file as per the excel file guidance.
    1.**Simulation scenario**: Select the policies to apply.
1. Select **Run Simulation**.

You can view the results under the **Simulation result** tab. You can **View** or **Download** the results. When you select **View** for a policy, the **Simulation overview** page appears. You can view the details of the **Simulation Setup**, **Compliance Summary**, and **Detailed Results**. The detailed results show the email body, policy, violation status, and the violation reason. You might need to adjust policy prompts to improve results.

## View detection log

View logs on the **Policy flags/blocks log** tab on the **Governance** page. You can delete or refresh the logs as needed.

## Add governance to the site map in a custom Customer Service workspace app

When you're using a customized Customer Service workspace app, the Governance option might not appear in the site map. You need to manually add the Governance entry to the site map by using the Power Apps designer.

### Prerequisites

Before you begin, ensure that:

- Have access to Power Apps with permissions to edit the app.
- Can modify the custom Customer Service workspace app.
- Have appropriate privileges to assign table permissions.

## Add the governance site map entry

To manually add the Governance entry, follow these steps:

1. Go to **Power Apps** > **Apps**, search for the customized app, and open it.
1. Go to **Pages** and search for **Governance**. If the entry doesn't exist, select **+ New** to create one.
1. Select **Navigation URL/Link** as the page type.
1. Enter the following details:
    - Name: **Governance**
    - URL: **/main.aspx?pagetype=control&controlName=msdyn_MscrmControls.GovernanceAgent.GovernanceAgentSettingsControl**
1. After you create the page, open the right-side panel and add the following table privileges:
    - Table: **msdyn_guardrail_rule**
    - Permission: **Write**
1. Save and publish changes.
1. Perform a hard refresh to see the new site map entry appear.

## Related information

[Configure governance policies](../administer/configure-governance-policies.md)  
[Responsible AI FAQ for AI agents](/dynamics365/contact-center/implement/faq-rai-ai-agents)