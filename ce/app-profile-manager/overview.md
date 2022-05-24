---
title: "Overview of agent experience profiles | MicrosoftDocs"
description: "Overview of the agent experience profiles."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.topic: overview


---

# Agent experience profiles

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## Introduction

You can create targeted app experiences for agents and supervisors. Agent experience profiles are an alternative to building and maintaining custom apps.
With the agent experience profiles, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

Agent productivity tools use intelligence and automation to enable agents to find answers to customer questions and help resolve customer issues quickly, thereby improving satisfaction in service delivery. Agent productivity tools enable easy knowledge base search, suggestions for similar knowledge articles and cases, and agent scripts with macros to automate tasks in common workflows. 

The profiles are available for agents and supervisors who use the Customer Service workspace or Omnichannel for Customer Service apps.

The system requirements for agent profiles are same as those for Customer Service workspace. More information: [System requirements for Customer Service workspace](../customer-service/customer-service-workspace-system-requirements.md)

## How the agent experience profile experience works

Managing the agent experience profiles is as follows. The tasks in every step will be done by administrators who have different roles. It could be one administrator or a set of administrators.

1. Create users in Microsoft Dynamics 365 admin center.
2. Assign security roles, such as Customer Service Representative or Omnichannel agent.
3. Create business processes, such as work streams, queues, sessions, and productivity tools.
4. Create agent experience profiles.
5. Assign agent experience profiles to users.

For existing orgs, only steps 4 and 5 are required.

Thereafter, users with the required agent or supervisor role will be able to see and use the settings that are made available through the assigned agent experience profile. If you do not assign an agent experience profile, by default, the out-of-the-box agent experience profile will be assigned.

You can create and manage agent experience profiles in the Customer Service Admin Center app or in Power Apps.

### See also

[Create app profiles](app-profile-manager.md)  
[System requirements](../customer-service/customer-service-workspace-system-requirements.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
