---
title: "Set up unified routing | MicrosoftDocs"
description: "How to set up unified routing"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---


# Set up unified routing

## Prerequisites

Unified routing can be configured in the Omnichannel admin center or Customer Service Hub app only.

- To configure record routing, set the entity routing toggle to yes.
- To use skill-based routing, skills must be configured.
- To use machine learning work classification, the skill model must be configured and published.
- To use capacity-based classification, the capacity profile must be configured.

## How to set up unified routing

The high-level process to set up unified routing for a channel or record is as follows:

- Create a workstream for messaging.
   - Configure routing rules.
     - Configure manual work classification rulesets.
       - Create demand rules.
     - Configure machine-learning work classification rulesets. 
       - Set up input and output attributes.
       - Configure route-to-queues ruleset.

- Create a “record” workstream
    1. Configure routing rules
      
          1.	Configure work classification
          
          2.	Configure route-to-queues ruleset
      
    2.	Configure intake rules
    
     -	Create “record” queues
          1. Choose assignment method
              
              •	Out-of-the-box: Highest capacity or Round robin
              
              •	Custom assignment method
                
                i)	Configure prioritization ruleset 
                ii)	Assignment rulesets
                  
                  (1)	Decision list of rules
                  (2)	Selection criteria

2. Create queues.
   - Assignment methods.
     - Highest capacity.
     - Round robin.
     - Custom assignment method.
      - Configure prioritization ruleset.
        - Decision list of rules.
      - Assignment rulesets.
        - Decision list of rules.
      - Selection criteria.


### See also

[Create workstreams](create-workstreams.md)  
[Set up record routing](set-up-record-routing.md)  
