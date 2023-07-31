---
title: Enroll customer in biometric authentication using Nuance Gatekeeper (preview)
description: Learn how to enroll a customer in biometric authentication using Nuance Gatekeeper. 
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection:
ms.date: 07/31/2023
ms.custom: bap-template 
---

# Enroll customers in biometric authentication using Nuance Gatekeeper (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

## Enroll customers in biometric authentication

When the agent picks up a customer call, if the customer is new, the following actions happen:

- Agent creates a customer profile.
- Asks the customer if they can be enrolled in Nuance authentication.
- The agent needs to ask for explicit consent to record the customer’s voice.

If the customer agrees to enroll and gives consent, the agent selects **Enroll**. The following events occur:

- The bot states that audio capture is starting. The agent informs the customer that the audio capture will start.
- The agent starts the audio capture for the customer.
- The agent can see the visual display of the enrollment progress.

The agent can then go on to address the customer issue.

If the customer declines to be enrolled in the Nuance Gatekeeper authentication, the agent selects the opt-out option and selects an opt-out reason that’s displayed for the agent.

## Authenticate customers using Nuance Gatekeeper

Customers who are enrolled in biometric authentication are validated automatically through the Gatekeeper feature when they call.

If the enrolled customer doesn’t pass the biometric authentication, the agent receives a “no match” response from Nuance Gatekeeper. If the agent suspects a fraud attempt, they flag the conversation as suspicious.

If the agent has flagged a conversation as suspicious, the fraud detection analyst analyzes it and adds the caller’s voice to the suspected fraudsters watch list.

Nuance Gatekeeper checks for fraud and will notify the agent about a potential fraud if it detects a voice that's flagged as a known suspicious caller.

### See also

[Introduction to Nuance Gatekeeper integration](nuance-gatekeeper-introduction.md)  