---
title: How agent enrolls a customer’s voice using Nuance Gatekeeper 
description: How-to enroll a customer's voice using Nuance Gatekeeper 
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: get-started 
ms.date: 05/24/2023
ms.custom: bap-template 
---

# How agent enrolls a customer’s voice using Nuance Gatekeeper 

When the agent picks up a customer call, if the customer is new, the following actions happen: 

- Agent creates a customer profile. 
- Asks the customer if they can be enrolled in Nuance authentication. 
- The agent needs to ask for explicit consent to record the customer’s voice. 

If the customer agrees to enroll and gives consent, the agent selects Enroll. The following events occur: 

- The bot states that audio capture is starting. The agent informs the customer that audio capture will start. 
- The agent starts the audio capture for the customer. 
- The agent can see the visual display of the enrollment progress.

The agent can then go on to address the issue for which the customer has contacted. 

When the customer calls again, they are authenticated automatically through the Gatekeeper feature.

If the customer declines to be enrolled in the Nuance Gatekeeper authentication, the agent selects the opt out option and selects an opt out reason that’s displayed for the agent. 

If the enrolled customer doesn’t pass the biometric authentication, the agent will receive a “no match” response from Nuance Gatekeeper. If the agent suspects any form of fraud attempt, the agent can proceed to flag the conversation as suspicious. 

If the agent has flagged a conversation as suspicious, aThe fraud analyst analyzes the suspicious signal and adds the caller’s voice to the suspected fraudsters watchlist. 

Nuance Gatekeeper checks for fraud and will notify the agent about a potential fraud if it detects a suspicious caller. 