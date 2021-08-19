---
title: "How unified routing and assignment works in Customer Service | MicrosoftDocs"
description: "How to set up unified routing"
ms.date: 05/10/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# How unified routing and assignment works

## Prerequisites

Unified routing can be configured in the Omnichannel admin center or Customer Service Hub app only.

- The latest release of Customer Service and Omnichannel for Customer Service must be installed. More information: [What's new in Customer Service](/dynamics365-release-plan/2021wave1/service/dynamics365-customer-service/)
- To configure record routing, set the entity routing toggle to yes. More information: [Provision unified routing](provision-unified-routing.md)
- To use skill-based routing, skills must be configured. More information: [Set up skills for routing](overview-skill-work-distribution.md)
- To use machine learning work classification, the skill model must be configured and published. More information: [Set up intelligent skill finder model](set-up-skill-based-routing.md#set-up-intelligent-skill-finder-model)
- To use capacity profile-based classification, the capacity profile must be configured. More information: [Create and manage capacity profiles](capacity-profiles.md)

## How to set up unified routing

The high-level process to set up unified routing for a channel or record is as follows:

1. [Create a workstream for unified routing](create-workstreams.md)
2. [Configure routing rules](configure-work-classification.md)
3. [Create queues](queues-omnichannel.md)
4. [Configure assignment rules](assignment-methods.md)

### See also

[Set up unified routing for records](set-up-record-routing.md)  
[Set up skill-based routing](overview-skill-work-distribution.md)  
[Manage capacity profiles](capacity-profiles.md)  
[Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md)  
[FAQs on unified routing](unified-routing-faqs.md)  
