---
title: "Set up unified routing | MicrosoftDocs"
description: "How to set up unified routing"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 05/10/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Set up unified routing

## Prerequisites

Unified routing can be configured in the Omnichannel admin center or Customer Service Hub app only.

- To configure record routing, set the entity routing toggle to yes. More information:[Provision unified routing](set-up-record-routing.md#provision-unified-routing)
- To use skill-based routing, skills must be configured.
- To use machine learning work classification, the skill model must be configured and published. More information: [Set up intelligent skill finder model](intelligent-skill-model.md)
- To use capacity profile-based classification, the capacity profile must be configured. More information: [Create and manage capacity profiles](capacity-profiles.md)

## How to set up unified routing

The high-level process to set up unified routing for a channel or record is as follows:

1. [Create a workstream for unified routing](create-workstreams.md)
2. [Configure routing rules](configure-work-classification.md)
3. [Create queues](queues-omnichannel.md)
4. [Configure assignment rules](assignment-methods.md)
5. [Set up unified routing for records](set-up-record-routing.md)
6. [Set up skill-based routing](overview-skill-work-distribution.md)


### See also

[Create and manage workstreams for unified routing](create-workstreams.md)  
[Set up record routing](set-up-record-routing.md)  
[Manage capacity profiles](capacity-profiles.md)  
[Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md)  
[FAQs on unified routing](unified-routing-faqs.md)  