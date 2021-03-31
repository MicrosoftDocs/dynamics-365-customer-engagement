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


<!-- The metadata title calls this "simplified" routing but the title says "unified" routing. Are they the same? In line 20, should it be "Omnichannel for Customer Service admin center app"? -->


# How to set up unified routing for a channel

## Prerequisites

For this process, you'll need the Omnichannel admin center app.

- To configure record routing, set the entity routing toggle to yes.
- To use skill-based routing, skills must be configured.
- To use machine learning work classification, the skill model must be configured.
- To use capacity-based classification, the capacity profile must be configured.

## How to set up unified routing

The high-level process to set up unified routing for a channel or record is as follows:

1. Create workstreams.
   - Create a workstream for messaging.
     - Configure routing rules.
       - Configure manual work classification rulesets.
         - Create demand rules.
       - Configure machine-learning work classification rulesets. 
         - Set up input and output attributes.
       - Configure route-to-queues ruleset.
   - Create a workstream for record routing.
     - Configure intake rules.
     - Configure routing rules.
       - Configure work classification.
       - Configure route-to-queues ruleset.
2. Create queues.
   - Assignment methods
     - Highest capacity
     - Round robin
     - Custom assignment method
      - Configure prioritization ruleset
        - Decision list of rules
      - Assignment rulesets
        - Decision list of rules
      - Selection criteria
