---
title: Copilot Service workspace system requirements
description: Learn about the system requirements and prerequisites to use Copilot Service workspace in Dynamics 365 Contact Center and Customer Service.
ms.date: 06/26/2025
ms.topic: concept-article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# System requirements for Copilot Service workspace

This article provides information about the prerequisites and system requirements to use Copilot Service workspace in your organization.

## Prerequisites

This section lists the prerequisites to use Copilot Service workspace.

### Licensing

An active subscription to Microsoft Dynamics 365 Customer Service Enterprise in your tenant for each user. Learn more in [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

### Software requirements

| Area | Requirements |
|----------|----------|
| Model-driven app | Dynamics 365 Copilot Service workspace app 9.2.0000.00000. |
| Web browsers | Latest three major releases of the supported browsers: <li> Microsoft Edge</li> <li> Google Chrome</li> |

### Hardware requirements

| Area | Requirements |
|----------|----------|
| RAM | A minimum of 4 GB |
| Latency  | - Within the same country, region, geographic location: 150 ms or less. <br> - Across countries, region, geographic locations: 300 ms or less.|
| Throughput | A minimum of 4 Mbps|

A notification appears for your customer service representatives if the latency is more than the specified range. Learn more in [Verify network capacity and throughput for clients](/power-platform/admin/verify-network-capacity-throughput-clients).

Administrators can gain insights into network latency for their tenants across different regions by enabling [Telemetry Insights](/dynamics365/guidance/implementation-portal/telemetry-insights-set-up) and evaluating [performance-related rules](/dynamics365/guidance/implementation-portal/telemetry-insights#performance-related-rules) on the Dynamics 365 Implementation Portal.

Network latency issues are unique to your infrastructure. You must identify and address the specific issues in your network to resolve any latency issues.

> [!IMPORTANT]
> To use the omnichannel capabilities, you'll need a higher network bandwidth. Learn more in [system requirements](/dynamics365/contact-center/implement/system-requirements-contact-center).

Learn more about requirements in [Model-driven app requirements](/power-platform/admin/online-requirements).

### Limitations

- Copilot Service workspace isn't supported on mobile devices, Unified Service Desk, and Dynamics 365 Customer Engagement (on-premise).

### Related information

[Introduction to Copilot Service workspace](csw-overview.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]