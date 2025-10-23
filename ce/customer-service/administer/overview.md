---
title: Overview of experience profiles
description: Overview of the experience profiles in Dynamics 365 Contact Center and Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 07/30/2025
ms.topic: overview
ms.custom: bap-template
---

# Overview of experience profiles

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Experience profiles enable you to create targeted app experiences for customer service representatives (service representatives or representatives) and supervisors, and are an alternative to building and maintaining custom apps.

With the experience profiles, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

Productivity tools use intelligence and automation to enable service representatives to find answers to customer questions and help resolve customer issues quickly, improving satisfaction in service delivery. The productivity tools help in easy knowledge base search, suggestions for similar knowledge articles and cases, and scripts with macros to automate tasks in common workflows. 

The profiles are available for service representatives and supervisors who use the Copilot Service workspace app.

The system requirements for experience profiles and Copilot Service workspace are the same. More information: [System requirements for Copilot Service workspace](../implement/customer-service-workspace-system-requirements.md)

## How experience profile works

You can manage the experience profiles as follows. The tasks in every step are done by administrators who have different roles. It could be one administrator or a set of administrators.

1. Create users in Microsoft Dynamics 365 admin center.
1. Assign security roles, such as Customer Service Representative or Omnichannel agent.
1. Create business processes, such as work streams, queues, sessions, and productivity tools.
1. Create experience profiles.
1. Assign experience profiles to users.

For existing orgs, steps 4 and 5 only are required.

Thereafter, users with the required service representative or supervisor role can see and use the settings that are made available through the assigned experience profile. If you don't assign an experience profile, the system assigns the out-of-the-box experience profile by default.

You can create and manage experience profiles in the [Copilot Service admin center app](create-agent-experience-profile.md).

### Related information
[Create and use experience profiles](create-agent-experience-profile.md)    
[System requirements](../implement/customer-service-workspace-system-requirements.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
