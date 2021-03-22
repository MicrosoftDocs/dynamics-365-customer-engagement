---
title: "Set up simplied routing | MicrosoftDocs"
description: "How to set up simplied routing"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# How to set up unified routing for a channel

## Prerequisites

- Omnichannel admin center app.
- To configure record routing, entity routing toggle is set to yes.
- To use skill-based routing, skills are configured.
- To use machine learning work classification, skill model must have been configured.
- To use capacity-based classification, capacity profile must have been configured.

## How to set up unified routing

The high-level process to set up unified routing for a channel or record is as follows:

1. Create a workstream
   - Create a workstream for messaging
     - Configure routing rules
       - Configure manual work classification rulesets
         - Create demand rules
       - Configure machine-learning work classification rulesets 
         - Set up input and output attributes
       - Configure route-to-queues ruleset
   - Create a workstream for record routing
     - Configure intake rules
     - Configure routing rules
       - Configure work classification
       - Configure route-to-queues ruleset
2. Create queues
   - Assignment methods
     - Highest capacity
     - Round robin
     - Custom assignment method
      - Configure prioritization ruleset
        - Decision list of rules
      - Assignment rulesets
        - Decision list of rules
      - Selection criteria