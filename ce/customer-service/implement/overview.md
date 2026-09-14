---
title: Welcome to Dynamics 365 Customer Service
description: Learn how Dynamics 365 Customer Service supports case management, knowledge, routing, channels, analytics, and Copilot, and choose the right setup and app for your organization.
ms.date: 09/14/2026
ms.topic: overview
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom:
  - dyn365-customerservice
ms.collection: get-started
---

# Welcome to Dynamics 365 Customer Service

Dynamics 365 Customer Service helps organizations manage customer issues, provide consistent service across channels, and give customer service representatives the information and tools they need to resolve requests.

Use this article to choose an administration or representative experience and find the guidance that matches what you want to accomplish.

> [!TIP]
> - To try Dynamics 365 Customer Service, sign up for a [30-day trial](https://dynamics.microsoft.com/customer-service/customer-service/free-trial/).
> - To learn about AI-assisted capabilities for representatives, go to [Use Copilot features in Customer Service](../use/use-copilot-features.md).

## Choose how to get started

| If you want to | Start with |
|---|---|
| Configure Customer Service features, users, cases, queues, knowledge, routing, or channels | [Copilot Service admin center](cs-admin-center.md) |
| Work with cases and customer conversations in a multisession app | [Copilot Service workspace](csw-overview.md) |
| Work primarily with cases, knowledge, service activities, and dashboards | [Customer Service Hub](../use/user-guide-customer-service-hub.md) |
| Provide limited access to case management capabilities | [Customer Service Team Member](customer-service-team-member.md) |
| Review the requirements for Copilot Service workspace | [Copilot Service workspace system requirements](customer-service-workspace-system-requirements.md) |

> [!NOTE]
> The features and navigation available to you depend on the licenses and capabilities provisioned for your organization. If Dynamics 365 Contact Center is provisioned, additional contact center features are available in Copilot Service admin center.

## What you can do with Customer Service

### Manage customer service requests

- Track customer issues through cases.
- Record interactions related to a case.
- Define service terms through entitlements.
- Create and track service levels through service-level agreements (SLAs).
- Create and schedule services.

### Help representatives find information and take action

- Create and share knowledge articles.
- Use Copilot to summarize context, find information, and assist with customer service tasks.
- Collaborate with subject-matter experts in Microsoft Teams.
- Use productivity tools while maintaining the context of customer interactions.

### Route and engage customers

- Use unified routing to direct work items to the appropriate representatives.
- Manage conversations across supported digital messaging channels.
- Manage voice conversations when the required voice capabilities are provisioned.
- Handle multiple sessions without losing customer context.

### Monitor and improve service operations

- Use insights, analytics, reports, and dashboards to monitor service operations.
- Review representative productivity and customer service trends.
- Extend supported apps and channels to meet your organization's requirements.

## Administer Customer Service

Use **Copilot Service admin center** to configure Customer Service features in one place. The app provides task-oriented navigation and overview pages for customer support, representative experiences, and service operations.

Administrators can configure areas such as:

- Users, skills, capacity profiles, and experience profiles
- Cases, queues, automatic record creation rules, and service terms
- Knowledge management and productivity features
- Workstreams, unified routing, and supported channels
- Insights, analytics, operating hours, and calendars
- Copilot features and extensibility settings

Before you begin, confirm that you have the security roles and permissions required for the features you plan to configure. Go to [Get started with Copilot Service admin center](cs-admin-center.md) for prerequisites, access instructions, and available setup experiences.

## Choose an app for representatives

The Customer Service apps provide different experiences based on the work representatives perform. Use the following summary to choose an app, and then review the linked article for requirements and detailed capabilities.

| App | Use it for | Important considerations |
|---|---|---|
| [Copilot Service workspace](csw-overview.md) | Multisession case management, customer conversations, channels, knowledge, analytics, and productivity tools | Some channels and capabilities require additional licenses or provisioning. |
| [Customer Service Hub](../use/user-guide-customer-service-hub.md) | Single-session case management, knowledge, insights, service scheduling, and connected service scenarios | It doesn't provide the multisession conversation experience. |
| [Customer Service Team Member](customer-service-team-member.md) | Limited case management and read-only knowledge access | It doesn't include channels, conversations, analytics, or service scheduling. |
| [Omnichannel for Customer Service](introduction-omnichannel.md) | Existing organizations that still use the legacy Omnichannel application | This app is deprecated. Review the linked guidance before planning new deployments or changes. |

## Copilot agents in Customer Service

Copilot in Dynamics 365 Customer Service includes AI-powered agents that extend Microsoft 365 Copilot with customer service-specific capabilities.

These agents use your organization's customer service data, such as cases, customer records, and interactions, to help representatives find information, summarize context, and take actions without leaving their workflow.

For example, [Service Agent](../use/use-service-agent.md) helps representatives retrieve case details, generate summaries, update cases, and create follow-up activities in supported Copilot experiences.

Administrators configure Copilot capabilities, access, and extensibility in Copilot Service admin center. Representatives can use supported Copilot agents in Microsoft 365 Copilot and Copilot Service workspace.

## Use Customer Service on supported devices

Customer Service apps are available through supported web browsers. For mobile scenarios, install the applicable Dynamics 365 app for your device. Go to [Install Dynamics 365 for phones and tablets](../../mobile-app/install-dynamics-365-for-phones-and-tablets.md) for requirements and instructions.

## Accessibility and privacy

Customer Service apps support inclusive and accessible experiences. Review [Accessibility and privacy](../use/user-guide-customer-service-hub.md#accessibility-and-privacy) for information about accessibility features and privacy compliance.

## Related resources

- [Get started with Copilot Service admin center](cs-admin-center.md)
- [Copilot Service workspace system requirements](customer-service-workspace-system-requirements.md)
- [Customer Service Hub user guide](../use/user-guide-customer-service-hub.md)
- [Use Copilot features in Customer Service](../use/use-copilot-features.md)
- [Use Service Agent](../use/use-service-agent.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
