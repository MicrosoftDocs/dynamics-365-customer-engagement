---
title: Configure governance policies
description: Governance policies help you enforce compliance, security, and content-safety for customer communications. Learn how to set up and manage effective policies.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
ms.date: 07/08/2026
ms.custom: bap-template
---

# Configure governance policies

[!INCLUDE [cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

Configure governance policies to help enforce compliance, security, and content‑safety standards across customer communications in your organization. The system evaluates outbound messages, including both AI‑generated and representative-authored messages, against configurable policies to automatically detect and manage sensitive, restricted, or noncompliant content. Governance policy supports the email channel and extends the safety checks used across other autonomous agents.

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. It isn't intended to be used, and shouldn't be used, to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. <br> 
> Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws that are related to accessing individual employee analytics, and monitoring, recording, and storing communications with users. As part of this compliance, customers must adequately notify users that their communications with customer service representatives (service representatives or representatives) might be monitored, recorded, or stored. As required by applicable laws, customers must also obtain consent from users before they use this feature with them. In addition, customers are encouraged to have a mechanism in place to inform their service representatives that their communications with users might be monitored, recorded, or stored.

## Prerequisites

- Administrators need the CSR Manager role.
- Service representatives need the Customer Service Representative role.
- For custom roles assigned to service representatives, you need to add Read at Global level on msdyn_governanceagent_status.
- For custom roles assigned to administrators, add `Read`, `Create`, `Write`, `Delete`, `Append`, `Appendto`, and `Assign` permissions at Global level on:
    - msdyn_governanceagent_status
    - msdyn_guardrail_consumer_mapping
    - msdyn_guardrail_execution_info
    - msdyn_guardrail_rule
    - msdyn_guardrail_rule_version
    - msdyn_guardrail_scenariotype
- Set up [Microsoft Copilot credits](setup-pay-as-you-go.md#set-up-pay-as-you-go).
- Provide consent for potential [data movement across regions](/power-platform/admin/geographical-availability-copilot?utm_source=chatgpt.com&tabs=new).
- Enable AI agents for your Dynamics 365 environment in Power platform admin center. Learn more in [Copilot adoption in the Power Platform](/power-platform/admin/copilot/copilot-hub).

## Enable governance

1. In the site map of Copilot Service admin center, in **Customer Support** > select **Quality management**.
1. On the **Quality management** page, select **Manage** for **Governance**.
1. On the **Governance** page, turn on the toggle for governance.

## How a governance policy works

**Runtime evaluation**:

The system evaluates each email drafted by a service representative or an AI agent by validating the content against active policies. When it detects a policy violation, the system performs the following actions in accordance with your selected settings:

- Blocks the outgoing message
- Logs the violation for later review
- Routes the message for manual approval workflows

**Log and review**:

Administrators can:

- Review detection logs
- Identify repeated risk patterns
- Adjust policy descriptions to refine system prompts

## Related information

[Use governance policies](../use/use-governance-policies.md)  
[Use evaluation criteria](/dynamics365/contact-center/use/evaluation-criteria)  
[Use evaluations](/dynamics365/contact-center/use/use-evaluations)  
[Responsible AI FAQ for AI agents](/dynamics365/contact-center/implement/faq-rai-ai-agents)